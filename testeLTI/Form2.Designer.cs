﻿namespace testeLTI
{
    partial class Form2
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
            this.labelErrors = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRam = new System.Windows.Forms.Label();
            this.labelVCPUs = new System.Windows.Forms.Label();
            this.labelInstances = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelNetworks = new System.Windows.Forms.Label();
            this.labelVolumes = new System.Windows.Forms.Label();
            this.labelStorage = new System.Windows.Forms.Label();
            this.labelSnapshots = new System.Windows.Forms.Label();
            this.labelRouters = new System.Windows.Forms.Label();
            this.labelFloating = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCreateInstance = new System.Windows.Forms.Button();
            this.buttonEditInstance = new System.Windows.Forms.Button();
            this.buttonDeleteInstance = new System.Windows.Forms.Button();
            this.labelErrorsInstance = new System.Windows.Forms.Label();
            this.buttonRefreshInstances = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonCreateVolume = new System.Windows.Forms.Button();
            this.buttonEditVolume = new System.Windows.Forms.Button();
            this.buttonDeleteVolume = new System.Windows.Forms.Button();
            this.labelOptionsVolumes = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.labelOptionsImages = new System.Windows.Forms.Label();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.buttonOpenConsole = new System.Windows.Forms.Button();
            this.label1Instances = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonCreateNetwork = new System.Windows.Forms.Button();
            this.buttonEditNetwork = new System.Windows.Forms.Button();
            this.buttonDeleteNetwork = new System.Windows.Forms.Button();
            this.labelOptionsNetworks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(70, 222);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(447, 147);
            this.listBox1.TabIndex = 3;
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.ForeColor = System.Drawing.Color.Red;
            this.labelErrors.Location = new System.Drawing.Point(440, 159);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(0, 13);
            this.labelErrors.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Instances List:";
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.Location = new System.Drawing.Point(288, 88);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(51, 13);
            this.labelRam.TabIndex = 6;
            this.labelRam.Text = "labelRam";
            // 
            // labelVCPUs
            // 
            this.labelVCPUs.AutoSize = true;
            this.labelVCPUs.Location = new System.Drawing.Point(301, 111);
            this.labelVCPUs.Name = "labelVCPUs";
            this.labelVCPUs.Size = new System.Drawing.Size(63, 13);
            this.labelVCPUs.TabIndex = 7;
            this.labelVCPUs.Text = "labelVCPUs";
            // 
            // labelInstances
            // 
            this.labelInstances.AutoSize = true;
            this.labelInstances.Location = new System.Drawing.Point(317, 65);
            this.labelInstances.Name = "labelInstances";
            this.labelInstances.Size = new System.Drawing.Size(75, 13);
            this.labelInstances.TabIndex = 8;
            this.labelInstances.Text = "labelInstances";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "RAM: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "VCPUs: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Instances: ";
            // 
            // labelNetworks
            // 
            this.labelNetworks.AutoSize = true;
            this.labelNetworks.Location = new System.Drawing.Point(719, 65);
            this.labelNetworks.Name = "labelNetworks";
            this.labelNetworks.Size = new System.Drawing.Size(74, 13);
            this.labelNetworks.TabIndex = 12;
            this.labelNetworks.Text = "labelNetworks";
            // 
            // labelVolumes
            // 
            this.labelVolumes.AutoSize = true;
            this.labelVolumes.Location = new System.Drawing.Point(504, 65);
            this.labelVolumes.Name = "labelVolumes";
            this.labelVolumes.Size = new System.Drawing.Size(69, 13);
            this.labelVolumes.TabIndex = 13;
            this.labelVolumes.Text = "labelVolumes";
            // 
            // labelStorage
            // 
            this.labelStorage.AutoSize = true;
            this.labelStorage.Location = new System.Drawing.Point(540, 88);
            this.labelStorage.Name = "labelStorage";
            this.labelStorage.Size = new System.Drawing.Size(66, 13);
            this.labelStorage.TabIndex = 14;
            this.labelStorage.Text = "labelStorage";
            // 
            // labelSnapshots
            // 
            this.labelSnapshots.AutoSize = true;
            this.labelSnapshots.Location = new System.Drawing.Point(553, 111);
            this.labelSnapshots.Name = "labelSnapshots";
            this.labelSnapshots.Size = new System.Drawing.Size(79, 13);
            this.labelSnapshots.TabIndex = 15;
            this.labelSnapshots.Text = "labelSnapshots";
            // 
            // labelRouters
            // 
            this.labelRouters.AutoSize = true;
            this.labelRouters.Location = new System.Drawing.Point(706, 88);
            this.labelRouters.Name = "labelRouters";
            this.labelRouters.Size = new System.Drawing.Size(66, 13);
            this.labelRouters.TabIndex = 16;
            this.labelRouters.Text = "labelRouters";
            // 
            // labelFloating
            // 
            this.labelFloating.AutoSize = true;
            this.labelFloating.Location = new System.Drawing.Point(727, 111);
            this.labelFloating.Name = "labelFloating";
            this.labelFloating.Size = new System.Drawing.Size(66, 13);
            this.labelFloating.TabIndex = 17;
            this.labelFloating.Text = "labelFloating";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(219, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(120, 15);
            this.labelTitle.TabIndex = 18;
            this.labelTitle.Text = "Project Summary:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(440, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Volumes:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(440, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Volume Storage:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(440, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Volume Snapshots: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(654, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Routers:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(654, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Networks: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(654, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Floating IPs:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(208, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(658, 105);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // buttonCreateInstance
            // 
            this.buttonCreateInstance.Location = new System.Drawing.Point(72, 392);
            this.buttonCreateInstance.Name = "buttonCreateInstance";
            this.buttonCreateInstance.Size = new System.Drawing.Size(129, 23);
            this.buttonCreateInstance.TabIndex = 27;
            this.buttonCreateInstance.Text = "Create Instance";
            this.buttonCreateInstance.UseVisualStyleBackColor = true;
            this.buttonCreateInstance.Click += new System.EventHandler(this.buttonCreateInstance_Click);
            // 
            // buttonEditInstance
            // 
            this.buttonEditInstance.Location = new System.Drawing.Point(231, 392);
            this.buttonEditInstance.Name = "buttonEditInstance";
            this.buttonEditInstance.Size = new System.Drawing.Size(129, 23);
            this.buttonEditInstance.TabIndex = 28;
            this.buttonEditInstance.Text = "Edit Instance";
            this.buttonEditInstance.UseVisualStyleBackColor = true;
            this.buttonEditInstance.Click += new System.EventHandler(this.buttonEditInstance_Click);
            // 
            // buttonDeleteInstance
            // 
            this.buttonDeleteInstance.Location = new System.Drawing.Point(388, 392);
            this.buttonDeleteInstance.Name = "buttonDeleteInstance";
            this.buttonDeleteInstance.Size = new System.Drawing.Size(129, 23);
            this.buttonDeleteInstance.TabIndex = 29;
            this.buttonDeleteInstance.Text = "Delete Instance";
            this.buttonDeleteInstance.UseVisualStyleBackColor = true;
            this.buttonDeleteInstance.Click += new System.EventHandler(this.buttonDeleteInstance_Click);
            // 
            // labelErrorsInstance
            // 
            this.labelErrorsInstance.AutoSize = true;
            this.labelErrorsInstance.ForeColor = System.Drawing.Color.Red;
            this.labelErrorsInstance.Location = new System.Drawing.Point(69, 425);
            this.labelErrorsInstance.Name = "labelErrorsInstance";
            this.labelErrorsInstance.Size = new System.Drawing.Size(0, 13);
            this.labelErrorsInstance.TabIndex = 30;
            // 
            // buttonRefreshInstances
            // 
            this.buttonRefreshInstances.Font = new System.Drawing.Font("Wingdings 3", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonRefreshInstances.Location = new System.Drawing.Point(35, 284);
            this.buttonRefreshInstances.Name = "buttonRefreshInstances";
            this.buttonRefreshInstances.Size = new System.Drawing.Size(29, 27);
            this.buttonRefreshInstances.TabIndex = 31;
            this.buttonRefreshInstances.Text = "Q";
            this.buttonRefreshInstances.UseVisualStyleBackColor = true;
            this.buttonRefreshInstances.Click += new System.EventHandler(this.buttonRefreshInstances_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(607, 478);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(256, 23);
            this.buttonBack.TabIndex = 32;
            this.buttonBack.Text = "Voltar à lista de Projetos";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(604, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "Volumes";
            // 
            // buttonCreateVolume
            // 
            this.buttonCreateVolume.Location = new System.Drawing.Point(571, 240);
            this.buttonCreateVolume.Name = "buttonCreateVolume";
            this.buttonCreateVolume.Size = new System.Drawing.Size(129, 23);
            this.buttonCreateVolume.TabIndex = 34;
            this.buttonCreateVolume.Text = "Create Volume";
            this.buttonCreateVolume.UseVisualStyleBackColor = true;
            this.buttonCreateVolume.Click += new System.EventHandler(this.buttonCreateVolume_Click);
            // 
            // buttonEditVolume
            // 
            this.buttonEditVolume.Location = new System.Drawing.Point(571, 288);
            this.buttonEditVolume.Name = "buttonEditVolume";
            this.buttonEditVolume.Size = new System.Drawing.Size(129, 23);
            this.buttonEditVolume.TabIndex = 35;
            this.buttonEditVolume.Text = "Edit Volume";
            this.buttonEditVolume.UseVisualStyleBackColor = true;
            this.buttonEditVolume.Click += new System.EventHandler(this.buttonEditVolume_Click);
            // 
            // buttonDeleteVolume
            // 
            this.buttonDeleteVolume.Location = new System.Drawing.Point(571, 338);
            this.buttonDeleteVolume.Name = "buttonDeleteVolume";
            this.buttonDeleteVolume.Size = new System.Drawing.Size(129, 23);
            this.buttonDeleteVolume.TabIndex = 36;
            this.buttonDeleteVolume.Text = "Delete Volume";
            this.buttonDeleteVolume.UseVisualStyleBackColor = true;
            this.buttonDeleteVolume.Click += new System.EventHandler(this.buttonDeleteVolume_Click);
            // 
            // labelOptionsVolumes
            // 
            this.labelOptionsVolumes.AutoSize = true;
            this.labelOptionsVolumes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.labelOptionsVolumes.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelOptionsVolumes.Location = new System.Drawing.Point(552, 378);
            this.labelOptionsVolumes.Name = "labelOptionsVolumes";
            this.labelOptionsVolumes.Size = new System.Drawing.Size(0, 15);
            this.labelOptionsVolumes.TabIndex = 37;
            this.labelOptionsVolumes.Click += new System.EventHandler(this.labelOptionsVolumes_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(832, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 15);
            this.label13.TabIndex = 38;
            this.label13.Text = "Images";
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(795, 240);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(129, 23);
            this.buttonAddImage.TabIndex = 39;
            this.buttonAddImage.Text = "Add Image";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // labelOptionsImages
            // 
            this.labelOptionsImages.AutoSize = true;
            this.labelOptionsImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.labelOptionsImages.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelOptionsImages.Location = new System.Drawing.Point(780, 328);
            this.labelOptionsImages.Name = "labelOptionsImages";
            this.labelOptionsImages.Size = new System.Drawing.Size(0, 15);
            this.labelOptionsImages.TabIndex = 40;
            this.labelOptionsImages.Click += new System.EventHandler(this.labelOptionsImages_Click);
            // 
            // buttonDeleteImage
            // 
            this.buttonDeleteImage.Location = new System.Drawing.Point(795, 284);
            this.buttonDeleteImage.Name = "buttonDeleteImage";
            this.buttonDeleteImage.Size = new System.Drawing.Size(129, 23);
            this.buttonDeleteImage.TabIndex = 41;
            this.buttonDeleteImage.Text = "Delete Image";
            this.buttonDeleteImage.UseVisualStyleBackColor = true;
            this.buttonDeleteImage.Click += new System.EventHandler(this.buttonDeleteImage_Click);
            // 
            // buttonOpenConsole
            // 
            this.buttonOpenConsole.Location = new System.Drawing.Point(166, 445);
            this.buttonOpenConsole.Name = "buttonOpenConsole";
            this.buttonOpenConsole.Size = new System.Drawing.Size(236, 23);
            this.buttonOpenConsole.TabIndex = 42;
            this.buttonOpenConsole.Text = "OpenConsole";
            this.buttonOpenConsole.UseVisualStyleBackColor = true;
            this.buttonOpenConsole.Click += new System.EventHandler(this.buttonOpenConsole_Click);
            // 
            // label1Instances
            // 
            this.label1Instances.AutoSize = true;
            this.label1Instances.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label1Instances.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1Instances.Location = new System.Drawing.Point(81, 423);
            this.label1Instances.Name = "label1Instances";
            this.label1Instances.Size = new System.Drawing.Size(0, 15);
            this.label1Instances.TabIndex = 43;
            this.label1Instances.Click += new System.EventHandler(this.label1Instances_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1050, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 15);
            this.label14.TabIndex = 44;
            this.label14.Text = "Networks";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // buttonCreateNetwork
            // 
            this.buttonCreateNetwork.Location = new System.Drawing.Point(1020, 240);
            this.buttonCreateNetwork.Name = "buttonCreateNetwork";
            this.buttonCreateNetwork.Size = new System.Drawing.Size(129, 23);
            this.buttonCreateNetwork.TabIndex = 45;
            this.buttonCreateNetwork.Text = "Create Network";
            this.buttonCreateNetwork.UseVisualStyleBackColor = true;
            this.buttonCreateNetwork.Click += new System.EventHandler(this.buttonCreateNetwork_Click);
            // 
            // buttonEditNetwork
            // 
            this.buttonEditNetwork.Location = new System.Drawing.Point(1020, 288);
            this.buttonEditNetwork.Name = "buttonEditNetwork";
            this.buttonEditNetwork.Size = new System.Drawing.Size(129, 23);
            this.buttonEditNetwork.TabIndex = 46;
            this.buttonEditNetwork.Text = "Edit Network";
            this.buttonEditNetwork.UseVisualStyleBackColor = true;
            this.buttonEditNetwork.Click += new System.EventHandler(this.buttonEditNetwork_Click);
            // 
            // buttonDeleteNetwork
            // 
            this.buttonDeleteNetwork.Location = new System.Drawing.Point(1020, 338);
            this.buttonDeleteNetwork.Name = "buttonDeleteNetwork";
            this.buttonDeleteNetwork.Size = new System.Drawing.Size(129, 23);
            this.buttonDeleteNetwork.TabIndex = 47;
            this.buttonDeleteNetwork.Text = "Delete Network";
            this.buttonDeleteNetwork.UseVisualStyleBackColor = true;
            this.buttonDeleteNetwork.Click += new System.EventHandler(this.buttonDeleteNetwork_Click);
            // 
            // labelOptionsNetworks
            // 
            this.labelOptionsNetworks.AutoSize = true;
            this.labelOptionsNetworks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.labelOptionsNetworks.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelOptionsNetworks.Location = new System.Drawing.Point(984, 378);
            this.labelOptionsNetworks.Name = "labelOptionsNetworks";
            this.labelOptionsNetworks.Size = new System.Drawing.Size(0, 15);
            this.labelOptionsNetworks.TabIndex = 48;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 513);
            this.Controls.Add(this.labelOptionsNetworks);
            this.Controls.Add(this.buttonDeleteNetwork);
            this.Controls.Add(this.buttonEditNetwork);
            this.Controls.Add(this.buttonCreateNetwork);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1Instances);
            this.Controls.Add(this.buttonOpenConsole);
            this.Controls.Add(this.buttonDeleteImage);
            this.Controls.Add(this.labelOptionsImages);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelOptionsVolumes);
            this.Controls.Add(this.buttonDeleteVolume);
            this.Controls.Add(this.buttonEditVolume);
            this.Controls.Add(this.buttonCreateVolume);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRefreshInstances);
            this.Controls.Add(this.labelErrorsInstance);
            this.Controls.Add(this.buttonDeleteInstance);
            this.Controls.Add(this.buttonEditInstance);
            this.Controls.Add(this.buttonCreateInstance);
            this.Controls.Add(this.labelVolumes);
            this.Controls.Add(this.labelRouters);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelFloating);
            this.Controls.Add(this.labelSnapshots);
            this.Controls.Add(this.labelStorage);
            this.Controls.Add(this.labelNetworks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelInstances);
            this.Controls.Add(this.labelVCPUs);
            this.Controls.Add(this.labelRam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Label labelVCPUs;
        private System.Windows.Forms.Label labelInstances;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelNetworks;
        private System.Windows.Forms.Label labelVolumes;
        private System.Windows.Forms.Label labelStorage;
        private System.Windows.Forms.Label labelSnapshots;
        private System.Windows.Forms.Label labelRouters;
        private System.Windows.Forms.Label labelFloating;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonCreateInstance;
        private System.Windows.Forms.Button buttonEditInstance;
        private System.Windows.Forms.Button buttonDeleteInstance;
        private System.Windows.Forms.Label labelErrorsInstance;
        private System.Windows.Forms.Button buttonRefreshInstances;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonCreateVolume;
        private System.Windows.Forms.Button buttonEditVolume;
        private System.Windows.Forms.Button buttonDeleteVolume;
        private System.Windows.Forms.Label labelOptionsVolumes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Label labelOptionsImages;
        private System.Windows.Forms.Button buttonDeleteImage;
        private System.Windows.Forms.Button buttonOpenConsole;
        private System.Windows.Forms.Label label1Instances;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonCreateNetwork;
        private System.Windows.Forms.Button buttonEditNetwork;
        private System.Windows.Forms.Button buttonDeleteNetwork;
        private System.Windows.Forms.Label labelOptionsNetworks;
    }
}