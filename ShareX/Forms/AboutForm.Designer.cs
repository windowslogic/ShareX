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
            lblProductName = new System.Windows.Forms.Label();
            pbLogo = new System.Windows.Forms.PictureBox();
            btnClose = new System.Windows.Forms.Button();
            lblBuild = new System.Windows.Forms.Label();
            lnkUpdate = new System.Windows.Forms.LinkLabel();
            cLogo = new ShareX.HelpersLib.Canvas();
            rtbInfo = new ShareX.HelpersLib.ReadOnlyRichTextBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblProductName
            // 
            resources.ApplyResources(lblProductName, "lblProductName");
            lblProductName.BackColor = System.Drawing.Color.Transparent;
            lblProductName.Name = "lblProductName";
            // 
            // pbLogo
            // 
            resources.ApplyResources(pbLogo, "pbLogo");
            pbLogo.BackColor = System.Drawing.Color.Transparent;
            pbLogo.Name = "pbLogo";
            pbLogo.TabStop = false;
            pbLogo.MouseDown += pbLogo_MouseDown;
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.Name = "btnClose";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblBuild
            // 
            resources.ApplyResources(lblBuild, "lblBuild");
            lblBuild.Name = "lblBuild";
            // 
            // lnkUpdate
            // 
            resources.ApplyResources(lnkUpdate, "lnkUpdate");
            lnkUpdate.Name = "lnkUpdate";
            lnkUpdate.TabStop = true;
            lnkUpdate.LinkClicked += lnkUpdate_LinkClicked;
            // 
            // cLogo
            // 
            resources.ApplyResources(cLogo, "cLogo");
            cLogo.Interval = 100;
            cLogo.Name = "cLogo";
            // 
            // rtbInfo
            // 
            resources.ApplyResources(rtbInfo, "rtbInfo");
            rtbInfo.BackColor = System.Drawing.SystemColors.Window;
            rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            rtbInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            rtbInfo.Name = "rtbInfo";
            rtbInfo.ReadOnly = true;
            rtbInfo.LinkClicked += rtb_LinkClicked;
            // 
            // AboutForm
            // 
            AcceptButton = btnClose;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.Window;
            CancelButton = btnClose;
            Controls.Add(lnkUpdate);
            Controls.Add(pbLogo);
            Controls.Add(cLogo);
            Controls.Add(lblProductName);
            Controls.Add(lblBuild);
            Controls.Add(btnClose);
            Controls.Add(rtbInfo);
            MaximizeBox = false;
            Name = "AboutForm";
            ShowInTaskbar = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Shown += AboutForm_Shown;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();

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