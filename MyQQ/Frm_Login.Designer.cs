namespace MyQQ
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            linkLblRag = new LinkLabel();
            pBoxClose = new PictureBox();
            cboxRemember = new CheckBox();
            cBoxAutoLogin = new CheckBox();
            txtID = new TextBox();
            txtPwd = new TextBox();
            pBoxMin = new PictureBox();
            pBoxLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // linkLblRag
            // 
            linkLblRag.AutoSize = true;
            linkLblRag.Location = new Point(334, 214);
            linkLblRag.Name = "linkLblRag";
            linkLblRag.Size = new Size(70, 20);
            linkLblRag.TabIndex = 0;
            linkLblRag.TabStop = true;
            linkLblRag.Text = "Register";
            linkLblRag.LinkClicked += linkLblRag_LinkClicked;
            // 
            // pBoxClose
            // 
            pBoxClose.BackColor = Color.Transparent;
            pBoxClose.Location = new Point(402, 1);
            pBoxClose.Name = "pBoxClose";
            pBoxClose.Size = new Size(27, 26);
            pBoxClose.TabIndex = 1;
            pBoxClose.TabStop = false;
            pBoxClose.Click += pBoxClose_Click;
            // 
            // cboxRemember
            // 
            cboxRemember.AutoSize = true;
            cboxRemember.Location = new Point(131, 257);
            cboxRemember.Name = "cboxRemember";
            cboxRemember.Size = new Size(112, 24);
            cboxRemember.TabIndex = 2;
            cboxRemember.Text = "Remember";
            cboxRemember.UseVisualStyleBackColor = true;
            cboxRemember.CheckedChanged += cboxRemember_CheckedChanged;
            // 
            // cBoxAutoLogin
            // 
            cBoxAutoLogin.AutoSize = true;
            cBoxAutoLogin.Location = new Point(248, 257);
            cBoxAutoLogin.Name = "cBoxAutoLogin";
            cBoxAutoLogin.Size = new Size(107, 24);
            cBoxAutoLogin.TabIndex = 3;
            cBoxAutoLogin.Text = "Automatic";
            cBoxAutoLogin.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(131, 196);
            txtID.Name = "txtID";
            txtID.Size = new Size(197, 27);
            txtID.TabIndex = 4;
            txtID.TextChanged += txtID_TextChanged;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(131, 224);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(197, 27);
            txtPwd.TabIndex = 5;
            txtPwd.KeyPress += txtPwd_KeyPress;
            // 
            // pBoxMin
            // 
            pBoxMin.BackColor = Color.Transparent;
            pBoxMin.Location = new Point(377, 1);
            pBoxMin.Name = "pBoxMin";
            pBoxMin.Size = new Size(27, 26);
            pBoxMin.TabIndex = 6;
            pBoxMin.TabStop = false;
            pBoxMin.Click += pBoxMin_Click;
            // 
            // pBoxLogin
            // 
            pBoxLogin.Location = new Point(131, 287);
            pBoxLogin.Name = "pBoxLogin";
            pBoxLogin.Size = new Size(197, 31);
            pBoxLogin.TabIndex = 7;
            pBoxLogin.TabStop = false;
            pBoxLogin.Click += pBoxLogin_Click;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(432, 331);
            Controls.Add(pBoxLogin);
            Controls.Add(pBoxMin);
            Controls.Add(txtPwd);
            Controls.Add(txtID);
            Controls.Add(cBoxAutoLogin);
            Controls.Add(cboxRemember);
            Controls.Add(pBoxClose);
            Controls.Add(linkLblRag);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QQ Login";
            ((System.ComponentModel.ISupportInitialize)pBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLblRag;
        private PictureBox pBoxClose;
        private CheckBox cboxRemember;
        private CheckBox cBoxAutoLogin;
        private TextBox txtID;
        private TextBox txtPwd;
        private PictureBox pBoxMin;
        private PictureBox pBoxLogin;
    }
}
