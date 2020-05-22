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
    public partial class FormCreateDeployment : Form
    {
        String selectedNamespace;
        public bool criou { get; set; }
        WebClient myWebClient = new WebClient();

        public FormCreateDeployment(String selectedNamespace)
        {
            InitializeComponent();
            this.selectedNamespace = selectedNamespace;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

            labelErrors.Text = "";
            if (textBoxName.Text.Trim().Length < 1 || numericUpDown1.Value < 1 || numericUpDownPort.Value < 1 || textBoxLabel.Text.Trim()=="")
            {
                labelErrors.Text = "Please fill all the camps ";
                return;
            }
            if (listView1.SelectedItems.Count != 1 && checkBoxManualImage.Checked == false)
            {
                labelErrors.Text = "You need to select an \nimage or manually write the image\n name for the container";
                return;
            }
            if(checkBoxManualImage.Checked==true && textBoxManualImage.Text.Trim() == "")
            {
                labelErrors.Text = "If you check the checkbox you need\nto write the image name by yourself";
                return;
            }

            if(checkBoxManualImage.Checked==true && textBoxManualImage.Text.Trim() != "")
            {
                String checkImageUrl= "https://index.docker.io/v1/repositories/"+ textBoxManualImage.Text.Trim() + "/tags/latest";
                WebRequest request = WebRequest.CreateHttp(checkImageUrl);
                request.Method = "GET";
                HttpWebResponse response = null;
                try
                {
                    response = (HttpWebResponse)request.GetResponse();

                }
                catch (Exception ex)
                {
                    if (response == null) //porque deu 404 ou seja aquela imagem não existe
                    {
                        labelErrors.Text = "Invalid Image name!";
                        return;
                    }
                    else
                    {
                        labelErrors.Text = ex.Message;
                    }

                }
            }

            String deploymentName = textBoxName.Text.ToLower().Trim();
            var podsNumber = numericUpDown1.Value;
            var port = numericUpDownPort.Value;
            var label = textBoxLabel.Text.ToLower().Trim();

            string image = null;
            if (checkBoxManualImage.Checked==false)
            {
                 image = listView1.SelectedItems[0].Text.Trim();
            }
            else
            {
                 image = textBoxManualImage.Text.Trim();
            }

            try
            {
                String url = "http://127.0.0.1:8081/apis/apps/v1/namespaces/" + selectedNamespace.Trim() + "/deployments";
                var body = "{\"apiVersion\": \"apps/v1\",\"kind\": \"Deployment\",\"metadata\": {\"name\": \"" + deploymentName + "\",\"labels\": {\"app\": \""+label+"\"}},\"spec\": {\"replicas\": " + podsNumber + ",\"selector\": {\"matchLabels\": {\"app\": \""+label+"\"}},\"template\": {\"metadata\": {\"labels\": {\"app\": \""+label+"\"}},\"spec\": {\"containers\": [{\"name\": \""+image+"\",\"image\": \""+image+":latest\",\"ports\": [{\"containerPort\": " + port +"}]}]}}}}";

                Console.WriteLine(url);
                Console.WriteLine(body);
                
                var responseString1 = myWebClient.UploadString(url, body);
                Console.WriteLine(responseString1);

                this.criou = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                labelErrors.Text = "Erro: " + ex.Message ;
                Console.WriteLine("Error: " + ex.Message.ToString());

            }
            

            

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            labelErrors.Text = "";
            listView1.Items.Clear();
            if (textBoxSearchImage.Text.Trim().Length < 1)
            {
                labelErrors.Text = "You need to enter \nthe image name that \nyou are looking for";
                return;
            }

            String url = "https://hub.docker.com/v2/search/repositories/?query=" + textBoxSearchImage.Text.Trim()+ "&page_size=30";
            var responseString = myWebClient.DownloadString(url);

            var jo = JObject.Parse(responseString);

            


            foreach (var item in jo["results"])
            {
                ListViewItem lvi = new ListViewItem(item["repo_name"].ToString());
                lvi.SubItems.Add(item["short_description"].ToString());
                listView1.Items.Add(lvi);
            }

        }

        private void FormCreateDeployment_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Description");
            listView1.View = View.Details; //make column headings visible

            textBoxManualImage.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxManualImage.Checked == false)
            {
                textBoxManualImage.Enabled = false;
                textBoxManualImage.Text = "";
                textBoxSearchImage.Enabled = true;

            }
            else
            {
                textBoxSearchImage.Enabled = false;
                textBoxManualImage.Enabled = true;
            }
        }
    }
}
