using k8s;
using k8s.Models;
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
        String selectedNamespace;
        WebClient myWebClient = new WebClient();
        IKubernetes client;

        public FormNamespaceDashboard(IKubernetes client, String selectedNamespace)
        {
            InitializeComponent();
            this.selectedNamespace = selectedNamespace;
            this.client = client;
        }

        private void FormNamespaceDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                var podsList = client.ListNamespacedPod(selectedNamespace);
                labelPods.Text = podsList.Items.Count.ToString();

                var servicesList = client.ListNamespacedService(selectedNamespace);
                labelServices.Text = servicesList.Items.Count.ToString();

                var replicasList = client.ListNamespacedReplicaSet(selectedNamespace);
                labelReplicaSets.Text = replicasList.Items.Count.ToString();

                var deploymentsList = client.ListNamespacedDeployment(selectedNamespace);
                labelDeploy.Text = deploymentsList.Items.Count.ToString();

                /*
                IDictionary<string, string> tryLabel = new Dictionary<string, string>();
                tryLabel.Add("123", "345");
                var metadata = new V1ObjectMeta(name:"testeClient", labels:tryLabel );
                var spec = new V1DeploymentSpec();
                var status = new V1DeploymentStatus();  
                client.CreateNamespacedDeployment(new V1Deployment("apps/v1", "Deployment", metadata, spec, status), selectedNamespace) ;
                */
                
                /* string deploymentName;
                deploymentName = "dddd";//passar sempre para lowecases

                var myWebClient = new WebClient();
                String url = "http://127.0.0.1:8081/apis/apps/v1/namespaces/" + selectedNamespace.Trim() + "/deployments";
                //var body = "{\"apiVersion\": \"apps/v1\",\"kind\": \"Deployment\",\"metadata\": {\"name\": \"deploymentexample\"},\"spec\": {\"replicas\": 3,\"revisionHistoryLimit\": 10,\"template\": {\"metadata\": {\"labels\": {\"app\": \"nginx\"}},\"spec\": {\"containers\": {\"name\": \"nginx\",\"image\": \"nginx:1.11\",\"ports\": {\"containerPort\": 80}}}}}}";
                var body = "{\"apiVersion\": \"apps/v1\",\"kind\": \"Deployment\",\"metadata\": {\"name\": \""+deploymentName+"\",\"labels\": {\"app\": \"nginx\"}},\"spec\": {\"replicas\": 3,\"selector\": {\"matchLabels\": {\"app\": \"nginx\"}},\"template\": {\"metadata\": {\"labels\": {\"app\": \"nginx\"}},\"spec\": {\"containers\": [{\"name\": \"nginx\",\"image\": \"nginx:1.14.2\",\"ports\": [{\"containerPort\": 80}]}]}}}}";

                Console.WriteLine(url);
                Console.WriteLine(body);
                var responseString1 = myWebClient.UploadString(url, body);

                Console.WriteLine(responseString1);*/
            }
            catch (Exception ex)
            {
                labelErrors.Text = "Erro: " + ex.Message;
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new FormCreateDeployment(selectedNamespace))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form.criou)
                    {
                        System.Threading.Thread.Sleep(2000); //dar tempo para os dados do dashboard atualizarem

                        labelDeployment.Text = "Deployment successfully created";
                        this.FormNamespaceDashboard_Load(sender, e);
                    }
                }
            }
        }

        private void buttonDeleteDeployment_Click(object sender, EventArgs e)
        {
            using (var form = new FormDeleteDeployment(selectedNamespace))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form.apagou)
                    {
                        System.Threading.Thread.Sleep(2000); //dar tempo para os dados do dashboard atualizarem
                        labelDeployment.Text = "Deployment eliminated sucessfully";
                        this.FormNamespaceDashboard_Load(sender, e);
                    }
                }
            }
        }

        private void buttonRefreshInstances_Click(object sender, EventArgs e)
        {
            this.FormNamespaceDashboard_Load(sender, e);
        }

        private void buttonCreateJob_Click(object sender, EventArgs e)
        {
            using (var form = new FormCreateJob(selectedNamespace))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form.criou)
                    {
                        System.Threading.Thread.Sleep(2000); //dar tempo para os dados do dashboard atualizarem

                        labelDeployment.Text = "Job successfully created";
                        this.FormNamespaceDashboard_Load(sender, e);
                    }
                }
            }
        }

        private void buttonDeleteJob_Click(object sender, EventArgs e)
        {
            using (var form = new FormDeleteJob(selectedNamespace))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form.apagou)
                    {
                        System.Threading.Thread.Sleep(2000); //dar tempo para os dados do dashboard atualizarem
                        labelDeployment.Text = "Job eliminated sucessfully";
                        this.FormNamespaceDashboard_Load(sender, e);
                    }
                }
            }
        }
    }

}

   