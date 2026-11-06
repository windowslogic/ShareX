namespace ShareX
{
    partial class AboutForm
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

            if (easterEgg != null) easterEgg.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblProductName = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBuild = new System.Windows.Forms.Label();
            this.lnkUpdate = new System.Windows.Forms.LinkLabel();
            this.cLogo = new ShareX.HelpersLib.Canvas();
            this.rtbInfo = new ShareX.HelpersLib.ReadOnlyRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            resources.ApplyResources(this.lblProductName, "lblProductName");
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Name = "lblProductName";
            // 
            // pbLogo
            // 
            resources.ApplyResources(this.pbLogo, "pbLogo");
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.TabStop = false;
            this.pbLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLogo_MouseDown);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBuild
            // 
            resources.ApplyResources(this.lblBuild, "lblBuild");
            this.lblBuild.Name = "lblBuild";
            // 
            // lnkUpdate
            // 
            resources.ApplyResources(this.lnkUpdate, "lnkUpdate");
            this.lnkUpdate.Name = "lnkUpdate";
            this.lnkUpdate.TabStop = true;
            this.lnkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdate_LinkClicked);
            // 
            // cLogo
            // 
            resources.ApplyResources(this.cLogo, "cLogo");
            this.cLogo.Interval = 100;
            this.cLogo.Name = "cLogo";
            // 
            // rtbInfo
            // 
            resources.ApplyResources(this.rtbInfo, "rtbInfo");
            this.rtbInfo.BackColor = System.Drawing.SystemColors.Window;
            this.rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtb_LinkClicked);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.btnClose;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.lnkUpdate);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.cLogo);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblBuild);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtbInfo);
            this.Name = "AboutForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Shown += new System.EventHandler(this.AboutForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion Windows Form Designer generated code

        private System.Windows.Forms.Label lblProductName;
        private HelpersLib.Canvas cLogo;
        private HelpersLib.ReadOnlyRichTextBox rtbInfo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBuild;
        private System.Windows.Forms.LinkLabel lnkUpdate;
    }
}