namespace testeLTI
{
    partial class FormNamespaceDashboard
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
            this.labelDeploy = new System.Windows.Forms.Label();
            this.labelServices = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelReplicaSets = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPods = new System.Windows.Forms.Label();
            this.labelErrors = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCreateDeployment = new System.Windows.Forms.Button();
            this.labelDeployment = new System.Windows.Forms.Label();
            this.buttonDeleteDeployment = new System.Windows.Forms.Button();
            this.buttonRefreshInstances = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeploy
            // 
            this.labelDeploy.AutoSize = true;
            this.labelDeploy.Location = new System.Drawing.Point(470, 60);
            this.labelDeploy.Name = "labelDeploy";
            this.labelDeploy.Size = new System.Drawing.Size(90, 13);
            this.labelDeploy.TabIndex = 35;
            this.labelDeploy.Text = "labelDeployments";
            // 
            // labelServices
            // 
            this.labelServices.AutoSize = true;
            this.labelServices.Location = new System.Drawing.Point(448, 83);
            this.labelServices.Name = "labelServices";
            this.labelServices.Size = new System.Drawing.Size(70, 13);
            this.labelServices.TabIndex = 38;
            this.labelServices.Text = "labelServices";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(137, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Nr. of Replica Sets: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(346, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Nr. of Services: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(345, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Nr. of Deployments:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(65, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(151, 15);
            this.labelTitle.TabIndex = 40;
            this.labelTitle.Text = "Namespace Summary:";
            // 
            // labelReplicaSets
            // 
            this.labelReplicaSets.AutoSize = true;
            this.labelReplicaSets.Location = new System.Drawing.Point(266, 83);
            this.labelReplicaSets.Name = "labelReplicaSets";
            this.labelReplicaSets.Size = new System.Drawing.Size(70, 13);
            this.labelReplicaSets.TabIndex = 34;
            this.labelReplicaSets.Text = "labelRepSets";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Nr. of Pods: ";
            // 
            // labelPods
            // 
            this.labelPods.AutoSize = true;
            this.labelPods.Location = new System.Drawing.Point(222, 60);
            this.labelPods.Name = "labelPods";
            this.labelPods.Size = new System.Drawing.Size(60, 13);
            this.labelPods.TabIndex = 30;
            this.labelPods.Text = "labelNpods";
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.ForeColor = System.Drawing.Color.Red;
            this.labelErrors.Location = new System.Drawing.Point(91, 96);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(0, 13);
            this.labelErrors.TabIndex = 27;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(48, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(658, 105);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // buttonCreateDeployment
            // 
            this.buttonCreateDeployment.Location = new System.Drawing.Point(85, 219);
            this.buttonCreateDeployment.Name = "buttonCreateDeployment";
            this.buttonCreateDeployment.Size = new System.Drawing.Size(131, 23);
            this.buttonCreateDeployment.TabIndex = 48;
            this.buttonCreateDeployment.Text = "Create Deployment";
            this.buttonCreateDeployment.UseVisualStyleBackColor = true;
            this.buttonCreateDeployment.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDeployment
            // 
            this.labelDeployment.AutoSize = true;
            this.labelDeployment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.labelDeployment.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelDeployment.Location = new System.Drawing.Point(65, 294);
            this.labelDeployment.Name = "labelDeployment";
            this.labelDeployment.Size = new System.Drawing.Size(0, 15);
            this.labelDeployment.TabIndex = 49;
            // 
            // buttonDeleteDeployment
            // 
            this.buttonDeleteDeployment.Location = new System.Drawing.Point(85, 261);
            this.buttonDeleteDeployment.Name = "buttonDeleteDeployment";
            this.buttonDeleteDeployment.Size = new System.Drawing.Size(131, 23);
            this.buttonDeleteDeployment.TabIndex = 50;
            this.buttonDeleteDeployment.Text = "Delete Deployment";
            this.buttonDeleteDeployment.UseVisualStyleBackColor = true;
            this.buttonDeleteDeployment.Click += new System.EventHandler(this.buttonDeleteDeployment_Click);
            // 
            // buttonRefreshInstances
            // 
            this.buttonRefreshInstances.Font = new System.Drawing.Font("Wingdings 3", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonRefreshInstances.Location = new System.Drawing.Point(13, 76);
            this.buttonRefreshInstances.Name = "buttonRefreshInstances";
            this.buttonRefreshInstances.Size = new System.Drawing.Size(29, 27);
            this.buttonRefreshInstances.TabIndex = 51;
            this.buttonRefreshInstances.Text = "Q";
            this.buttonRefreshInstances.UseVisualStyleBackColor = true;
            this.buttonRefreshInstances.Click += new System.EventHandler(this.buttonRefreshInstances_Click);
            // 
            // FormNamespaceDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRefreshInstances);
            this.Controls.Add(this.buttonDeleteDeployment);
            this.Controls.Add(this.labelDeployment);
            this.Controls.Add(this.buttonCreateDeployment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDeploy);
            this.Controls.Add(this.labelServices);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelReplicaSets);
            this.Controls.Add(this.labelPods);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormNamespaceDashboard";
            this.Text = "FormNamespaceDashboard";
            this.Load += new System.EventHandler(this.FormNamespaceDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeploy;
        private System.Windows.Forms.Label labelServices;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelReplicaSets;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPods;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonCreateDeployment;
        private System.Windows.Forms.Label labelDeployment;
        private System.Windows.Forms.Button buttonDeleteDeployment;
        private System.Windows.Forms.Button buttonRefreshInstances;
    }
}