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


        private void buttonLogin_Click(object sender, EventArgs e) 
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
                labelErrorNoConnection.Text = "Error connecting to the API";
                Console.WriteLine(err.Message.Trim());
                return;
            }

            try { 
                if(authToken == null)
                {
                    labelErrorNoConnection.Text = "Error: authToken shouldn't be null!";
                    return;
                }
                myWebClient.Headers.Add("x-auth-token", authToken);
                String url = "http://127.0.0.1:8080/identity/v3/auth/projects";
                responseString = myWebClient.DownloadString(url);

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
        }
        
        protected void deserialiseJSON(string strJSON)
        {
           try
           {
                var jo = JObject.Parse(strJSON);

                foreach (var projects in jo["projects"])
                {
                    Project prjjj = projects.ToObject<Project>();
                    
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

                Form2 f2 = new Form2(((Project)listBox1.SelectedItem).id, user, password,((Project)listBox1.SelectedItem).name);
                f2.ShowDialog();


            }
            catch (Exception exce)
            {
                labelErrorNoProject.Text = "Error: selected project have an \n invalid structure";
                Console.WriteLine("Error in the format of the response: " + exce.Message.ToString());
            }
        }

        private void textBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(this, new EventArgs());
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(this, new EventArgs());
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonProjectSelected_Click(this, new EventArgs());
            }
        }

        private void buttonGetNamespaces_Click(object sender, EventArgs e)
        {
            var myWebClient = new WebClient();
            labelErrorGetNamespace.Text = "";
            listBoxNamespaces.Items.Clear();

            try
            {
                String url = "http://127.0.0.1:8081/api/v1/namespaces";
                var responseString = myWebClient.DownloadString(url);

                var jo = JObject.Parse(responseString);
                NamespacesList namespacesList = jo.ToObject<NamespacesList>();

                if(namespacesList.items==null || namespacesList.items.Count == 0)
                {
                    labelErrorGetNamespace.Text = "Não existe qualquer namespace";
                    return;
                }

                foreach (var inamespace in namespacesList.items)
                {
                    //Console.WriteLine(inamespace.metadata.name);
                    listBoxNamespaces.Items.Add(inamespace.metadata.name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to kubernetes: " + ex.Message);
                labelErrorGetNamespace.Text = "Error connecting to kubernetes: " + ex.Message;
            }
           
        }

        private void buttonSelectNamespace_Click(object sender, EventArgs e)
        {
            labelErrorSelectNamespace.Text = "";
            var myWebClient = new WebClient();


            if (listBoxNamespaces.SelectedIndex == -1)
            {
                labelErrorSelectNamespace.Text = "No Namespace selected!";
                return;
            }

            FormNamespaceDashboard fnd = new FormNamespaceDashboard(listBoxNamespaces.SelectedItem.ToString());
            fnd.ShowDialog();

        }

    }
}
