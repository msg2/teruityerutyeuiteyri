using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeLTI
{
    public partial class FormAddImage : Form
    {
        private String authToken;
        WebClient myWebClient = new WebClient();
        private String projectId;
        public bool adicionou { get; set; }
        private String imageID;



        public FormAddImage(String projectId, String authToken)
        {
            this.projectId = projectId;
            this.authToken = authToken;
            this.adicionou = false;
            InitializeComponent();
        }

        private void FormAddImage_Load(object sender, EventArgs e)
        {
            comboBoxContainer.SelectedIndex = 0; //predifinir o bare, que é o + comum
            myWebClient.Headers.Add("x-auth-token", authToken);
            myWebClient.Headers.Add("OpenStack-API-Version", "image 2.9");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelErrors.Text = "";
            if(textBoxName.Text.Trim().Length<1 || comboBoxContainer.SelectedIndex==-1 ||comboBoxDiskFormat.SelectedIndex==-1)
            {
                labelErrors.Text = "Fill all fields";
                return;
            }

            try
            {
                myWebClient.Headers.Add("Content-Type", "application/json");
                String jsonToSend = "{\"container_format\":\"" + comboBoxContainer.SelectedItem.ToString() + "\",\"disk_format\":\"" + comboBoxDiskFormat.SelectedItem.ToString() + "\",\"name\":\"" + textBoxName.Text + "\",\"visibility\":\"shared\"}";
                String url = "http://127.0.0.1:8080/image/v2/images";
                var responseString = myWebClient.UploadString(url, jsonToSend);
                var jo = JObject.Parse(responseString);

                if (jo["id"] == null)
                {
                    labelErrors.Text = "Error: Image didnt received a ID";
                    return;
                }

                imageID = jo["id"].ToString();
                
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK) 
                {
                    string file = openFileDialog1.FileName;
                    try
                    {
                        String url1 = "http://127.0.0.1:8080/image/v2/images/"+imageID.ToString().Trim()+"/file";
                        //string text = File.ReadAllText(file);
                        WebClient myWebClient2 = new WebClient();
                        myWebClient2.Headers.Add("x-auth-token", authToken);
                        myWebClient2.Headers.Add("Content-Type", "application/octet-stream");
                        myWebClient.Headers.Add("OpenStack-API-Version", "image 2.9");
                        
                        byte[] byte123 = myWebClient2.UploadFile(url1,"PUT",file);
                        
                    }
                    catch (Exception exc)
                    {
                        labelErrors.Text = "Error updating the image!";
                        Console.WriteLine("Error: " +exc.Message.ToString());
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
               
            }
            catch (Exception ex)
            {
                labelErrors.Text = "Error creating the image in the server";
                Console.WriteLine("ERRO: " + ex.Message.ToString());
                return;
            }
        }
    }
}
