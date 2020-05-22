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
    public partial class FormDeleteDeployment : Form
    {
        String selectedNamespace;
        public bool apagou { get; set; }

        public FormDeleteDeployment(String selectedNamespace)
        {
            InitializeComponent();
            this.selectedNamespace = selectedNamespace;
        }

        private void FormDeleteDeployment_Load(object sender, EventArgs e)
        {
            WebClient myWebClient = new WebClient();

            string url = "http://127.0.0.1:8081/apis/apps/v1/namespaces/" + selectedNamespace + "/deployments";
            var responseString = myWebClient.DownloadString(url);

            var deployments = JObject.Parse(responseString);
            NSPods objectDeployments = deployments.ToObject<NSPods>();
            foreach (var item in objectDeployments.items)
            {
                Console.WriteLine(item.metadata.name);
                listBox1.Items.Add(item.metadata.name);
            }
            //var nDeployments = objectDeployments.items.Count;
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            labelErrors.Text = "";
            if (listBox1.SelectedIndex == -1)
            {
                labelErrors.Text = "Please select the Deployment to delete";
            }

            String deployment = listBox1.SelectedItem.ToString();

            var confirmResult = MessageBox.Show($"Do you really want to delete the deployment \"{deployment}\"?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    String url = "http://127.0.0.1:8081/apis/apps/v1/namespaces/"+selectedNamespace+"/deployments/"+ deployment;
                    // var responseString = myWebClient.DownloadString(url);

                    WebRequest request = WebRequest.Create(url);
                    request.Method = "DELETE";

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    Console.WriteLine(response);
                    Console.WriteLine(response.StatusCode.ToString());
                    if (response.StatusCode != (HttpStatusCode)202 && response.StatusCode != HttpStatusCode.NoContent && response.StatusCode!=HttpStatusCode.OK)
                    {
                        labelErrors.Text = "Error Deleting Deployment";
                        return;
                    }

                    this.apagou = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception exce)
                {
                    labelErrors.Text = "Error Deleting Volume";
                    Console.WriteLine("Error del. Volume: " + exce.Message.ToString());
                }

            }

            this.apagou = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
