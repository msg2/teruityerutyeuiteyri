using k8s;
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
        IKubernetes client;

        public FormNamespaceDashboard(IKubernetes client, String namespaceSelected)
        {
            InitializeComponent();
            this.namespaceSelected = namespaceSelected;
            this.client = client;
        }

        private void FormNamespaceDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                var podsList = client.ListNamespacedPod(namespaceSelected);
                labelPods.Text = podsList.Items.Count.ToString();
                
                var servicesList = client.ListNamespacedService(namespaceSelected);
                labelServices.Text = servicesList.Items.Count.ToString();

                var replicasList = client.ListNamespacedReplicaSet(namespaceSelected);
                labelReplicaSets.Text = replicasList.Items.Count.ToString();

                var deploymentsList = client.ListNamespacedDeployment(namespaceSelected);
                labelDeploy.Text = deploymentsList.Items.Count.ToString();


            }
            catch (Exception ex)
            {
                labelErrors.Text = "Erro: " + ex.Message;
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

    }
}
