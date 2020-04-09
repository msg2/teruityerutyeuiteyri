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
            this.components = new System.ComponentModel.Container();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelListProjetos = new System.Windows.Forms.Label();
            this.buttonProjectSelected = new System.Windows.Forms.Button();
            this.labelErrorNoProject = new System.Windows.Forms.Label();
            this.labelErrorNoConnection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(338, 114);
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
            this.listBox1.Location = new System.Drawing.Point(191, 192);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(374, 160);
            this.listBox1.TabIndex = 1;
            this.listBox1.Tag = "";
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(256, 88);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 3;
            this.textBoxUser.Text = "demo";
            this.textBoxUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUser_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(392, 88);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "StrongAdminSecret";
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(292, 72);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(29, 13);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "User";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(416, 72);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // labelListProjetos
            // 
            this.labelListProjetos.AutoSize = true;
            this.labelListProjetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListProjetos.Location = new System.Drawing.Point(188, 173);
            this.labelListProjetos.Name = "labelListProjetos";
            this.labelListProjetos.Size = new System.Drawing.Size(90, 15);
            this.labelListProjetos.TabIndex = 7;
            this.labelListProjetos.Text = "Projects list :";
            // 
            // buttonProjectSelected
            // 
            this.buttonProjectSelected.Location = new System.Drawing.Point(571, 255);
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
            this.labelErrorNoProject.Location = new System.Drawing.Point(572, 285);
            this.labelErrorNoProject.Name = "labelErrorNoProject";
            this.labelErrorNoProject.Size = new System.Drawing.Size(0, 13);
            this.labelErrorNoProject.TabIndex = 9;
            // 
            // labelErrorNoConnection
            // 
            this.labelErrorNoConnection.AutoSize = true;
            this.labelErrorNoConnection.ForeColor = System.Drawing.Color.Red;
            this.labelErrorNoConnection.Location = new System.Drawing.Point(282, 140);
            this.labelErrorNoConnection.Name = "labelErrorNoConnection";
            this.labelErrorNoConnection.Size = new System.Drawing.Size(0, 13);
            this.labelErrorNoConnection.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelErrorNoConnection);
            this.Controls.Add(this.labelErrorNoProject);
            this.Controls.Add(this.buttonProjectSelected);
            this.Controls.Add(this.labelListProjetos);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelListProjetos;
        private System.Windows.Forms.Button buttonProjectSelected;
        private System.Windows.Forms.Label labelErrorNoProject;
        private System.Windows.Forms.Label labelErrorNoConnection;
    }
}

