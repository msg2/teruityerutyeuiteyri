namespace testeLTI
{
    partial class FormEditVolume
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelErrors = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOldName = new System.Windows.Forms.TextBox();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericOldSize = new System.Windows.Forms.NumericUpDown();
            this.numericNewSize = new System.Windows.Forms.NumericUpDown();
            this.textBoxNewDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOldDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonSize = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericOldSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNewSize)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(111, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 108);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(459, 107);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Save";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.ForeColor = System.Drawing.Color.Red;
            this.labelErrors.Location = new System.Drawing.Point(408, 179);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(0, 13);
            this.labelErrors.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close (Without Edit)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Old Name:";
            // 
            // textBoxOldName
            // 
            this.textBoxOldName.Location = new System.Drawing.Point(123, 242);
            this.textBoxOldName.Name = "textBoxOldName";
            this.textBoxOldName.ReadOnly = true;
            this.textBoxOldName.Size = new System.Drawing.Size(100, 20);
            this.textBoxOldName.TabIndex = 11;
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(123, 268);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "New Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "New Size:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Old Size:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericOldSize
            // 
            this.numericOldSize.Location = new System.Drawing.Point(580, 243);
            this.numericOldSize.Name = "numericOldSize";
            this.numericOldSize.ReadOnly = true;
            this.numericOldSize.Size = new System.Drawing.Size(100, 20);
            this.numericOldSize.TabIndex = 17;
            // 
            // numericNewSize
            // 
            this.numericNewSize.Location = new System.Drawing.Point(580, 268);
            this.numericNewSize.Name = "numericNewSize";
            this.numericNewSize.Size = new System.Drawing.Size(100, 20);
            this.numericNewSize.TabIndex = 18;
            this.numericNewSize.ValueChanged += new System.EventHandler(this.numericNewSize_ValueChanged);
            // 
            // textBoxNewDesc
            // 
            this.textBoxNewDesc.Location = new System.Drawing.Point(332, 268);
            this.textBoxNewDesc.Name = "textBoxNewDesc";
            this.textBoxNewDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewDesc.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "New Description:";
            // 
            // textBoxOldDesc
            // 
            this.textBoxOldDesc.Location = new System.Drawing.Point(332, 242);
            this.textBoxOldDesc.Name = "textBoxOldDesc";
            this.textBoxOldDesc.ReadOnly = true;
            this.textBoxOldDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxOldDesc.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Old Description:";
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(202, 314);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(139, 17);
            this.radioButtonName.TabIndex = 23;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Mudar Nome/Descrição";
            this.radioButtonName.UseVisualStyleBackColor = true;
            this.radioButtonName.CheckedChanged += new System.EventHandler(this.radioButtonName_CheckedChanged);
            // 
            // radioButtonSize
            // 
            this.radioButtonSize.AutoSize = true;
            this.radioButtonSize.Location = new System.Drawing.Point(541, 314);
            this.radioButtonSize.Name = "radioButtonSize";
            this.radioButtonSize.Size = new System.Drawing.Size(78, 17);
            this.radioButtonSize.TabIndex = 24;
            this.radioButtonSize.TabStop = true;
            this.radioButtonSize.Text = "Mudar Size";
            this.radioButtonSize.UseVisualStyleBackColor = true;
            // 
            // FormEditVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 380);
            this.Controls.Add(this.radioButtonSize);
            this.Controls.Add(this.radioButtonName);
            this.Controls.Add(this.textBoxNewDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOldDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericNewSize);
            this.Controls.Add(this.numericOldSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOldName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.listBox1);
            this.Name = "FormEditVolume";
            this.Text = "FormEditVolume";
            this.Load += new System.EventHandler(this.FormEditVolume_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericOldSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNewSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOldName;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericOldSize;
        private System.Windows.Forms.NumericUpDown numericNewSize;
        private System.Windows.Forms.TextBox textBoxNewDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOldDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonSize;
    }
}