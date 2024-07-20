using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Media;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        // Message sender
        int fromUserID;
        // Indicates the ID of the friend who sent the message.
        int friendHeadID;
        // Indicates the index of the message icon in the ToolStrip
        int messageImageIndex = 0;
        // Current User NickName
        public static string nickName = "";
        // Indicates the online status identifier of the current user
        public static string strFlag = "[Offline]";
        DataOperator dataOper = new DataOperator();

        // Display personal Info, such as NickName, Head, Sign, and Account
        public void ShowInfo()
        {
            // HeadID index
            int headID = 0;

            // Get current User NickName, Head, and Sign
            // PublicClass.LoginID: Current User ID
            string sql = "SELECT NickName, HeadID, Sign FROM tb_User WHERE ID =" + PublicClass.LoginID;
            // Execute query
            SqlDataReader dataReader = dataOper.GetDataReader(sql);

            // Read query result
            if (dataReader.Read())
            {
                // Store NickName, HeadID, and Sign
                if (!(dataReader["NickName"] is DBNull))
                {
                    nickName = dataReader["NickName"].ToString();
                }
                headID = Convert.ToInt32(dataReader["HeadID"]);
                txtSign.Text = dataReader["Sign"].ToString();

                // Close Datareader and database connection
                dataReader.Close();
                DataOperator.connection.Close();

                // Set the titile of this Form to the current user's account
                this.Text = PublicClass.LoginID.ToString();

                // Set User head (According to headID)
                pboxHead.Image = imalistHead.Images[headID];

                // Display nickname and account
                lblName.Text = nickName + "(" + PublicClass.LoginID + ")";
            }
        }

        // This method to show current user's friend list info, such as FriendID, NickName, HeadID, and Flag
        private void ShowFriendList()
        {
            // This line of code clears all items in lvFriend so that friends list can be reloaded
            lvFriend.Items.Clear();
            string sql = "SELECT FriendID, NickName, HeadID, Flag FROM tb_User, tb_Friend WHERE tb_Friend.HostID=" + PublicClass.LoginID + "AND tb_User.ID = tb_Friend.FriendID";
            SqlDataReader dataReader = dataOper.GetDataReader(sql);

            // Add the index of newly added item of ListView
            int i = lvFriend.Items.Count;

            // The loop body is executed while the condition is true
            // If dataReader have any note, it will returns true
            while (dataReader.Read())
            {
                if (dataReader["Flag"].ToString() == "0")
                    strFlag = "[Offline]";
                else
                    strFlag = "[Online]";

                // Get Friend's NickName from query result
                string strTemp = dataReader["NickName"].ToString();
                // Handling Friend's NickNames
                string strFriendName = strTemp;
                if (strTemp.Length < 9)
                    strFriendName = strTemp.PadLeft(9, ' ');
                else
                    (strFriendName = strTemp.Substring(0, 2) + "...").PadLeft(9, ' ');

                // Add item to ListView
                lvFriend.Items.Add(dataReader["FriendID"].ToString(), strFriendName + strFlag, (int)dataReader["HeadID"]);
                // Set the group of the newly added item to "MyFriend"
                lvFriend.Items[i].Group = lvFriend.Groups[0];
                i++;
            }
            // Close datareader and database connection
            dataReader.Close();
            DataOperator.connection.Close();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            // Set tsbtnMessageReading icon
            tsbtnMessageReading.Image = imglistMessage.Images[0];
            // Show personal info
            ShowInfo();
            // Show Friend info
            ShowFriendList();
        }

        private void tsbtninfo_Click(object sender, EventArgs e)
        {
            Frm_EditInfo frmInfo = new Frm_EditInfo();
            frmInfo.Show();
        }

        private void tsbtnSearchFriend_Click(object sender, EventArgs e)
        {
            Frm_AddFriend frm_AddFriend = new Frm_AddFriend();
            frm_AddFriend.Show();
        }

        private void tsbtnUpdateFriendList_Click(object sender, EventArgs e)
        {
            // Refresh Friend lsit
            ShowFriendList();
        }

        private void tsbtnMessageReading_Click(object sender, EventArgs e)
        {
            tmAddFriend.Stop();
            // Stop info remind timer
            messageImageIndex = 0;
            tsbtnMessageReading.Image = imglistMessage.Images[messageImageIndex];
            Frm_Remind frm_Remind = new Frm_Remind();
            frm_Remind.Show();
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure exit?", "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        Frm_Chat frmChat;
        private void lvFriend_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Checks whether there is a selected item in the lvFriend control
            if (lvFriend.SelectedItems.Count > 0)
            {
                // frmChat object is null
                if (frmChat == null)
                {
                    frmChat = new Frm_Chat();
                    frmChat.friendID = Convert.ToInt32(lvFriend.SelectedItems[0].Name);

                    // Execute a SQL query and
                    frmChat.nickName = dataOper.GetDataSet("SELECT NickName FROM tb_User WHERE ID=" + frmChat.friendID).Tables[0].Rows[0][0].ToString();
                    // Note HeadID
                    frmChat.headID = Convert.ToInt32(dataOper.GetDataSet("SELECT HeadID FROM tb_User WHERE ID=" + frmChat.friendID).Tables[0].Rows[0][0]) + 1;

                    frmChat.ShowDialog();
                    // After frmChat closed, set frmChat to null
                    frmChat = null;
                }
                // Check to see if timer is running
                if (tmChat.Enabled == true)
                {
                    tmChat.Stop();
                    // 
                    lvFriend.SelectedItems[0].ImageIndex = friendHeadID;
                }
            }
        }

        private void pboxMin_Click(object sender, EventArgs e)
        {

        }

        private void pboxClose_Click(object sender, EventArgs e)
        {

        }

        private void lvFriend_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Frm_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void lvFriend_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
