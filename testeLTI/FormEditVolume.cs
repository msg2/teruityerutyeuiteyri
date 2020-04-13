using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeLTI
{
    public partial class FormEditVolume : Form
    {
        private String authToken;
        WebClient myWebClient = new WebClient();
        private String projectId;
        public bool editou { get; set; }
        private String volumeID;


        public FormEditVolume(String projectId, String authToken)
        {
            this.projectId = projectId;
            this.authToken = authToken;
            this.editou = false;
            InitializeComponent();
        }

        private void FormEditVolume_Load(object sender, EventArgs e)
        {
            myWebClient.Headers.Add("x-auth-token", authToken);

            getList();

            RadioButton[] rbs = new RadioButton[5];
            rbs[0] = radioButtonName;
            rbs[1] = radioButtonSize;

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(radioButtonSize.Checked==false && radioButtonName.Checked == false)
            {
                labelErrors.Text = "É necessario escolher se quer alterar o Nome/Descrição ou o Size";
                return;
            }

            if(listBox1.SelectedIndex==-1 || (textBoxNewName.Text.Trim().Length < 1 && textBoxOldName.Text.Trim().Length>0) || numericNewSize.Value < 1)
            {
                labelErrors.Text = "Um volume tem de estar selecionado, e ambos os campos Nome e Size preenchidos";
                return;
            }

            if (textBoxNewName.Text == textBoxOldName.Text && numericNewSize.Value == numericOldSize.Value && textBoxNewDesc == textBoxOldDesc)
            {
                labelErrors.Text = "Não foi editado nenhum campo";
                return;
            }

            if (numericNewSize.Value < numericOldSize.Value)
            {
                labelErrors.Text = "Só é permitido aumentar o size";
            }

            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";

            String jsonToSend = "{\"os-extend\":{\"new_size\":"+ numericNewSize.Value +"}}";

            if (numericOldSize.Value != numericNewSize.Value)
            {
                try
                {
                    myWebClient.Headers.Add("OpenStack-API-Version", "volume 3.60");
                    String url = "http://127.0.0.1:8080/volume/v3/" + projectId + "/volumes/" + volumeID + "/action";

                    var responseString = myWebClient.UploadString(url, jsonToSend);


                }
                catch (Exception ex)
                {
                    labelErrors.Text = "Erro ao atualizar o Size do volume";
                    Console.WriteLine("ERRO: " + ex.Message.ToString());
                    return;
                }
            }
            String jsonToSend1 = "{\"volume\":{\"name\":\""+ textBoxNewName.Text +"\",\"description\":\""+ textBoxNewDesc.Text +"\"}}";         
            if(textBoxNewDesc.Text != textBoxOldDesc.Text || textBoxNewName.Text != textBoxOldName.Text)
            {
                try
                {
                    String url1 = "http://127.0.0.1:8080/volume/v3/" + projectId + "/volumes/" + volumeID;

                    var responseString1 = myWebClient.UploadString(url1, "PUT", jsonToSend1);
                    Console.WriteLine(responseString1);
                    Console.WriteLine(responseString1.ToString());


                }
                catch (Exception ex)
                {
                    labelErrors.Text = "Erro ao atualizar Nome/Descrição";
                    Console.WriteLine("Erro: " + ex.Message.ToString());
                    getList();
                    return;
                }
            }
            

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxOldName.Text = ((Volume)listBox1.SelectedItem).name;
            numericOldSize.Value = ((Volume)listBox1.SelectedItem).size;
            textBoxNewName.Text = ((Volume)listBox1.SelectedItem).name;
            numericNewSize.Value = ((Volume)listBox1.SelectedItem).size;
            textBoxOldDesc.Text = ((Volume)listBox1.SelectedItem).description;
            textBoxNewDesc.Text = ((Volume)listBox1.SelectedItem).description;



            volumeID = ((Volume)listBox1.SelectedItem).id;
        }

        private void getList()
        {
            try
            {
                listBox1.Items.Clear();
                String url = "http://127.0.0.1:8080/volume/v3/" + projectId + "/volumes/detail";
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
                labelErrors.Text = "Error while deserializing json";
                Console.WriteLine("Error while deserializing json: " + ex.Message.ToString());
            }
        }

        private void numericNewSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonName_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonSize.Checked)
            {
                textBoxNewDesc.Enabled = false;
                textBoxNewName.Enabled = false;
                textBoxNewName.Text = ((Volume)listBox1.SelectedItem).name;
                textBoxNewDesc.Text = ((Volume)listBox1.SelectedItem).description;
                numericNewSize.Enabled = true;
            }
            else
            {
                textBoxNewDesc.Enabled = true;
                textBoxNewName.Enabled = true;
                numericNewSize.Enabled = false;
                numericNewSize.Value = ((Volume)listBox1.SelectedItem).size;
            }
        }

        private void radioButtonSize_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOldName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
