namespace testeLTI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelListProjetos = new System.Windows.Forms.Label();
            this.buttonProjectSelected = new System.Windows.Forms.Button();
            this.labelErrorNoProject = new System.Windows.Forms.Label();
            this.labelErrorNoConnection = new System.Windows.Forms.Label();
            this.buttonGetNamespaces = new System.Windows.Forms.Button();
            this.listBoxNamespaces = new System.Windows.Forms.ListBox();
            this.buttonSelectNamespace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelErrorGetNamespace = new System.Windows.Forms.Label();
            this.labelErrorSelectNamespace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(37, 173);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(239, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(374, 160);
            this.listBox1.TabIndex = 1;
            this.listBox1.Tag = "";
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.buttonProjectSelected_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(75, 74);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 3;
            this.textBoxUser.Text = "demo";
            this.textBoxUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUser_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(74, 126);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "StrongAdminSecret";
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(111, 58);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(29, 13);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "User";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(98, 110);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // labelListProjetos
            // 
            this.labelListProjetos.AutoSize = true;
            this.labelListProjetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListProjetos.Location = new System.Drawing.Point(236, 46);
            this.labelListProjetos.Name = "labelListProjetos";
            this.labelListProjetos.Size = new System.Drawing.Size(90, 15);
            this.labelListProjetos.TabIndex = 7;
            this.labelListProjetos.Text = "Projects list :";
            // 
            // buttonProjectSelected
            // 
            this.buttonProjectSelected.Location = new System.Drawing.Point(632, 122);
            this.buttonProjectSelected.Name = "buttonProjectSelected";
            this.buttonProjectSelected.Size = new System.Drawing.Size(122, 23);
            this.buttonProjectSelected.TabIndex = 8;
            this.buttonProjectSelected.Text = "Select Project";
            this.buttonProjectSelected.UseVisualStyleBackColor = true;
            this.buttonProjectSelected.Click += new System.EventHandler(this.buttonProjectSelected_Click);
            // 
            // labelErrorNoProject
            // 
            this.labelErrorNoProject.AutoSize = true;
            this.labelErrorNoProject.ForeColor = System.Drawing.Color.Red;
            this.labelErrorNoProject.Location = new System.Drawing.Point(629, 169);
            this.labelErrorNoProject.Name = "labelErrorNoProject";
            this.labelErrorNoProject.Size = new System.Drawing.Size(0, 13);
            this.labelErrorNoProject.TabIndex = 9;
            // 
            // labelErrorNoConnection
            // 
            this.labelErrorNoConnection.AutoSize = true;
            this.labelErrorNoConnection.ForeColor = System.Drawing.Color.Red;
            this.labelErrorNoConnection.Location = new System.Drawing.Point(45, 212);
            this.labelErrorNoConnection.Name = "labelErrorNoConnection";
            this.labelErrorNoConnection.Size = new System.Drawing.Size(0, 13);
            this.labelErrorNoConnection.TabIndex = 10;
            // 
            // buttonGetNamespaces
            // 
            this.buttonGetNamespaces.Location = new System.Drawing.Point(22, 119);
            this.buttonGetNamespaces.Name = "buttonGetNamespaces";
            this.buttonGetNamespaces.Size = new System.Drawing.Size(113, 23);
            this.buttonGetNamespaces.TabIndex = 11;
            this.buttonGetNamespaces.Text = "Get Namespaces";
            this.buttonGetNamespaces.UseVisualStyleBackColor = true;
            this.buttonGetNamespaces.Click += new System.EventHandler(this.buttonGetNamespaces_Click);
            // 
            // listBoxNamespaces
            // 
            this.listBoxNamespaces.FormattingEnabled = true;
            this.listBoxNamespaces.Location = new System.Drawing.Point(239, 318);
            this.listBoxNamespaces.Name = "listBoxNamespaces";
            this.listBoxNamespaces.Size = new System.Drawing.Size(374, 147);
            this.listBoxNamespaces.TabIndex = 12;
            // 
            // buttonSelectNamespace
            // 
            this.buttonSelectNamespace.Location = new System.Drawing.Point(632, 367);
            this.buttonSelectNamespace.Name = "buttonSelectNamespace";
            this.buttonSelectNamespace.Size = new System.Drawing.Size(122, 23);
            this.buttonSelectNamespace.TabIndex = 13;
            this.buttonSelectNamespace.Text = "Select Namespace";
            this.buttonSelectNamespace.UseVisualStyleBackColor = true;
            this.buttonSelectNamespace.Click += new System.EventHandler(this.buttonSelectNamespace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kubernetes Namespaces  :";
            // 
            // labelErrorGetNamespace
            // 
            this.labelErrorGetNamespace.AutoSize = true;
            this.labelErrorGetNamespace.ForeColor = System.Drawing.Color.Red;
            this.labelErrorGetNamespace.Location = new System.Drawing.Point(50, 420);
            this.labelErrorGetNamespace.Name = "labelErrorGetNamespace";
            this.labelErrorGetNamespace.Size = new System.Drawing.Size(0, 13);
            this.labelErrorGetNamespace.TabIndex = 15;
            // 
            // labelErrorSelectNamespace
            // 
            this.labelErrorSelectNamespace.AutoSize = true;
            this.labelErrorSelectNamespace.ForeColor = System.Drawing.Color.Red;
            this.labelErrorSelectNamespace.Location = new System.Drawing.Point(629, 410);
            this.labelErrorSelectNamespace.Name = "labelErrorSelectNamespace";
            this.labelErrorSelectNamespace.Size = new System.Drawing.Size(0, 13);
            this.labelErrorSelectNamespace.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "OPENSTACK :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "KUBERNETES :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxIP);
            this.panel1.Controls.Add(this.buttonGetNamespaces);
            this.panel1.Location = new System.Drawing.Point(44, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 168);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonLogin);
            this.panel2.Location = new System.Drawing.Point(44, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 224);
            this.panel2.TabIndex = 20;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(29, 69);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 21;
            this.textBoxIP.Text = "127.0.0.1:8081";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "IpAddress:Porto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 502);
            this.Controls.Add(this.labelErrorSelectNamespace);
            this.Controls.Add(this.labelErrorGetNamespace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelectNamespace);
            this.Controls.Add(this.listBoxNamespaces);
            this.Controls.Add(this.labelErrorNoConnection);
            this.Controls.Add(this.labelErrorNoProject);
            this.Controls.Add(this.buttonProjectSelected);
            this.Controls.Add(this.labelListProjetos);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Login Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelListProjetos;
        private System.Windows.Forms.Button buttonProjectSelected;
        private System.Windows.Forms.Label labelErrorNoProject;
        private System.Windows.Forms.Label labelErrorNoConnection;
        private System.Windows.Forms.Button buttonGetNamespaces;
        private System.Windows.Forms.ListBox listBoxNamespaces;
        private System.Windows.Forms.Button buttonSelectNamespace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelErrorGetNamespace;
        private System.Windows.Forms.Label labelErrorSelectNamespace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label4;
    }
}

