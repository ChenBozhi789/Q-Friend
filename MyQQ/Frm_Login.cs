using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Data;

namespace MyQQ
{
    public partial class Frm_Login : Form
    {
        DataOperator dataOper = new DataOperator();

        public Frm_Login()
        {
            InitializeComponent();
        }

        // This method for validate use input ID and Password
        private bool ValidateInput()
        {
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("Please input Account", "Login Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
                return false;
            }
            else if (int.Parse(txtID.Text.Trim()) > 65535)
            {
                MessageBox.Show("Please input Account", "Login Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
                return false;
            }
            else if (txtID.Text.Length > 5 && txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("Please input Password", "Login Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();                                 //使密码文本框获得鼠标焦点
                return false;
            }
            return true;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == '\n') || (e.KeyChar == '\b'))
            {
                // 表示按键事件没有被处理，控件会继续处理这个按键事件。这意味着按键的字符会显示在控件（如文本框）中。
                e.Handled = false;
            }
            else
            {
                // 取消在控件中显示该字符
                e.Handled = true;
            }
        }

        private void pBoxLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Customize SQL Query Script
                //  
                string sql = "SELECT COUNT(*) FROM tb_User WHERE ID = " + int.Parse(txtID.Text.Trim()) + " and Pwd = '" + txtPwd.Text.Trim() + "'";
                int num = dataOper.ExecSQL(sql);

                // Validate pass
                if (num == 1)
                {
                    // Set User LoginID
                    PublicClass.LoginID = int.Parse(txtID.Text.Trim());
                    // If remember checkbox has been checked
                    if (cboxRemember.Checked)
                    {
                        dataOper.ExecSQLResult("UPDATE tb_User SET Remember = 1 WHERE ID = " + int.Parse(txtID.Text.Trim()));

                        if (cBoxAutoLogin.Checked)
                        {
                            dataOper.ExecSQLResult("UPDATE tb_User SET AutoLogin =  WHERE ID = " + int.Parse(txtID.Text.Trim()));
                        }
                    }
                    else
                    {
                        dataOper.ExecSQLResult("UPDATE tb_User SET Remember = 0 WHERE ID = " + int.Parse(txtID.Text.Trim()));
                        dataOper.ExecSQLResult("UPDATE tb_User SET AutoLogin = 0 WHERE ID = " + int.Parse(txtID.Text.Trim()));
                    }
                }

                // Set Online Status
                dataOper.ExecSQLResult("UPDATE tb_User SET Flag = 0 WHERE ID = " + int.Parse(txtID.Text.Trim()));

                // Create MainForm
                Frm_Main MainForm = new Frm_Main();
                MainForm.ShowDialog();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("The input ID or Password is incorrect, Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                pBoxLogin_Click(sender, e);
        }

        private void cboxRemember_CheckedChanged(object sender, EventArgs e)
        {
            // If Remember Password isn't checked
            if (!cboxRemember.Checked)
                // Set AutoLogin to false
                cBoxAutoLogin.Checked = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
            string sql = "SELECT Pwd, Remember, AutoLogin FROM tb_User WHERE ID =" + int.Parse(txtID.Text.Trim());

            DataSet ds = dataOper.GetDataSet(sql);

            // 只有 DataSet 中有该行数据才执行验证记住密码、自动登录
            if (ds.Tables[0].Rows.Count > 0)
            {
                // Remember Password
                if (Convert.ToInt32(ds.Tables[0].Rows[0][1]) == 1)
                {
                    cboxRemember.Checked = true;
                    txtPwd.Text = ds.Tables[0].Rows[0][0].ToString();

                    // Automatic Login
                    if (Convert.ToInt32(ds.Tables[0].Rows[0][2]) == 1)
                    {
                        cBoxAutoLogin.Checked = true;
                        pBoxLogin_Click(sender, e);
                    }
                }
            }
        }

        private void linkLblRag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void pBoxMin_Click(object sender, EventArgs e)
        {
            // "this" means the object of current instance
            this.WindowState = FormWindowState.Minimized;
        }

        private void pBoxClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}