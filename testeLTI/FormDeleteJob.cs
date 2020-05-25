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
    public partial class FormDeleteJob : Form
    {
        String selectedNamespace;
        public bool apagou { get; set; }

        public FormDeleteJob(String selectedNamespace)
        {
            InitializeComponent();
            this.selectedNamespace = selectedNamespace;
        }

        private void FormDeleteJob_Load(object sender, EventArgs e)
        {
            WebClient myWebClient = new WebClient();

            string url = "http://" + IpAddress.ip_address + "/apis/batch/v1/namespaces/" + selectedNamespace + "/jobs";
            var responseString = myWebClient.DownloadString(url);

            var jobs = JObject.Parse(responseString);
            NSPods objectJobs = jobs.ToObject<NSPods>();
            foreach (var item in objectJobs.items)
            {
                Console.WriteLine(item.metadata.name);
                listBox1.Items.Add(item.metadata.name);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            labelErrors.Text = "";
            if (listBox1.SelectedIndex == -1)
            {
                labelErrors.Text = "Please select the Job to delete";
            }

            String job = listBox1.SelectedItem.ToString();

            var confirmResult = MessageBox.Show($"Do you really want to delete the  \"{job}\"?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    String url = "http://" + IpAddress.ip_address + "/apis/batch/v1/namespaces/" + selectedNamespace + "/jobs/" + job;
                   
                    WebRequest request = WebRequest.Create(url);
                    request.Method = "DELETE";

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    Console.WriteLine(response);
                    Console.WriteLine(response.StatusCode.ToString());
                    if (response.StatusCode != (HttpStatusCode)202 && response.StatusCode != HttpStatusCode.NoContent && response.StatusCode != HttpStatusCode.OK)
                    {
                        labelErrors.Text = "Error Deleting Job";
                        return;
                    }

                    this.apagou = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception exce)
                {
                    labelErrors.Text = "Error Deleting Job";
                    Console.WriteLine("Error del. Job: " + exce.Message.ToString());
                }

            }

            this.apagou = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
