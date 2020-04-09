using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeLTI
{
    public partial class Form2 : Form
    {
        private String projectId;
        private String user;
        private String password;
        private String projectName;
        WebClient myWebClient = new WebClient();
        private string globalAuthToken;


        public Form2(String projectId,String user, String password, String projectName)
        {
            this.projectId = projectId;
            this.user = user;
            this.password = password;
            this.projectName = projectName;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            if(projectId == null || user == null || password == null )
            {
                throw new Exception("ERROR passing project/user information between forms!");
            }

            label1.Text = projectId; //////////////////////////////JUST DEBUG
            label2.Text = user; //////////////////////////////JUST DEBUG
            label3.Text = password; //////////////////////////////JUST DEBUG

            labelTitle.Text = $"Project \"{projectName}\" Summary:";
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            string authToken = null;
            string responseString = null;

            String jsonToSend = "{\"auth\": {\"identity\": {\"methods\": [\"password\"],\"password\": {\"user\": {\"name\": \"" + user + "\",\"domain\": {\"name\": \"Default\"},\"password\": \"" + password + "\"}}},\"scope\": {\"project\": {\"id\": \"" + projectId + "\"}}}}";

            try
            {
                responseString = myWebClient.UploadString("http://127.0.0.1:8080/identity/v3/auth/tokens/", jsonToSend);
                WebHeaderCollection myWebHeaderCollection = myWebClient.ResponseHeaders;
                for (int i = 0; i < myWebHeaderCollection.Count; i++)
                {
                    if (myWebHeaderCollection.GetKey(i) == "X-Subject-Token")
                    {
                        authToken = myWebHeaderCollection.Get(i);
                    }
                }
                globalAuthToken = authToken;
            }
            catch (WebException err)
            {
                listBox1.Items.Add(err.Message.Trim()); /////////////////////debug
                labelErrors.Text = "Error connecting to the API";
                Console.WriteLine(err.Message.Trim());
                return;
            }


            try
            {
                if (authToken == null)
                {
                    labelErrors.Text = "Error: authToken shouldn't be null!";
                    return;
                }

                myWebClient.Headers.Add("x-auth-token", authToken);

                //String url = "http://127.0.0.1:8080/compute/v2.1/servers";
                String url = "http://127.0.0.1:8080/compute/v2.1/limits";
                responseString = myWebClient.DownloadString(url);

                var jo = JObject.Parse(responseString);
                DashLimitInfo server = jo["limits"]["absolute"].ToObject<DashLimitInfo>();



                labelInstances.Text = $" {server.totalInstancesUsed} of {server.maxTotalInstances} used";
                labelVCPUs.Text = $" {server.totalCoresUsed} of {server.maxTotalCores} used";
                if (server.totalRAMUsed > 1024)
                {
                    labelRam.Text = $" {server.totalRAMUsed/1024.0}GB of {Math.Round(server.maxTotalRAMSize / 1024.0)}GB used";
                }
                else
                {
                    labelRam.Text = $" {server.totalRAMUsed}MB of {Math.Round(server.maxTotalRAMSize/1024.0)}GB used";
                }



                ///// GET n Volumes, Storage, Snapshots
                JToken nVolumes = 0; JToken storage = 0; JToken snapshots = 0;
                try
                {
                    String url1 = "http://127.0.0.1:8080/volume/v3/" + projectId + "/volumes/summary";
                    myWebClient.Headers["OpenStack-API-Version"] = "volume 3.60";

                    responseString = myWebClient.DownloadString(url1);
                    var jo1 = JObject.Parse(responseString);

                    nVolumes = jo1["volume-summary"]["total_count"];
                    storage = jo1["volume-summary"]["total_size"];

                    String url2 = "http://127.0.0.1:8080/volume/v3/" + projectId + "/snapshots/detail";
                    myWebClient.Headers["with_count"] = "true";
                    if (jo1["snapshots"] != null)
                    {
                        snapshots = jo1["snapshots"]["count"];
                    }
                }
                catch (Exception ex)
                {
                    labelErrors.Text = "Error while getting nVolumes/Snapshots/Storage";
                    Console.WriteLine("Error while getting nVolumes/Snapshots/Storage - " + ex);
                }

                labelVolumes.Text = $" {nVolumes} used";
                labelSnapshots.Text = $" {snapshots} used";
                labelStorage.Text = $" {storage}GB used";



                //// GET n Floating IPs, Networks, 
                int nFloatingIps = 0; int nNetworks = 0; int nRouters = 0;
                try
                {
                    String url3 = "http://192.168.182.136:9696/v2.0/floatingips";
                    responseString = myWebClient.DownloadString(url3);
                    var jo1 = JObject.Parse(responseString);

                    foreach (var item in jo1["floatingips"])
                    {
                        nFloatingIps++; 
                    }

                    //

                    url3 = "http://192.168.182.136:9696/v2.0/networks";
                    responseString = myWebClient.DownloadString(url3);
                    jo1 = JObject.Parse(responseString);

                    foreach (var item in jo1["networks"])
                    {
                        nNetworks++;
                    }

                    //

                    url3 = "http://192.168.182.136:9696/v2.0/routers";
                    responseString = myWebClient.DownloadString(url3);
                    jo1 = JObject.Parse(responseString);

                    foreach (var item in jo1["routers"])
                    {
                        nRouters++;
                    }
                }
                catch (Exception ex)
                {
                    labelErrors.Text= "Error while getting nFloating IPs/nNetworks/nRouters";
                    Console.WriteLine("Error while getting nFloating IPs/nNetworks/nRouters - " + ex.Message);
                    return;
                }


                labelFloating.Text = $" {nFloatingIps} used";
                labelNetworks.Text = $"{nNetworks} used";
                labelRouters.Text = $" {nRouters} used";

            }
            catch (Exception exc)
            {
                //listBox1.Items.Clear();
                labelErrors.Text = "Error connecting to the API";
                Console.WriteLine("Error processing the API connection: " + exc.Message.ToString());
                return;
            }

            getServers();

        }

        protected void getServers()
        {
            try
            {
                listBox1.Items.Clear();
                String url = "http://127.0.0.1:8080/compute/v2.1/servers";
                var responseString = myWebClient.DownloadString(url);

                var jo = JObject.Parse(responseString);

                foreach (var servers in jo["servers"])
                {
                    Server server = servers.ToObject<Server>();

                    listBox1.Items.Add(server);
                }
            }
            catch (Exception ex)
            {
                labelErrors.Text = "Error Error while deserializing json";
                Console.WriteLine("Error while deserializing json: " + ex.Message.ToString());
            }
        }


        private void buttonDeleteInstance_Click(object sender, EventArgs e)
        {
            labelErrorsInstance.Text = "";

            if (listBox1.SelectedIndex == -1)
            {
                labelErrorsInstance.Text = "Please select the instance to delete!";
                return;
            }

            var confirmResult = MessageBox.Show($"Do you really want to delete \"{listBox1.SelectedItem}\" instance?","Delete Confirmation", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    string id = ((Server)listBox1.SelectedItem).id;
                    String url = "http://127.0.0.1:8080/compute/v2.1/servers/"+id;
                   // var responseString = myWebClient.DownloadString(url);

                    WebRequest request = WebRequest.Create(url);
                    request.Method = "DELETE";
                    request.Headers.Add("x-auth-token", globalAuthToken);

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    Console.WriteLine(response);
                    if (response.StatusCode != HttpStatusCode.OK && response.StatusCode != HttpStatusCode.NoContent)
                    {
                        labelErrorsInstance.Text = "Error Deleting Instance";
                    }
                    

                }
                catch (Exception exce)
                {
                    labelErrorsInstance.Text = "Error Deleting Instance";
                    Console.WriteLine("Error del. instance: " + exce.Message.ToString());
                }

                getServers();
            }
            else
            {
                labelErrorsInstance.Text = "Delete aborted.";
            }
        }

        private void buttonRefreshInstances_Click(object sender, EventArgs e)
        {
            getServers();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateInstance_Click(object sender, EventArgs e)
        {
            FormCreateInstance fct = new FormCreateInstance(globalAuthToken);
            fct.FormClosed += fct_FormClosed;
            fct.Show();
        }

        void fct_FormClosed(object sender, FormClosedEventArgs e)
        {
            getServers();
        }

        private void buttonEditInstance_Click(object sender, EventArgs e)
        {
            labelErrorsInstance.Text = "";

            if (listBox1.SelectedIndex == -1)
            {
                labelErrorsInstance.Text = "Please select the instance to edit!";
                return;
            }

            string id = ((Server)listBox1.SelectedItem).id;
            FormEditInstance fe = new FormEditInstance(globalAuthToken, id);
            fe.FormClosed += fct_FormClosed;
            fe.Show();
        }

        private void buttonCreateVolume_Click(object sender, EventArgs e)
        {
            //FormCreateVolume fc = new FormCreateVolume(projectId,globalAuthToken);
            //fc.FormClosed += fc_FormClosed;
            //fc.Show();
            using (var form = new FormCreateVolume(projectId,globalAuthToken))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form.criou)
                    {
                        labelOptionsVolumes.Text = "Volume successfully created";
                    }
                }
            }
        }

        private void labelOptionsVolumes_Click(object sender, EventArgs e)
        {
            labelOptionsVolumes.Text = "";
        }

        private void buttonDeleteVolume_Click(object sender, EventArgs e)
        {
            using (var form = new FormDeleteVolume(projectId, globalAuthToken))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form != null)
                    {
                        labelOptionsVolumes.Text = "Volume deleted successfully";
                    }
                }
            }

        }

        private void buttonEditVolume_Click(object sender, EventArgs e)
        {
            using (var form = new FormEditVolume(projectId, globalAuthToken))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form != null)
                    {
                        labelOptionsVolumes.Text = "Volume edited successfully";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
