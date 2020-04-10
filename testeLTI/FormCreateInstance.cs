using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;

namespace testeLTI
{
    public partial class FormCreateInstance : Form
    {
        private String authToken;
        WebClient myWebClient = new WebClient();
        public bool criou;
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
            labelErros.Text = "";
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
                    labelErros.Text = labelErros.Text + "You need to select a image\n"; ///////TENTAR PERMITIR CRIAR SEM MAS COM BLOCK
                }

                if (comboBoxFlavor.SelectedIndex == -1)
                {
                    labelErros.Text = labelErros.Text + "You need to select a flavor\n";
                }

                return;
            }

            String jsonToSend="{\"server\":{\"name\":\"" + textBoxName.Text.Trim() + "\",\"imageRef\":\"" + ((Image)comboBoxImage.SelectedItem).id + "\",\"flavorRef\":\"" + ((Flavor)comboBoxFlavor.SelectedItem).id + "\",\"networks\":[{\"uuid\":\""+ ((Network)comboBoxNetwork.SelectedItem).id + "\"}]}}";

            try
            {
                var responseString = myWebClient.UploadString("http://127.0.0.1:8080/compute/v2.1/servers", jsonToSend);

                Console.WriteLine(responseString);
                Console.WriteLine(responseString.ToString());

            }
            catch (Exception exc)
            {
                labelErros.Text = exc.Message.ToString();
                Console.WriteLine("Error creating the intance: " + exc.Message.ToString());
                return;
            }

            criou = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
