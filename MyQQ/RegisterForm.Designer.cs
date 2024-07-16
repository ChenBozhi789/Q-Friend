namespace MyQQ
{
    partial class RegisterForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            picLogo = new PictureBox();
            lblNickName = new Label();
            lblAge = new Label();
            lblSex = new Label();
            lblPwd = new Label();
            lblRePwd = new Label();
            lblRealName = new Label();
            lblStar = new Label();
            lblBloodType = new Label();
            grpBaselnfo = new GroupBox();
            rbtnFemale = new RadioButton();
            txtRePwd = new TextBox();
            rbtnMale = new RadioButton();
            txtPwd = new TextBox();
            txtAge = new TextBox();
            txtNickName = new TextBox();
            grpDetails = new GroupBox();
            txtRealName = new TextBox();
            cbocBloodType = new ComboBox();
            cboxStar = new ComboBox();
            bindingSource1 = new BindingSource(components);
            btnRegister = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grpBaselnfo.SuspendLayout();
            grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(12, 16);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(125, 332);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblNickName
            // 
            lblNickName.AutoSize = true;
            lblNickName.Location = new Point(6, 23);
            lblNickName.Name = "lblNickName";
            lblNickName.Size = new Size(88, 20);
            lblNickName.TabIndex = 1;
            lblNickName.Text = "Nick Name";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(6, 59);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(39, 20);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Location = new Point(6, 96);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(35, 20);
            lblSex.TabIndex = 3;
            lblSex.Text = "Sex";
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.Location = new Point(6, 133);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(40, 20);
            lblPwd.TabIndex = 4;
            lblPwd.Text = "Pwd";
            // 
            // lblRePwd
            // 
            lblRePwd.AutoSize = true;
            lblRePwd.Location = new Point(6, 164);
            lblRePwd.Name = "lblRePwd";
            lblRePwd.Size = new Size(65, 20);
            lblRePwd.TabIndex = 5;
            lblRePwd.Text = "Re-Pwd";
            // 
            // lblRealName
            // 
            lblRealName.AutoSize = true;
            lblRealName.Location = new Point(6, 26);
            lblRealName.Name = "lblRealName";
            lblRealName.Size = new Size(87, 20);
            lblRealName.TabIndex = 6;
            lblRealName.Text = "Real Name";
            // 
            // lblStar
            // 
            lblStar.AutoSize = true;
            lblStar.Location = new Point(6, 59);
            lblStar.Name = "lblStar";
            lblStar.Size = new Size(38, 20);
            lblStar.TabIndex = 7;
            lblStar.Text = "Star";
            // 
            // lblBloodType
            // 
            lblBloodType.AutoSize = true;
            lblBloodType.Location = new Point(6, 95);
            lblBloodType.Name = "lblBloodType";
            lblBloodType.Size = new Size(92, 20);
            lblBloodType.TabIndex = 8;
            lblBloodType.Text = "Blood Type";
            // 
            // grpBaselnfo
            // 
            grpBaselnfo.Controls.Add(rbtnFemale);
            grpBaselnfo.Controls.Add(txtRePwd);
            grpBaselnfo.Controls.Add(rbtnMale);
            grpBaselnfo.Controls.Add(txtPwd);
            grpBaselnfo.Controls.Add(txtAge);
            grpBaselnfo.Controls.Add(txtNickName);
            grpBaselnfo.Controls.Add(lblNickName);
            grpBaselnfo.Controls.Add(lblAge);
            grpBaselnfo.Controls.Add(lblSex);
            grpBaselnfo.Controls.Add(lblPwd);
            grpBaselnfo.Controls.Add(lblRePwd);
            grpBaselnfo.Location = new Point(152, 16);
            grpBaselnfo.Name = "grpBaselnfo";
            grpBaselnfo.Size = new Size(294, 197);
            grpBaselnfo.TabIndex = 9;
            grpBaselnfo.TabStop = false;
            grpBaselnfo.Text = "Base Info";
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Location = new Point(178, 96);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(38, 24);
            rbtnFemale.TabIndex = 14;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "F";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // txtRePwd
            // 
            txtRePwd.Location = new Point(100, 163);
            txtRePwd.Name = "txtRePwd";
            txtRePwd.Size = new Size(160, 27);
            txtRePwd.TabIndex = 10;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Location = new Point(100, 96);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(45, 24);
            rbtnMale.TabIndex = 13;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "M";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(100, 130);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(160, 27);
            txtPwd.TabIndex = 8;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(100, 56);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(160, 27);
            txtAge.TabIndex = 7;
            // 
            // txtNickName
            // 
            txtNickName.Location = new Point(100, 23);
            txtNickName.Name = "txtNickName";
            txtNickName.Size = new Size(160, 27);
            txtNickName.TabIndex = 6;
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(txtRealName);
            grpDetails.Controls.Add(cbocBloodType);
            grpDetails.Controls.Add(cboxStar);
            grpDetails.Controls.Add(lblRealName);
            grpDetails.Controls.Add(lblStar);
            grpDetails.Controls.Add(lblBloodType);
            grpDetails.Location = new Point(152, 214);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(294, 134);
            grpDetails.TabIndex = 10;
            grpDetails.TabStop = false;
            grpDetails.Text = "Elective Info";
            // 
            // txtRealName
            // 
            txtRealName.Location = new Point(100, 23);
            txtRealName.Name = "txtRealName";
            txtRealName.Size = new Size(160, 27);
            txtRealName.TabIndex = 11;
            // 
            // cbocBloodType
            // 
            cbocBloodType.FormattingEnabled = true;
            cbocBloodType.Items.AddRange(new object[] { "A", "B", "AB", "O" });
            cbocBloodType.Location = new Point(100, 95);
            cbocBloodType.Name = "cbocBloodType";
            cbocBloodType.Size = new Size(160, 28);
            cbocBloodType.TabIndex = 10;
            // 
            // cboxStar
            // 
            cboxStar.FormattingEnabled = true;
            cboxStar.Items.AddRange(new object[] { "Aries  ", "Taurus  ", "Gemini  ", "Cancer  ", "Leo  ", "Virgo  ", "Libra  ", "Scorpio  ", "Sagittarius  ", "Capricorn  ", "Aquarius  ", "Pisces" });
            cboxStar.Location = new Point(100, 56);
            cboxStar.Name = "cboxStar";
            cboxStar.Size = new Size(160, 28);
            cboxStar.TabIndex = 9;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(159, 354);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(310, 354);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 395);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(grpDetails);
            Controls.Add(grpBaselnfo);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Form";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            grpBaselnfo.ResumeLayout(false);
            grpBaselnfo.PerformLayout();
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picLogo;
        private Label lblNickName;
        private Label lblAge;
        private Label lblSex;
        private Label lblPwd;
        private Label lblRePwd;
        private Label lblRealName;
        private Label lblStar;
        private Label lblBloodType;
        private GroupBox grpBaselnfo;
        private GroupBox grpDetails;
        private BindingSource bindingSource1;
        private Button btnRegister;
        private Button btnCancel;
        private TextBox txtRePwd;
        private TextBox txtPwd;
        private TextBox txtAge;
        private TextBox txtNickName;
        private TextBox txtRealName;
        private ComboBox cbocBloodType;
        private ComboBox cboxStar;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
    }
}