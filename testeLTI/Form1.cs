using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace testeLTI
{
    public partial class Form1 : Form
    {
        private String user;
        private String password;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)  /////////// CW + tab //////////////
        {
            labelErrorNoConnection.Text = "";
            listBox1.Items.Clear();
            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            string authToken=null;
            string responseString = null;
            // demo - StrongAdminSecret
            user = textBoxUser.Text.Trim();
            password = textBoxPassword.Text.Trim();

            if(user=="" || password == "")
            {
                labelErrorNoConnection.Text = "Please fill both fields!";
                return;
            }

            String jsonToSend = "{\"auth\":{\"identity\":{\"methods\":[\"password\"],\"password\":{\"user\":{\"name\":\""+ user + "\",\"domain\":{\"name\":\"Default\"},\"password\":\"" + password + "\"}}}}}";
            //scoped project// String jsonToSend = "{\"auth\": {\"identity\": {\"methods\": [\"password\"],\"password\": {\"user\": {\"name\": \"demo\",\"domain\": {\"name\": \"Default\"},\"password\": \"StrongAdminSecret\"}}},\"scope\": {\"project\": {\"id\": \"e4208946bad94b7b92b069f354b711d7\"}}}}";

            try
            {
                responseString = myWebClient.UploadString("http://127.0.0.1:8080/identity/v3/auth/tokens/", jsonToSend);
            
            
                WebHeaderCollection myWebHeaderCollection = myWebClient.ResponseHeaders;
                for (int i = 0; i < myWebHeaderCollection.Count; i++)
                {
                    if (myWebHeaderCollection.GetKey(i) == "X-Subject-Token")
                    {
                        authToken = myWebHeaderCollection.Get(i);
                    }
                }
            }
            catch (WebException err)
            {
                listBox1.Items.Add(err.Message.Trim());
            }

            if(authToken != null)
            {
                listBox1.Items.Add(authToken);
                Console.WriteLine("\n" + authToken + "\n");      ///////////////////MANTER POR ENQUANTO, FEEDBACK VISUAL
            }


            try { 
                //Agora um get //GET servers e get projetos de um user//////
                myWebClient.Headers.Add("x-auth-token", authToken);
                //String url = "http://127.0.0.1:8080/compute/v2.1/servers";
                String url = "http://127.0.0.1:8080/identity/v3/auth/projects";
                responseString = myWebClient.DownloadString(url);
                listBox1.Items.Add("Response: " + responseString);           ///////////////////MANTER POR ENQUANTO, FEEDBACK VISUAL


                deserialiseJSON(responseString);

            }
            catch(Exception exc)
            {
                listBox1.Items.Clear();
                Console.WriteLine("Error processing the API connection: " + exc.Message.ToString());
                if (exc.Message.Contains("401"))
                {
                    labelErrorNoConnection.Text = "Incorrect User/Password";
                }
                else
                {
                    labelErrorNoConnection.Text = "Error connecting to the API";
                }
            }
            //var example1Model = new JavaScriptSerializer().Deserialize<Project>(responseString);
            // var inief = JsonConvert.DeserializeObject<dynamic>(responseString);






        }
        
        protected void deserialiseJSON(string strJSON)
        {
           try
           {
                var jo = JObject.Parse(strJSON);
                //Console.WriteLine(jo["projects"]);
                //List<Project> aaaaaa = new List<Project>();

                foreach (var projects in jo["projects"])
                {
                    Project example1Model = projects.ToObject<Project>();
                    //Console.WriteLine("id: " + example1Model.id);

                    Project prjjj = projects.ToObject<Project>();
                    //Console.WriteLine(prjjj.id);

                    //aaaaaa.Add(prjjj);
                    //listBox1.Items.Add(example1Model.ToString() +"  ID:"+example1Model.id);
                    listBox1.Items.Add(prjjj);

                }
           }
           catch (NullReferenceException ex)
           {
               Console.WriteLine("Error while deserializing json: " + ex.Message.ToString());
           }
        }

        private void buttonProjectSelected_Click(object sender, EventArgs e)
        {
            labelErrorNoProject.Text = "";
            
            if (listBox1.SelectedIndex == -1)
            {
                labelErrorNoProject.Text = "No project selected!";
                return;
            }

            try
            {
                Console.WriteLine(((Project)listBox1.SelectedItem).id);

               // String id = ((Project)listBox1.SelectedItem).id;
               
                Form2 f2 = new Form2(((Project)listBox1.SelectedItem).id, user, password);
                f2.ShowDialog();


            }
            catch (Exception exce)
            {
                labelErrorNoProject.Text = "Error: selected project have an \n invalid structure";
                Console.WriteLine("Error in the format of the response: " + exce.Message.ToString());
            }

            /*foreach(Project projeto in listaProjetos)
            {
                if(listBox1.SelectedItem.ToString() == projeto.name.ToString())
                {
                    Console.WriteLine(projeto.id);
                }
            }*/
        }

        private void textBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
