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
    public partial class FormNamespaceDashboard : Form
    {
        String namespaceSelected;
        WebClient myWebClient = new WebClient();

        public FormNamespaceDashboard(String namespaceSelected)
        {
            InitializeComponent();
            this.namespaceSelected = namespaceSelected;
        }

        private void FormNamespaceDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                String url = "http://127.0.0.1:8081/api/v1/namespaces/" + namespaceSelected + "/pods";
                var responseString = myWebClient.DownloadString(url);
                
                var pods = JObject.Parse(responseString);
                NSPods objectPods = pods.ToObject<NSPods>();
                var nPods = objectPods.items.Count;

                labelPods.Text = nPods.ToString();

                /////
                
                url = "http://127.0.0.1:8081/api/v1/namespaces/" + namespaceSelected + "/services";
                responseString = myWebClient.DownloadString(url);

                var services = JObject.Parse(responseString);
                NSPods objectServices = services.ToObject<NSPods>(); 
                var nServices = objectServices.items.Count;

                labelServices.Text = nServices.ToString();

                /////
                url = "http://127.0.0.1:8081/apis/apps/v1/namespaces/" + namespaceSelected + "/replicasets";
                responseString = myWebClient.DownloadString(url);

                var repsets = JObject.Parse(responseString);
                NSPods objectRepset = repsets.ToObject<NSPods>();
                var nReplicasets = objectRepset.items.Count;

                labelReplicaSets.Text = nReplicasets.ToString();

                ///

                url = "http://127.0.0.1:8081/apis/apps/v1/namespaces/" + namespaceSelected + "/deployments";
                responseString = myWebClient.DownloadString(url);

                var deployments = JObject.Parse(responseString);
                NSPods objectDeployments = deployments.ToObject<NSPods>();
                var nDeployments = objectDeployments.items.Count;

                labelDeploy.Text = nDeployments.ToString();

            }
            catch (Exception ex)
            {
                labelErrors.Text = "Erro: " + ex.Message;
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

    }
}
