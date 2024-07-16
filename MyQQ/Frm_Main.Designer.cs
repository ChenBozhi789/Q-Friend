namespace MyQQ
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            ListViewGroup listViewGroup1 = new ListViewGroup("My Friend", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("Strengers", HorizontalAlignment.Left);
            imalistHead = new ImageList(components);
            imglistSmallHead = new ImageList(components);
            imglistMessage = new ImageList(components);
            tmMessage = new System.Windows.Forms.Timer(components);
            tmAddFriend = new System.Windows.Forms.Timer(components);
            tmChat = new System.Windows.Forms.Timer(components);
            pboxHead = new PictureBox();
            pboxMin = new PictureBox();
            pboxClose = new PictureBox();
            lblName = new Label();
            txtSign = new TextBox();
            lvFriend = new ListView();
            tsOperation = new ToolStrip();
            contextMenuStrip = new ContextMenuStrip(components);
            tsMenuView = new ToolStripMenuItem();
            tsMenuAdd = new ToolStripMenuItem();
            tsMenuDel = new ToolStripMenuItem();
            tsbtninfo = new ToolStripButton();
            tsbtnSearchFriend = new ToolStripButton();
            tsbtnUpdateFriendList = new ToolStripButton();
            tsbtnMessageReading = new ToolStripButton();
            tsbtnExit = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)pboxHead).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxClose).BeginInit();
            tsOperation.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // imalistHead
            // 
            imalistHead.ColorDepth = ColorDepth.Depth32Bit;
            imalistHead.ImageStream = (ImageListStreamer)resources.GetObject("imalistHead.ImageStream");
            imalistHead.TransparentColor = Color.Transparent;
            imalistHead.Images.SetKeyName(0, "1.bmp");
            imalistHead.Images.SetKeyName(1, "2.bmp");
            imalistHead.Images.SetKeyName(2, "3.bmp");
            imalistHead.Images.SetKeyName(3, "4.bmp");
            imalistHead.Images.SetKeyName(4, "5.bmp");
            imalistHead.Images.SetKeyName(5, "6.bmp");
            imalistHead.Images.SetKeyName(6, "7.bmp");
            imalistHead.Images.SetKeyName(7, "8.bmp");
            imalistHead.Images.SetKeyName(8, "9.bmp");
            imalistHead.Images.SetKeyName(9, "10.bmp");
            imalistHead.Images.SetKeyName(10, "11.bmp");
            imalistHead.Images.SetKeyName(11, "12.bmp");
            imalistHead.Images.SetKeyName(12, "13.bmp");
            imalistHead.Images.SetKeyName(13, "14.bmp");
            imalistHead.Images.SetKeyName(14, "15.bmp");
            imalistHead.Images.SetKeyName(15, "16.bmp");
            imalistHead.Images.SetKeyName(16, "17.bmp");
            imalistHead.Images.SetKeyName(17, "18.bmp");
            imalistHead.Images.SetKeyName(18, "19.bmp");
            imalistHead.Images.SetKeyName(19, "20.bmp");
            imalistHead.Images.SetKeyName(20, "21.bmp");
            imalistHead.Images.SetKeyName(21, "22.bmp");
            imalistHead.Images.SetKeyName(22, "23.bmp");
            imalistHead.Images.SetKeyName(23, "24.bmp");
            imalistHead.Images.SetKeyName(24, "25.bmp");
            imalistHead.Images.SetKeyName(25, "26.bmp");
            imalistHead.Images.SetKeyName(26, "27.bmp");
            imalistHead.Images.SetKeyName(27, "28.bmp");
            imalistHead.Images.SetKeyName(28, "29.bmp");
            imalistHead.Images.SetKeyName(29, "30.bmp");
            imalistHead.Images.SetKeyName(30, "31.bmp");
            imalistHead.Images.SetKeyName(31, "32.bmp");
            imalistHead.Images.SetKeyName(32, "33.bmp");
            imalistHead.Images.SetKeyName(33, "34.bmp");
            imalistHead.Images.SetKeyName(34, "35.bmp");
            imalistHead.Images.SetKeyName(35, "36.bmp");
            imalistHead.Images.SetKeyName(36, "37.bmp");
            imalistHead.Images.SetKeyName(37, "38.bmp");
            imalistHead.Images.SetKeyName(38, "39.bmp");
            imalistHead.Images.SetKeyName(39, "40.bmp");
            imalistHead.Images.SetKeyName(40, "41.bmp");
            imalistHead.Images.SetKeyName(41, "42.bmp");
            imalistHead.Images.SetKeyName(42, "43.bmp");
            imalistHead.Images.SetKeyName(43, "44.bmp");
            imalistHead.Images.SetKeyName(44, "45.bmp");
            imalistHead.Images.SetKeyName(45, "46.bmp");
            imalistHead.Images.SetKeyName(46, "47.bmp");
            imalistHead.Images.SetKeyName(47, "48.bmp");
            imalistHead.Images.SetKeyName(48, "49.bmp");
            imalistHead.Images.SetKeyName(49, "50.bmp");
            imalistHead.Images.SetKeyName(50, "51.bmp");
            imalistHead.Images.SetKeyName(51, "52.bmp");
            imalistHead.Images.SetKeyName(52, "53.bmp");
            imalistHead.Images.SetKeyName(53, "54.bmp");
            imalistHead.Images.SetKeyName(54, "55.bmp");
            imalistHead.Images.SetKeyName(55, "56.bmp");
            imalistHead.Images.SetKeyName(56, "57.bmp");
            imalistHead.Images.SetKeyName(57, "58.bmp");
            imalistHead.Images.SetKeyName(58, "59.bmp");
            imalistHead.Images.SetKeyName(59, "60.bmp");
            imalistHead.Images.SetKeyName(60, "61.bmp");
            imalistHead.Images.SetKeyName(61, "62.bmp");
            imalistHead.Images.SetKeyName(62, "63.bmp");
            imalistHead.Images.SetKeyName(63, "64.bmp");
            imalistHead.Images.SetKeyName(64, "65.bmp");
            imalistHead.Images.SetKeyName(65, "66.bmp");
            imalistHead.Images.SetKeyName(66, "67.bmp");
            imalistHead.Images.SetKeyName(67, "68.bmp");
            imalistHead.Images.SetKeyName(68, "69.bmp");
            imalistHead.Images.SetKeyName(69, "70.bmp");
            imalistHead.Images.SetKeyName(70, "71.bmp");
            imalistHead.Images.SetKeyName(71, "72.bmp");
            imalistHead.Images.SetKeyName(72, "73.bmp");
            imalistHead.Images.SetKeyName(73, "74.bmp");
            imalistHead.Images.SetKeyName(74, "75.bmp");
            imalistHead.Images.SetKeyName(75, "76.bmp");
            imalistHead.Images.SetKeyName(76, "77.bmp");
            imalistHead.Images.SetKeyName(77, "78.bmp");
            imalistHead.Images.SetKeyName(78, "79.bmp");
            imalistHead.Images.SetKeyName(79, "80.bmp");
            imalistHead.Images.SetKeyName(80, "81.bmp");
            imalistHead.Images.SetKeyName(81, "82.bmp");
            imalistHead.Images.SetKeyName(82, "83.bmp");
            imalistHead.Images.SetKeyName(83, "84.bmp");
            imalistHead.Images.SetKeyName(84, "85.bmp");
            imalistHead.Images.SetKeyName(85, "86.bmp");
            imalistHead.Images.SetKeyName(86, "87.bmp");
            imalistHead.Images.SetKeyName(87, "88.bmp");
            imalistHead.Images.SetKeyName(88, "89.bmp");
            imalistHead.Images.SetKeyName(89, "90.bmp");
            imalistHead.Images.SetKeyName(90, "91.bmp");
            imalistHead.Images.SetKeyName(91, "92.bmp");
            imalistHead.Images.SetKeyName(92, "93.bmp");
            imalistHead.Images.SetKeyName(93, "94.bmp");
            imalistHead.Images.SetKeyName(94, "95.bmp");
            imalistHead.Images.SetKeyName(95, "96.bmp");
            imalistHead.Images.SetKeyName(96, "97.bmp");
            imalistHead.Images.SetKeyName(97, "98.bmp");
            imalistHead.Images.SetKeyName(98, "99.bmp");
            imalistHead.Images.SetKeyName(99, "100.bmp");
            // 
            // imglistSmallHead
            // 
            imglistSmallHead.ColorDepth = ColorDepth.Depth16Bit;
            imglistSmallHead.ImageStream = (ImageListStreamer)resources.GetObject("imglistSmallHead.ImageStream");
            imglistSmallHead.TransparentColor = Color.Transparent;
            imglistSmallHead.Images.SetKeyName(0, "1-1.bmp");
            imglistSmallHead.Images.SetKeyName(1, "2-1.bmp");
            imglistSmallHead.Images.SetKeyName(2, "3-1.bmp");
            imglistSmallHead.Images.SetKeyName(3, "4-1.bmp");
            imglistSmallHead.Images.SetKeyName(4, "5-1.bmp");
            imglistSmallHead.Images.SetKeyName(5, "6-1.bmp");
            imglistSmallHead.Images.SetKeyName(6, "7-1.bmp");
            imglistSmallHead.Images.SetKeyName(7, "8-1.bmp");
            imglistSmallHead.Images.SetKeyName(8, "9-1.bmp");
            imglistSmallHead.Images.SetKeyName(9, "10-1.bmp");
            imglistSmallHead.Images.SetKeyName(10, "11-1.bmp");
            imglistSmallHead.Images.SetKeyName(11, "12-1.bmp");
            imglistSmallHead.Images.SetKeyName(12, "13-1.bmp");
            imglistSmallHead.Images.SetKeyName(13, "14-1.bmp");
            imglistSmallHead.Images.SetKeyName(14, "15-1.bmp");
            imglistSmallHead.Images.SetKeyName(15, "16-1.bmp");
            imglistSmallHead.Images.SetKeyName(16, "17-1.bmp");
            imglistSmallHead.Images.SetKeyName(17, "18-1.bmp");
            imglistSmallHead.Images.SetKeyName(18, "19-1.bmp");
            imglistSmallHead.Images.SetKeyName(19, "20-1.bmp");
            imglistSmallHead.Images.SetKeyName(20, "21-1.bmp");
            imglistSmallHead.Images.SetKeyName(21, "22-1.bmp");
            imglistSmallHead.Images.SetKeyName(22, "23-1.bmp");
            imglistSmallHead.Images.SetKeyName(23, "24-1.bmp");
            imglistSmallHead.Images.SetKeyName(24, "25-1.bmp");
            imglistSmallHead.Images.SetKeyName(25, "26-1.bmp");
            imglistSmallHead.Images.SetKeyName(26, "27-1.bmp");
            imglistSmallHead.Images.SetKeyName(27, "28-1.bmp");
            imglistSmallHead.Images.SetKeyName(28, "29-1.bmp");
            imglistSmallHead.Images.SetKeyName(29, "30-1.bmp");
            imglistSmallHead.Images.SetKeyName(30, "31-1.bmp");
            imglistSmallHead.Images.SetKeyName(31, "32-1.bmp");
            imglistSmallHead.Images.SetKeyName(32, "33-1.bmp");
            imglistSmallHead.Images.SetKeyName(33, "34-1.bmp");
            imglistSmallHead.Images.SetKeyName(34, "35-1.bmp");
            imglistSmallHead.Images.SetKeyName(35, "36-1.bmp");
            imglistSmallHead.Images.SetKeyName(36, "37-1.bmp");
            imglistSmallHead.Images.SetKeyName(37, "38-1.bmp");
            imglistSmallHead.Images.SetKeyName(38, "39-1.bmp");
            imglistSmallHead.Images.SetKeyName(39, "40-1.bmp");
            imglistSmallHead.Images.SetKeyName(40, "41-1.bmp");
            imglistSmallHead.Images.SetKeyName(41, "42-1.bmp");
            imglistSmallHead.Images.SetKeyName(42, "43-1.bmp");
            imglistSmallHead.Images.SetKeyName(43, "44-1.bmp");
            imglistSmallHead.Images.SetKeyName(44, "45-1.bmp");
            imglistSmallHead.Images.SetKeyName(45, "46-1.bmp");
            imglistSmallHead.Images.SetKeyName(46, "47-1.bmp");
            imglistSmallHead.Images.SetKeyName(47, "48-1.bmp");
            imglistSmallHead.Images.SetKeyName(48, "49-1.bmp");
            imglistSmallHead.Images.SetKeyName(49, "50-1.bmp");
            imglistSmallHead.Images.SetKeyName(50, "51-1.bmp");
            imglistSmallHead.Images.SetKeyName(51, "52-1.bmp");
            imglistSmallHead.Images.SetKeyName(52, "53-1.bmp");
            imglistSmallHead.Images.SetKeyName(53, "54-1.bmp");
            imglistSmallHead.Images.SetKeyName(54, "55-1.bmp");
            imglistSmallHead.Images.SetKeyName(55, "56-1.bmp");
            imglistSmallHead.Images.SetKeyName(56, "57-1.bmp");
            imglistSmallHead.Images.SetKeyName(57, "58-1.bmp");
            imglistSmallHead.Images.SetKeyName(58, "59-1.bmp");
            imglistSmallHead.Images.SetKeyName(59, "60-1.bmp");
            imglistSmallHead.Images.SetKeyName(60, "61-1.bmp");
            imglistSmallHead.Images.SetKeyName(61, "62-1.bmp");
            imglistSmallHead.Images.SetKeyName(62, "63-1.bmp");
            imglistSmallHead.Images.SetKeyName(63, "64-1.bmp");
            imglistSmallHead.Images.SetKeyName(64, "65-1.bmp");
            imglistSmallHead.Images.SetKeyName(65, "66-1.bmp");
            imglistSmallHead.Images.SetKeyName(66, "67-1.bmp");
            imglistSmallHead.Images.SetKeyName(67, "68-1.bmp");
            imglistSmallHead.Images.SetKeyName(68, "69-1.bmp");
            imglistSmallHead.Images.SetKeyName(69, "70-1.bmp");
            imglistSmallHead.Images.SetKeyName(70, "71-1.bmp");
            imglistSmallHead.Images.SetKeyName(71, "72-1.bmp");
            imglistSmallHead.Images.SetKeyName(72, "73-1.bmp");
            imglistSmallHead.Images.SetKeyName(73, "74-1.bmp");
            imglistSmallHead.Images.SetKeyName(74, "75-1.bmp");
            imglistSmallHead.Images.SetKeyName(75, "76-1.bmp");
            imglistSmallHead.Images.SetKeyName(76, "77-1.bmp");
            imglistSmallHead.Images.SetKeyName(77, "78-1.bmp");
            imglistSmallHead.Images.SetKeyName(78, "79-1.bmp");
            imglistSmallHead.Images.SetKeyName(79, "80-1.bmp");
            imglistSmallHead.Images.SetKeyName(80, "81-1.bmp");
            imglistSmallHead.Images.SetKeyName(81, "82-1.bmp");
            imglistSmallHead.Images.SetKeyName(82, "83-1.bmp");
            imglistSmallHead.Images.SetKeyName(83, "84-1.bmp");
            imglistSmallHead.Images.SetKeyName(84, "85-1.bmp");
            imglistSmallHead.Images.SetKeyName(85, "86-1.bmp");
            imglistSmallHead.Images.SetKeyName(86, "87-1.bmp");
            imglistSmallHead.Images.SetKeyName(87, "88-1.bmp");
            imglistSmallHead.Images.SetKeyName(88, "89-1.bmp");
            imglistSmallHead.Images.SetKeyName(89, "90-1.bmp");
            imglistSmallHead.Images.SetKeyName(90, "91-1.bmp");
            imglistSmallHead.Images.SetKeyName(91, "92-1.bmp");
            imglistSmallHead.Images.SetKeyName(92, "93-1.bmp");
            imglistSmallHead.Images.SetKeyName(93, "94-1.bmp");
            imglistSmallHead.Images.SetKeyName(94, "95-1.bmp");
            imglistSmallHead.Images.SetKeyName(95, "96-1.bmp");
            imglistSmallHead.Images.SetKeyName(96, "97-1.bmp");
            imglistSmallHead.Images.SetKeyName(97, "98-1.bmp");
            imglistSmallHead.Images.SetKeyName(98, "99-1.bmp");
            imglistSmallHead.Images.SetKeyName(99, "100-1.bmp");
            // 
            // imglistMessage
            // 
            imglistMessage.ColorDepth = ColorDepth.Depth16Bit;
            imglistMessage.ImageStream = (ImageListStreamer)resources.GetObject("imglistMessage.ImageStream");
            imglistMessage.TransparentColor = Color.Transparent;
            imglistMessage.Images.SetKeyName(0, "info.ico");
            imglistMessage.Images.SetKeyName(1, "Message.gif");
            // 
            // tmMessage
            // 
            tmMessage.Enabled = true;
            tmMessage.Interval = 2000;
            // 
            // tmAddFriend
            // 
            tmAddFriend.Interval = 1000;
            // 
            // tmChat
            // 
            tmChat.Interval = 500;
            // 
            // pboxHead
            // 
            pboxHead.Location = new Point(12, 43);
            pboxHead.Name = "pboxHead";
            pboxHead.Size = new Size(58, 65);
            pboxHead.TabIndex = 0;
            pboxHead.TabStop = false;
            // 
            // pboxMin
            // 
            pboxMin.BackColor = Color.Transparent;
            pboxMin.Location = new Point(232, 0);
            pboxMin.Name = "pboxMin";
            pboxMin.Size = new Size(27, 24);
            pboxMin.TabIndex = 1;
            pboxMin.TabStop = false;
            // 
            // pboxClose
            // 
            pboxClose.BackColor = Color.Transparent;
            pboxClose.Location = new Point(256, 0);
            pboxClose.Name = "pboxClose";
            pboxClose.Size = new Size(27, 24);
            pboxClose.TabIndex = 2;
            pboxClose.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(103, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 20);
            lblName.TabIndex = 3;
            lblName.Text = "label1";
            // 
            // txtSign
            // 
            txtSign.BorderStyle = BorderStyle.None;
            txtSign.Location = new Point(103, 61);
            txtSign.Name = "txtSign";
            txtSign.Size = new Size(125, 20);
            txtSign.TabIndex = 4;
            // 
            // lvFriend
            // 
            lvFriend.BackColor = Color.OldLace;
            lvFriend.ContextMenuStrip = contextMenuStrip;
            listViewGroup1.Header = "My Friend";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "Strengers";
            listViewGroup2.Name = "listViewGroup2";
            lvFriend.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2 });
            lvFriend.LargeImageList = imalistHead;
            lvFriend.Location = new Point(-5, 114);
            lvFriend.MultiSelect = false;
            lvFriend.Name = "lvFriend";
            lvFriend.Size = new Size(288, 502);
            lvFriend.SmallImageList = imglistSmallHead;
            lvFriend.StateImageList = imglistSmallHead;
            lvFriend.TabIndex = 5;
            lvFriend.UseCompatibleStateImageBehavior = false;
            // 
            // tsOperation
            // 
            tsOperation.Dock = DockStyle.Bottom;
            tsOperation.ImageScalingSize = new Size(20, 20);
            tsOperation.Items.AddRange(new ToolStripItem[] { tsbtninfo, tsbtnSearchFriend, tsbtnUpdateFriendList, tsbtnMessageReading, tsbtnExit });
            tsOperation.Location = new Point(0, 620);
            tsOperation.Name = "tsOperation";
            tsOperation.Size = new Size(282, 27);
            tsOperation.TabIndex = 6;
            tsOperation.Text = "toolStrip1";
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { tsMenuView, tsMenuAdd, tsMenuDel });
            contextMenuStrip.Name = "contextMenuStrip1";
            contextMenuStrip.Size = new Size(161, 76);
            // 
            // tsMenuView
            // 
            tsMenuView.Name = "tsMenuView";
            tsMenuView.Size = new Size(160, 24);
            tsMenuView.Text = "Small Head";
            // 
            // tsMenuAdd
            // 
            tsMenuAdd.Name = "tsMenuAdd";
            tsMenuAdd.Size = new Size(160, 24);
            tsMenuAdd.Text = "Add Friend";
            tsMenuAdd.Visible = false;
            // 
            // tsMenuDel
            // 
            tsMenuDel.Name = "tsMenuDel";
            tsMenuDel.Size = new Size(160, 24);
            tsMenuDel.Text = "Delete";
            tsMenuDel.Visible = false;
            // 
            // tsbtninfo
            // 
            tsbtninfo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtninfo.Image = (Image)resources.GetObject("tsbtninfo.Image");
            tsbtninfo.ImageTransparentColor = Color.Magenta;
            tsbtninfo.Name = "tsbtninfo";
            tsbtninfo.Size = new Size(29, 24);
            tsbtninfo.Text = "personalInfo";
            // 
            // tsbtnSearchFriend
            // 
            tsbtnSearchFriend.Image = (Image)resources.GetObject("tsbtnSearchFriend.Image");
            tsbtnSearchFriend.ImageTransparentColor = Color.Magenta;
            tsbtnSearchFriend.Name = "tsbtnSearchFriend";
            tsbtnSearchFriend.Size = new Size(64, 24);
            tsbtnSearchFriend.Text = "Find";
            // 
            // tsbtnUpdateFriendList
            // 
            tsbtnUpdateFriendList.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnUpdateFriendList.Image = (Image)resources.GetObject("tsbtnUpdateFriendList.Image");
            tsbtnUpdateFriendList.ImageTransparentColor = Color.Magenta;
            tsbtnUpdateFriendList.Name = "tsbtnUpdateFriendList";
            tsbtnUpdateFriendList.Size = new Size(29, 24);
            tsbtnUpdateFriendList.Text = "toolStripButton2";
            // 
            // tsbtnMessageReading
            // 
            tsbtnMessageReading.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnMessageReading.Image = (Image)resources.GetObject("tsbtnMessageReading.Image");
            tsbtnMessageReading.ImageTransparentColor = Color.Magenta;
            tsbtnMessageReading.Name = "tsbtnMessageReading";
            tsbtnMessageReading.Size = new Size(29, 24);
            tsbtnMessageReading.Text = "System Info";
            // 
            // tsbtnExit
            // 
            tsbtnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnExit.Image = (Image)resources.GetObject("tsbtnExit.Image");
            tsbtnExit.ImageTransparentColor = Color.Magenta;
            tsbtnExit.Name = "tsbtnExit";
            tsbtnExit.Size = new Size(29, 24);
            tsbtnExit.Text = "Exit";
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(282, 647);
            Controls.Add(tsOperation);
            Controls.Add(lvFriend);
            Controls.Add(txtSign);
            Controls.Add(lblName);
            Controls.Add(pboxClose);
            Controls.Add(pboxMin);
            Controls.Add(pboxHead);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(800, 5);
            Name = "Frm_Main";
            StartPosition = FormStartPosition.Manual;
            Text = "QQ";
            ((System.ComponentModel.ISupportInitialize)pboxHead).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxClose).EndInit();
            tsOperation.ResumeLayout(false);
            tsOperation.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imalistHead;
        private ImageList imglistSmallHead;
        private ImageList imglistMessage;
        private System.Windows.Forms.Timer tmMessage;
        private System.Windows.Forms.Timer tmAddFriend;
        private System.Windows.Forms.Timer tmChat;
        private PictureBox pboxHead;
        private PictureBox pboxMin;
        private PictureBox pboxClose;
        private Label lblName;
        private TextBox txtSign;
        private ListView lvFriend;
        private ToolStrip tsOperation;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem tsMenuView;
        private ToolStripMenuItem tsMenuAdd;
        private ToolStripMenuItem tsMenuDel;
        private ToolStripButton tsbtninfo;
        private ToolStripButton tsbtnSearchFriend;
        private ToolStripButton tsbtnUpdateFriendList;
        private ToolStripButton tsbtnMessageReading;
        private ToolStripButton tsbtnExit;
    }
}