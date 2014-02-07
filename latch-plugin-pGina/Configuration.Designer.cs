namespace latch_plugin_pGina
{
    partial class Configuration
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheckLatchConf = new System.Windows.Forms.Button();
            this.lblSecret = new System.Windows.Forms.Label();
            this.tbSecret = new System.Windows.Forms.TextBox();
            this.tbApplicationID = new System.Windows.Forms.TextBox();
            this.lblApplicationId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPair = new System.Windows.Forms.Button();
            this.tbToken = new System.Windows.Forms.TextBox();
            this.lblPairId = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbTwoFactor = new System.Windows.Forms.CheckBox();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.tbAccountID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCheckLatchConf);
            this.groupBox1.Controls.Add(this.lblSecret);
            this.groupBox1.Controls.Add(this.tbSecret);
            this.groupBox1.Controls.Add(this.tbApplicationID);
            this.groupBox1.Controls.Add(this.lblApplicationId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Latch Configuration";
            // 
            // btnCheckLatchConf
            // 
            this.btnCheckLatchConf.Location = new System.Drawing.Point(346, 71);
            this.btnCheckLatchConf.Name = "btnCheckLatchConf";
            this.btnCheckLatchConf.Size = new System.Drawing.Size(75, 23);
            this.btnCheckLatchConf.TabIndex = 4;
            this.btnCheckLatchConf.Text = "Check";
            this.btnCheckLatchConf.UseVisualStyleBackColor = true;
            this.btnCheckLatchConf.Click += new System.EventHandler(this.btnCheckLatchConf_Click);
            // 
            // lblSecret
            // 
            this.lblSecret.AutoSize = true;
            this.lblSecret.Location = new System.Drawing.Point(41, 48);
            this.lblSecret.Name = "lblSecret";
            this.lblSecret.Size = new System.Drawing.Size(41, 13);
            this.lblSecret.TabIndex = 3;
            this.lblSecret.Text = "Secret:";
            // 
            // tbSecret
            // 
            this.tbSecret.Location = new System.Drawing.Point(88, 45);
            this.tbSecret.Name = "tbSecret";
            this.tbSecret.Size = new System.Drawing.Size(333, 20);
            this.tbSecret.TabIndex = 2;
            // 
            // tbApplicationID
            // 
            this.tbApplicationID.Location = new System.Drawing.Point(88, 19);
            this.tbApplicationID.Name = "tbApplicationID";
            this.tbApplicationID.Size = new System.Drawing.Size(333, 20);
            this.tbApplicationID.TabIndex = 1;
            // 
            // lblApplicationId
            // 
            this.lblApplicationId.AutoSize = true;
            this.lblApplicationId.Location = new System.Drawing.Point(6, 22);
            this.lblApplicationId.Name = "lblApplicationId";
            this.lblApplicationId.Size = new System.Drawing.Size(76, 13);
            this.lblApplicationId.TabIndex = 0;
            this.lblApplicationId.Text = "Application ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPair);
            this.groupBox2.Controls.Add(this.tbToken);
            this.groupBox2.Controls.Add(this.lblPairId);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Latch Pair";
            // 
            // btnPair
            // 
            this.btnPair.Location = new System.Drawing.Point(346, 48);
            this.btnPair.Name = "btnPair";
            this.btnPair.Size = new System.Drawing.Size(75, 23);
            this.btnPair.TabIndex = 2;
            this.btnPair.Text = "Pair";
            this.btnPair.UseVisualStyleBackColor = true;
            this.btnPair.Click += new System.EventHandler(this.btnPair_Click);
            // 
            // tbToken
            // 
            this.tbToken.Location = new System.Drawing.Point(88, 22);
            this.tbToken.Name = "tbToken";
            this.tbToken.Size = new System.Drawing.Size(333, 20);
            this.tbToken.TabIndex = 1;
            // 
            // lblPairId
            // 
            this.lblPairId.AutoSize = true;
            this.lblPairId.Location = new System.Drawing.Point(41, 25);
            this.lblPairId.Name = "lblPairId";
            this.lblPairId.Size = new System.Drawing.Size(41, 13);
            this.lblPairId.TabIndex = 0;
            this.lblPairId.Text = "Token:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbTwoFactor);
            this.groupBox3.Controls.Add(this.btnCheckStatus);
            this.groupBox3.Controls.Add(this.tbAccountID);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Configuration";
            // 
            // cbTwoFactor
            // 
            this.cbTwoFactor.AutoSize = true;
            this.cbTwoFactor.Enabled = false;
            this.cbTwoFactor.Location = new System.Drawing.Point(21, 49);
            this.cbTwoFactor.Name = "cbTwoFactor";
            this.cbTwoFactor.Size = new System.Drawing.Size(179, 17);
            this.cbTwoFactor.TabIndex = 3;
            this.cbTwoFactor.Text = "Enable two-factor authentication";
            this.cbTwoFactor.UseVisualStyleBackColor = true;
            this.cbTwoFactor.Click += new System.EventHandler(this.cbTwoFactor_Click);
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.Location = new System.Drawing.Point(316, 45);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(105, 23);
            this.btnCheckStatus.TabIndex = 2;
            this.btnCheckStatus.Text = "Check status";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // tbAccountID
            // 
            this.tbAccountID.Location = new System.Drawing.Point(88, 19);
            this.tbAccountID.Name = "tbAccountID";
            this.tbAccountID.Size = new System.Drawing.Size(338, 20);
            this.tbAccountID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account ID:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(328, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 26);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save and Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 325);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(0, 13);
            this.lblLog.TabIndex = 4;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 354);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuration";
            this.ShowIcon = false;
            this.Text = "Configuration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheckLatchConf;
        private System.Windows.Forms.Label lblSecret;
        private System.Windows.Forms.TextBox tbSecret;
        private System.Windows.Forms.TextBox tbApplicationID;
        private System.Windows.Forms.Label lblApplicationId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPair;
        private System.Windows.Forms.TextBox tbToken;
        private System.Windows.Forms.Label lblPairId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbAccountID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbTwoFactor;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLog;
    }
}