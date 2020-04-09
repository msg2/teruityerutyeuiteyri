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
    public partial class FormEditInstance : Form
    {
        private String authToken;
        WebClient myWebClient = new WebClient();
        private String projectId;
        private Server server;

        public FormEditInstance(String authToken, String projectId)
        {
            this.authToken = authToken;
            this.projectId = projectId;
            InitializeComponent();
        }

        private void FormEditInstance_Load(object sender, EventArgs e)
        {
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("x-auth-token", authToken);

            try
            {
                myWebClient.Headers.Add("X-OpenStack-Nova-API-Version", "2.82");
                String url = "http://127.0.0.1:8080/compute/v2.1/servers/" + projectId;

                var responseString = myWebClient.DownloadString(url);

                var jo = JObject.Parse(responseString);

                server = jo["server"].ToObject<Server>();

                textBoxOldName.Text = server.name;
            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR: " + ex.Message.ToString());
            }
            
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            if (textBoxNome.Text.Trim().Length < 1)
            {
                labelErrors.Text = "Please choose the new name.";
                return;
            }

            String jsonToSend = "{\"server\":{\"name\":\"" + textBoxNome.Text.Trim() + "\"}}";
            try
            {
                String url = "http://127.0.0.1:8080/compute/v2.1/servers/" + projectId;

                var responseString = myWebClient.UploadString(url, "PUT",jsonToSend);

            }
            catch (Exception ex )
            {
                labelErrors.Text = ex.Message.ToString();
                Console.WriteLine("Error: " + ex.Message.ToString());
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonOk_Click(this, new EventArgs());
            }
        }
    }
}
