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
    public partial class FormCreateVolume : Form
    {
        private String authToken;
        WebClient myWebClient = new WebClient();
        private String projectId;
        public bool criou { get; set; }


        public FormCreateVolume(String projectId, String authToken)
        {
            this.projectId = projectId;
            this.authToken = authToken;
            this.criou = false;
            InitializeComponent();
        }
        
        
        private void FormCreateVolume_Load(object sender, EventArgs e)
        {

        }
        
        
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            labelErrors.Text = "";
            if (textBoxName.Text.Trim().Length < 1 || numericUpDown1.Value<1)
            {
                labelErrors.Text = "You need to fill the Name and Volume";
                return;
            }

            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("x-auth-token", authToken);

            String jsonToSend; String responseString=null;
            if (textBoxName.Text.Trim().Length < 1)
            {
                 jsonToSend = "{\"volume\":{\"name\":\"" + textBoxName.Text.Trim() + "\",\"size\": \"" + numericUpDown1.Value + "\"}}";
            }
            else
            {
                 jsonToSend = "{\"volume\":{\"name\":\"" + textBoxName.Text.Trim() + "\",\"size\": \"" + numericUpDown1.Value + "\",\"description\": \"" + textBoxDescription.Text.Trim() + "\"}}";

            }

            try
            {
                String url = "http://127.0.0.1:8080/volume/v3/"+projectId +"/volumes" ;

                responseString = myWebClient.UploadString(url, jsonToSend);

                this.criou = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                labelErrors.Text = responseString;
                Console.WriteLine("Error: " + ex.Message.ToString());
            }

        }

        
    }
}
