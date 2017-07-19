namespace CDN_Pruge_ClientApp
{
    partial class PrugeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrugeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.txtSubscriptions = new System.Windows.Forms.TextBox();
            this.txtResourceGroup = new System.Windows.Forms.TextBox();
            this.txtCdnProfile = new System.Windows.Forms.TextBox();
            this.txtCdnEndpoint = new System.Windows.Forms.TextBox();
            this.txtActiveDirectory = new System.Windows.Forms.TextBox();
            this.txtPurgeList = new System.Windows.Forms.TextBox();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnPurge = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ClientId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "ClientSecret:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subscriptions:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "ResourceGroup:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "CdnProfile:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "CdnEndpoint:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "ActiveDirectory:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "PurgeList:";
            // 
            // txtClientId
            // 
            this.txtClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientId.Location = new System.Drawing.Point(201, 35);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(312, 23);
            this.txtClientId.TabIndex = 1;
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(201, 89);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(312, 20);
            this.txtClientSecret.TabIndex = 2;
            // 
            // txtSubscriptions
            // 
            this.txtSubscriptions.Location = new System.Drawing.Point(201, 140);
            this.txtSubscriptions.Name = "txtSubscriptions";
            this.txtSubscriptions.Size = new System.Drawing.Size(312, 20);
            this.txtSubscriptions.TabIndex = 6;
            // 
            // txtResourceGroup
            // 
            this.txtResourceGroup.Location = new System.Drawing.Point(201, 191);
            this.txtResourceGroup.Name = "txtResourceGroup";
            this.txtResourceGroup.Size = new System.Drawing.Size(312, 20);
            this.txtResourceGroup.TabIndex = 7;
            // 
            // txtCdnProfile
            // 
            this.txtCdnProfile.Location = new System.Drawing.Point(201, 242);
            this.txtCdnProfile.Name = "txtCdnProfile";
            this.txtCdnProfile.Size = new System.Drawing.Size(312, 20);
            this.txtCdnProfile.TabIndex = 8;
            // 
            // txtCdnEndpoint
            // 
            this.txtCdnEndpoint.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtCdnEndpoint.Location = new System.Drawing.Point(201, 293);
            this.txtCdnEndpoint.Name = "txtCdnEndpoint";
            this.txtCdnEndpoint.Size = new System.Drawing.Size(312, 20);
            this.txtCdnEndpoint.TabIndex = 9;
            // 
            // txtActiveDirectory
            // 
            this.txtActiveDirectory.Location = new System.Drawing.Point(201, 344);
            this.txtActiveDirectory.Name = "txtActiveDirectory";
            this.txtActiveDirectory.Size = new System.Drawing.Size(312, 20);
            this.txtActiveDirectory.TabIndex = 10;
            // 
            // txtPurgeList
            // 
            this.txtPurgeList.Location = new System.Drawing.Point(201, 400);
            this.txtPurgeList.Multiline = true;
            this.txtPurgeList.Name = "txtPurgeList";
            this.txtPurgeList.Size = new System.Drawing.Size(312, 100);
            this.txtPurgeList.TabIndex = 11;
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFromFile.Location = new System.Drawing.Point(393, 524);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(120, 30);
            this.btnLoadFromFile.TabIndex = 12;
            this.btnLoadFromFile.Text = "LoadFromFile";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // btnPurge
            // 
            this.btnPurge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurge.Location = new System.Drawing.Point(47, 524);
            this.btnPurge.Name = "btnPurge";
            this.btnPurge.Size = new System.Drawing.Size(80, 30);
            this.btnPurge.TabIndex = 12;
            this.btnPurge.Text = "Purge";
            this.btnPurge.UseVisualStyleBackColor = true;
            this.btnPurge.Click += new System.EventHandler(this.btnPurge_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToFile.Location = new System.Drawing.Point(200, 524);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(120, 30);
            this.btnSaveToFile.TabIndex = 12;
            this.btnSaveToFile.Text = "SaveToFile";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // PrugeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 590);
            this.Controls.Add(this.btnPurge);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.txtPurgeList);
            this.Controls.Add(this.txtActiveDirectory);
            this.Controls.Add(this.txtCdnEndpoint);
            this.Controls.Add(this.txtCdnProfile);
            this.Controls.Add(this.txtResourceGroup);
            this.Controls.Add(this.txtSubscriptions);
            this.Controls.Add(this.txtClientSecret);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrugeForm";
            this.Text = "Azure CDN Purge Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.TextBox txtSubscriptions;
        private System.Windows.Forms.TextBox txtResourceGroup;
        private System.Windows.Forms.TextBox txtCdnProfile;
        private System.Windows.Forms.TextBox txtCdnEndpoint;
        private System.Windows.Forms.TextBox txtActiveDirectory;
        private System.Windows.Forms.TextBox txtPurgeList;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnPurge;
        private System.Windows.Forms.Button btnSaveToFile;
    }
}

