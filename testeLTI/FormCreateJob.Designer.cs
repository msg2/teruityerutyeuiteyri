namespace testeLTI
{
    partial class FormCreateJob
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearchImage = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxManualImage = new System.Windows.Forms.CheckBox();
            this.textBoxManualImage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelErrors = new System.Windows.Forms.Label();
            this.comboBoxRestartPolicy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(684, 285);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(94, 114);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Image:";
            // 
            // textBoxSearchImage
            // 
            this.textBoxSearchImage.Location = new System.Drawing.Point(384, 115);
            this.textBoxSearchImage.Name = "textBoxSearchImage";
            this.textBoxSearchImage.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchImage.TabIndex = 18;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(505, 112);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(338, 153);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(298, 155);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(468, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "If the desired image is not present, select the checkbox bellow and write the ima" +
    "ge name manually";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(411, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Be aware that if the name doesnt match any image name the deployment will not wor" +
    "k";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Image Name:";
            // 
            // checkBoxManualImage
            // 
            this.checkBoxManualImage.AutoSize = true;
            this.checkBoxManualImage.Location = new System.Drawing.Point(272, 353);
            this.checkBoxManualImage.Name = "checkBoxManualImage";
            this.checkBoxManualImage.Size = new System.Drawing.Size(15, 14);
            this.checkBoxManualImage.TabIndex = 27;
            this.checkBoxManualImage.UseVisualStyleBackColor = true;
            this.checkBoxManualImage.CheckedChanged += new System.EventHandler(this.checkBoxManualImage_CheckedChanged);
            // 
            // textBoxManualImage
            // 
            this.textBoxManualImage.Location = new System.Drawing.Point(369, 351);
            this.textBoxManualImage.Name = "textBoxManualImage";
            this.textBoxManualImage.Size = new System.Drawing.Size(100, 20);
            this.textBoxManualImage.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Restart Policy";
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(72, 252);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(238, 20);
            this.textBoxCommand.TabIndex = 31;
            this.textBoxCommand.Text = "\"perl\",  \"-Mbignum=bpi\", \"-wle\", \"print bpi(2000)\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Command";
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.ForeColor = System.Drawing.Color.Red;
            this.labelErrors.Location = new System.Drawing.Point(702, 186);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(0, 13);
            this.labelErrors.TabIndex = 33;
            // 
            // comboBoxRestartPolicy
            // 
            this.comboBoxRestartPolicy.FormattingEnabled = true;
            this.comboBoxRestartPolicy.Items.AddRange(new object[] {
            "OnFailure",
            "Never"});
            this.comboBoxRestartPolicy.Location = new System.Drawing.Point(131, 176);
            this.comboBoxRestartPolicy.Name = "comboBoxRestartPolicy";
            this.comboBoxRestartPolicy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRestartPolicy.TabIndex = 34;
            // 
            // FormCreateJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxRestartPolicy);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxManualImage);
            this.Controls.Add(this.checkBoxManualImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreate);
            this.Name = "FormCreateJob";
            this.Text = "FormCreateJob";
            this.Load += new System.EventHandler(this.FormCreateJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearchImage;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxManualImage;
        private System.Windows.Forms.TextBox textBoxManualImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.ComboBox comboBoxRestartPolicy;
    }
}