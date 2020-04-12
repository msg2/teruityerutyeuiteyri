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
    public partial class FormDeleteVolume : Form
    {
        private String authToken;
        WebClient myWebClient = new WebClient();
        private String projectId;
        public bool apagou { get; set; }
       

        public FormDeleteVolume(String projectId, String authToken)
        {
            this.projectId = projectId;
            this.authToken = authToken;
            this.apagou = false;
            InitializeComponent();
        }

        private void FormDeleteVolume_Load(object sender, EventArgs e)
        {
            myWebClient.Headers.Add("x-auth-token", authToken);

            try
            {
                listBox1.Items.Clear();
                String url = "http://127.0.0.1:8080/volume/v3/"+projectId+"/volumes/detail";
                var responseString = myWebClient.DownloadString(url);

                var jo = JObject.Parse(responseString);

                foreach (var volumes in jo["volumes"])
                {
                    Volume volume = volumes.ToObject<Volume>();

                    listBox1.Items.Add(volume);
                }
            }
            catch (Exception ex)
            {
                labelErrors.Text = "Error Error while deserializing json";
                Console.WriteLine("Error while deserializing json: " + ex.Message.ToString());
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            labelErrors.Text = "";
            if (listBox1.SelectedIndex == -1)
            {
                labelErrors.Text =  "Please select the volume to delete";
            }

            var confirmResult = MessageBox.Show($"Do you really want to delete \"{listBox1.SelectedItem}\" Volume?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    string id = ((Volume)listBox1.SelectedItem).id;
                    String url = "http://127.0.0.1:8080/volume/v3/" + projectId + "/volumes/" + id;
                    // var responseString = myWebClient.DownloadString(url);

                    WebRequest request = WebRequest.Create(url);
                    request.Method = "DELETE";
                    request.Headers.Add("x-auth-token", authToken);

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    Console.WriteLine(response);
                    if (response.StatusCode != (HttpStatusCode)202 && response.StatusCode != HttpStatusCode.NoContent)
                    {
                        labelErrors.Text = "Error Deleting Voltume";
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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
