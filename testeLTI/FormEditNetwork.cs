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
    public partial class FormEditNetwork : Form
    {

        private String authToken;
        WebClient myWebClient = new WebClient();
        private String projectId;
        public bool editou { get; set; }
        private String networkID;
        public bool adminTrue = true;
        public bool adminFalse = false;

        public FormEditNetwork(String projectId, String authToken)
        {
            this.projectId = projectId;
            this.authToken = authToken;
            this.editou = false;
            InitializeComponent();
        }

        private void FormEditNetwork_Load(object sender, EventArgs e)
        {
            myWebClient.Headers.Add("x-auth-token", authToken);
            getList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String jsonToSend = null;
            String responseString = null;
            if (listBox1.SelectedIndex == -1 || (textBoxNewName.Text.Trim().Length < 1 && textBoxOldName.Text.Trim().Length > 0))
            {
                labelErrors.Text = "Uma Rede tem de estar selecionada, e o nome tem de estar preenchido";
                return;
            }
            if (checkBox1.Checked)
            {
                jsonToSend = "{\"network\":{\"name\":\"" + textBoxNewName.Text.Trim() + "\",\"admin_state_up\": \"" + adminTrue + "\"}}";
            }
            if (!(checkBox1.Checked))
            {
                jsonToSend = "{\"network\":{\"name\":\"" + textBoxNewName.Text.Trim() + "\",\"admin_state_up\": \"" + adminFalse + "\"}}";

            }
            if (textBoxNewName.Text != textBoxOldName.Text || checkBox1.Checked || !(checkBox1.Checked))
            {
                try
                {
                    
                    String url1 = "http://127.0.0.1:9696/v2.0/networks/" + networkID;

                    var responseString1 = myWebClient.UploadString(url1, "PUT", jsonToSend);
                    Console.WriteLine(responseString1);
                    Console.WriteLine(responseString1.ToString());


                }
                catch (Exception ex)
                {
                    labelErrors.Text = "Erro ao atualizar Nome";
                    Console.WriteLine("Erro: " + ex.Message.ToString());
                    getList();
                    return;
                }
            }


            this.DialogResult = DialogResult.OK;
            this.Close();

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxOldName.Text = ((Network)listBox1.SelectedItem).name;

            textBoxNewName.Text = ((Network)listBox1.SelectedItem).name;
            
            checkBox1.Checked = ((Network)listBox1.SelectedItem).admin_state_up;

            networkID = ((Network)listBox1.SelectedItem).id;
        }


        private void getList()
        {
            try
            {
                
                listBox1.Items.Clear();
                
                String url = "http://127.0.0.1:9696/v2.0/networks";
                var responseString = myWebClient.DownloadString(url);

                var jo = JObject.Parse(responseString);

                foreach (var networks in jo["networks"])
                {
                    Network network = networks.ToObject<Network>();

                    listBox1.Items.Add(network);
                }

            }
            catch (Exception ex)
            {
                labelErrors.Text = "Error while deserializing json";
                Console.WriteLine("Error while deserializing json: " + ex.Message.ToString());
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
