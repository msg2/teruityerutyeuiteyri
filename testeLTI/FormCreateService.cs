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
    public partial class FormCreateService : Form
    {
        String selectedNamespace;
        public bool criou { get; set; }
        WebClient myWebClient = new WebClient();
        public String clusterIP;
        public FormCreateService(String selectedNamespace)
        {
            InitializeComponent();
            this.selectedNamespace = selectedNamespace;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            labelErrors.Text = "";
            if (textBoxName.Text.Trim().Length < 1 || numericUpDownPort.Value < 1 || numericUpDownTargetPort.Value < 1 || textBoxLabel.Text.Trim() == "")
            {
                labelErrors.Text = "Please fill all the camps ";
                return;
            }

            String name = textBoxName.Text.ToLower().Trim();
            var portTarget = numericUpDownTargetPort.Value;
            var port = numericUpDownPort.Value;
            var label = textBoxLabel.Text.ToLower().Trim();

            try
            {

                String url = "http://127.0.0.1:8081/api/v1/namespaces/" + selectedNamespace.Trim() + "/services";
                var body = "{\"kind\": \"Service\",\"apiVersion\": \"v1\",\"metadata\": {\"name\": \""+name+"\",\"namespace\": \""+selectedNamespace+"\"},\"spec\": {\"ports\": [{\"port\": "+port+",\"targetPort\": "+portTarget+"}],\"selector\": {\"app\": \""+label+"\"},\"type\": \"ClusterIP\"}}";

                Console.WriteLine(url);
                Console.WriteLine(body);

                var responseString1 = myWebClient.UploadString(url, body);
                Console.WriteLine(responseString1);
                
                var jo = JObject.Parse(responseString1);

                clusterIP = jo["spec"]["clusterIP"].ToString();

                this.criou = true;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

                labelErrors.Text = "Erro: " + ex.Message;
                Console.WriteLine("Error: " + ex.Message.ToString());

            }
        }
    }
}
