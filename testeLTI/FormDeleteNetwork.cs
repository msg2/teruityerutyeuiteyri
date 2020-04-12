using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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
    public partial class FormDeleteNetwork : Form
    {
        private String authToken;
        WebClient myWebClient = new WebClient();
        private String projectId;
        public bool apagou { get; set; }
        public FormDeleteNetwork(String projectId, String authToken)
        {
            this.projectId = projectId;
            this.authToken = authToken;
            this.apagou = false;
            InitializeComponent();
        }

        private void FormDeleteNetwork_Load(object sender, EventArgs e)
        {
            myWebClient.Headers.Add("x-auth-token", authToken);

            try
            {
                listBox1.Items.Clear();
                String url = "http://127.0.0.1:9696/v2.0/networks/";
                var responseString = myWebClient.DownloadString(url);

                var jo = JObject.Parse(responseString);

                foreach (var networks in jo["networks"])
                {
                    Network network = networks.ToObject<Network>();

                    listBox1.Items.Add(network);
                }
            }
            catch (Exception ex)
            {
                labelErrors.Text = "Error Error while deserializing json";
                Console.WriteLine("Error while deserializing json: " + ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelErrors.Text = "";
            if (listBox1.SelectedIndex == -1)
            {
                labelErrors.Text = "Please select the network to delete";
            }
            var confirmResult = MessageBox.Show($"Do you really want to delete \"{listBox1.SelectedItem}\" Network?", "Delete Confirmation", MessageBoxButtons.YesNo);

            try
            {
                string id = ((Network)listBox1.SelectedItem).id;
                String url = "http://127.0.0.1:9696/v2.0/networks/" + id;
                // var responseString = myWebClient.DownloadString(url);

                WebRequest request = WebRequest.Create(url);
                request.Method = "DELETE";
                request.Headers.Add("x-auth-token", authToken);

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Console.WriteLine(response);
                if (response.StatusCode != (HttpStatusCode)202 && response.StatusCode != HttpStatusCode.NoContent)
                {
                    labelErrors.Text = "Error Deleting Network";
                    return;
                }

                this.apagou = true;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception exce)
            {
                labelErrors.Text = "Error Deleting Network";
                Console.WriteLine("Error del. Network: " + exce.Message.ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
