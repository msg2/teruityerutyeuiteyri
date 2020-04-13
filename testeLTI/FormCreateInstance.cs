using Newtonsoft.Json.Linq;
using Renci.SshNet;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace testeLTI
{
    public partial class FormCreateInstance : Form
    {
        private String floatingIp;
        private String newServerId;
        private String authToken;
        WebClient myWebClient = new WebClient();
        public bool criou;
        public int porto;
        public FormCreateInstance(String authToken)
        {
            this.authToken = authToken;
            InitializeComponent();
        }

        private void FormCreateInstance_Load(object sender, EventArgs e)
        {
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("x-auth-token", authToken);

            try
            {

                //NETWORKS
                String url = "http://127.0.0.1:9696/v2.0/networks";
                var responseString = myWebClient.DownloadString(url);

                var jo = JObject.Parse(responseString);

                foreach (var networks in jo["networks"])
                {
                    Network network = networks.ToObject<Network>();

                    comboBoxNetwork.Items.Add(network);
                }


                //IMAGES
                url = " http://127.0.0.1:8080/image/v2/images";
                responseString = myWebClient.DownloadString(url);

                jo = JObject.Parse(responseString);

                foreach (var images in jo["images"])
                {
                    Image image = images.ToObject<Image>();

                    comboBoxImage.Items.Add(image);
                }


                //FLAVORS
                url = "http://127.0.0.1:8080/compute/v2.1/flavors";
                responseString = myWebClient.DownloadString(url);

                jo = JObject.Parse(responseString);

                foreach (var flavors in jo["flavors"])
                {
                    Flavor flavor = flavors.ToObject<Flavor>();

                    comboBoxFlavor.Items.Add(flavor);
                }

            }
            catch (Exception ex)
            {
                labelErros.Text = ex.Message.ToString();
                Console.WriteLine("Error while deserializing json: " + ex.Message.ToString());
            }


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // labelErros.Text = "";
            if(comboBoxNetwork.SelectedIndex == -1 || comboBoxImage.SelectedIndex==-1 || comboBoxFlavor.SelectedIndex==-1 || Name.Trim().Length<1)
            {
                if (textBoxName.Text.Trim().Length < 1)
                {
                    labelErros.Text = labelErros.Text + "Please write the name for the Instance\n";
                }

                if (comboBoxNetwork.SelectedIndex == -1)
                {
                    labelErros.Text = labelErros.Text + "You need to select a network\n";
                }

                if (comboBoxImage.SelectedIndex == -1)
                {
                    labelErros.Text = labelErros.Text + "You need to select a image\n";
                }

                if (comboBoxFlavor.SelectedIndex == -1)
                {
                    labelErros.Text = labelErros.Text + "You need to select a flavor\n";
                }

                return;
            }

            String jsonToSend="{\"server\":{\"name\":\"" + textBoxName.Text.Trim() + "\",\"imageRef\":\"" + ((Image)comboBoxImage.SelectedItem).id + "\",\"flavorRef\":\"" + ((Flavor)comboBoxFlavor.SelectedItem).id + "\",\"networks\":[{\"uuid\":\""+ ((Network)comboBoxNetwork.SelectedItem).id + "\"}]}}";
            labelErros.Text = "Creating .....\nWait a moment";
            try
            {
                var responseString = myWebClient.UploadString("http://127.0.0.1:8080/compute/v2.1/servers", jsonToSend);

                var jo = JObject.Parse(responseString);
                newServerId = jo["server"]["id"].ToString();

                giveFloatingIp();

            }
            catch (Exception exc)
            {
                labelErros.Text = "Error creating the intance:" +exc.Message.ToString();
                Console.WriteLine("Error creating the intance: " + exc.Message.ToString());
                return;
            }

           // criou = true;
           // this.DialogResult = DialogResult.OK;
           // this.Close();
        }

        private void giveFloatingIp()
        {

            try
            {
                String url = "http://127.0.0.1:9696/v2.0/floatingip_pools";
                var responseString2 = myWebClient.DownloadString(url);

                var jo = JObject.Parse(responseString2);

                String networkID = jo["floatingip_pools"][0]["network_id"].ToString();
                String projectID = jo["floatingip_pools"][0]["project_id"].ToString();

               // Console.WriteLine(networkID + " --- " + projectID);

                String jsonToSend = null;

                String idPrivateNetwork=null;String portId = null;
                try
                {
                    
                    labelErros.Text = "Instancia criada!\nA criar floating IP ......";

                    var url3 = "http://127.0.0.1:9696/v2.0/networks";
                    var responseString = myWebClient.DownloadString(url3);
                    jo = JObject.Parse(responseString);

                    foreach (var item in jo["networks"])
                    {
                        if (item["name"].ToString() == "private")
                        {
                            idPrivateNetwork = item["id"].ToString();
                        }
                    }
                    Console.WriteLine("STEP 1 "+ idPrivateNetwork);
                    labelErros.Text = "A criar floating ip .....";
                    Thread.Sleep(6000); //dar tempo para a instancia criar,caso contrario o proximo get nao devolve nada 

                    var url4 = "http://127.0.0.1:8080/compute/v2.1/servers/"+ newServerId +"/os-interface";
                    responseString = myWebClient.DownloadString(url4);
                    jo = JObject.Parse(responseString);

                    foreach (var item in jo["interfaceAttachments"])
                    {
                        if (item["net_id"].ToString() == idPrivateNetwork)
                        {
                            portId = item["port_id"].ToString();
                        }
                    }
                    Console.WriteLine("STEP 2 "+portId);

                    jsonToSend = "{\"floatingip\": {\"project_id\": \"" + projectID + "\",\"floating_network_id\": \"" + networkID + "\", \"port_id\": \"" + portId + "\"}}";

                    responseString = myWebClient.UploadString("http://127.0.0.1:9696/v2.0/floatingips", jsonToSend);

                     //Console.WriteLine(responseString);
                    // Console.WriteLine(responseString.ToString());

                    jo = JObject.Parse(responseString);
                    floatingIp = jo["floatingip"]["floating_ip_address"].ToString();
                    Console.WriteLine("Floating ip: "+floatingIp);
                    sshCall();

                }
                catch (Exception exc)
                {
                    labelErros.Text = "Instance is created;\nError creating the floating IP";
                    Console.WriteLine("Instance is created;\nError creating the floating IP: " + exc.Message.ToString());
                    return;
                }


            }
            catch(Exception ex)
            {
                labelErros.Text = "Instance is created;\nError creating the floating IP";
                Console.WriteLine("Instance is created;\nError trying to create the floating IP: " + ex.Message);
            }
        }

        private async void sshCall()
        {
            try
            {

                labelErros.Text = "Instancia e floating Ip criados.\nA fazer o socat no servidor....";
                var connectionInfo = new ConnectionInfo("127.0.0.1", 2200, "ubuntu", new PasswordAuthenticationMethod("ubuntu", "ubuntu"));

                var port = 2201;
                var text = "Not_null_string";
                String consoleOutput = "Not_null_string";
                using (var client = new SshClient(connectionInfo))
                {
                    client.Connect();
                    
                    
                    
                    do
                    {
                        port++;
                        text = client.RunCommand(" netstat -tulpn |grep " + port.ToString()).Result;

                    } while (text.Trim() != ""); //enquanto nao encontrar um porto livre vai sempre incrementar;

                    Console.WriteLine("Porto: " + port);
                    labelErros.Text = labelErros.Text.ToString() + "\nPort: " + port;
                    await Task.Run(() =>
                    {
                        var command = $"echo -e 'ubuntu\n' | sudo -S socat TCP-LISTEN:{port},reuseaddr,fork TCP:{floatingIp}:22";
                        consoleOutput = client.RunCommand(command).Result;
                        client.Disconnect();
                    });
                }

                if (consoleOutput.Trim() != "")
                {
                    labelErros.Text = "Erro durante o ssh";
                    return;
                }

                Console.WriteLine("Socat done in port " +port);
                labelErros.Text ="Instance created + floating IP + socat port " + port;
                porto = port;

                criou = true;
                this.DialogResult = DialogResult.OK;
                this.Close();

                
            }
            catch(Exception ex)
            {
                labelErros.Text = "Instance and Floating IP are created;\n Couldn't connect trough ssh with the machine";
                Console.WriteLine("Error in the ssh "+ex.Message);
                return;
            }
        }
    }
}
