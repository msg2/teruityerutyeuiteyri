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
    public partial class FormDeleteService : Form
    {
        WebClient myWebClient = new WebClient();
        String selectedNamespace;
        public bool apagou { get; set; }

        public FormDeleteService(String selectedNamespace)
        {
            InitializeComponent();
            this.selectedNamespace = selectedNamespace;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            labelErrors.Text = "";
            if (listBox1.SelectedIndex == -1)
            {
                labelErrors.Text = "Please select the Service to delete";
            }

            String service = listBox1.SelectedItem.ToString();

            var confirmResult = MessageBox.Show($"Do you really want to delete the Service \"{service}\"?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    String url = "http://127.0.0.1:8081/api/v1/namespaces/" + selectedNamespace + "/services/" + service;

                    WebRequest request = WebRequest.Create(url);
                    request.Method = "DELETE";

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    Console.WriteLine(response);
                    Console.WriteLine(response.StatusCode.ToString());
                    if (response.StatusCode != (HttpStatusCode)202 && response.StatusCode != HttpStatusCode.NoContent && response.StatusCode != HttpStatusCode.OK)
                    {
                        labelErrors.Text = "Error Deleting Service";
                        return;
                    }

                    this.apagou = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception exce)
                {
                    labelErrors.Text = "Error Deleting Deployment";
                    Console.WriteLine("Error del. Deployment: " + exce.Message.ToString());
                }

            }

            this.apagou = true;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void FormDeleteService_Load(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:8081/api/v1/namespaces/" + selectedNamespace + "/services";
            var responseString = myWebClient.DownloadString(url);

            var services = JObject.Parse(responseString);
            NSPods objServices = services.ToObject<NSPods>();
            foreach (var item in objServices.items)
            {
                Console.WriteLine(item.metadata.name);
                listBox1.Items.Add(item.metadata.name);
            }
        }

    }
}
