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
    public partial class FormCreateNetwork : Form
    {
        private String authToken;
        WebClient myWebClient = new WebClient();
        public bool adminTrue = true;
        public bool adminFalse = false;
        public bool labelVisi = false;
        public bool criou { get; set; }

        public FormCreateNetwork(String projectId, String authToken)
        {
            
            this.authToken = authToken;
            this.criou = false;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textNomeDeRede_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelErrors.Text = "";
            if (textBoxName.Text.Trim().Length < 1)
            {
                labelErrors.Text = "You need to fill the Name";
                return;
            }
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            myWebClient.Headers.Add("x-auth-token", authToken);

            String jsonToSend=null;
            String responseString = null;
            if (checkBox1.Checked)
            {
                jsonToSend = "{\"network\":{\"name\":\"" + textBoxName.Text.Trim() + "\",\"admin_state_up\": \"" + adminTrue  + "\"}}";
            }
            if(!(checkBox1.Checked))
            {
                jsonToSend = "{\"network\":{\"name\":\"" + textBoxName.Text.Trim() + "\",\"admin_state_up\": \"" + adminFalse + "\"}}";
                
            }


        
            try
            {
                Console.WriteLine(jsonToSend);
               
                String url = "http://127.0.0.1:9696/v2.0/networks";
                
                responseString = myWebClient.UploadString(url, jsonToSend);
                Console.WriteLine(responseString);
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

        private void FormCreateNetwork_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
