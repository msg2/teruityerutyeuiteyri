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
    public partial class Form2 : Form
    {
        private String projectId;
        private String user;
        private String password;

        public Form2(String projectId,String user, String password)
        {
            this.projectId = projectId;
            this.user = user;
            this.password = password;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            if(projectId == null || user == null || password == null )
            {
                throw new Exception("ERROR Passing project/user information between forms!");
            }

            label1.Text = projectId; //////////////////////////////JUST DEBUG
            label2.Text = user; //////////////////////////////JUST DEBUG
            label3.Text = password; //////////////////////////////JUST DEBUG


            var myWebClient = new WebClient();
            myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            string authToken = null;
            string responseString = null;
        }
    }
}
