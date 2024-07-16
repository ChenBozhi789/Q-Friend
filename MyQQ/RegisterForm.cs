using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class RegisterForm : Form
    {
        DataOperator dataOperator = new DataOperator();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            cboxStar.SelectedIndex = 0;
            cbocBloodType.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtNickName.Text.Trim() == "" || txtNickName.Text.Trim().Length > 20)
            {
                MessageBox.Show("Your Nick Name is illegal, Please try again.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNickName.Focus();
                return;
            }

            if (txtAge.Text == "")
            {
                MessageBox.Show("Please input your age.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAge.Focus();
                return;
            }

            if (!rbtnFemale.Checked && !rbtnMale.Checked)
            {
                MessageBox.Show("Please select your sex.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblSex.Focus();
                return;
            }

            if (txtPwd.Text == "")
            {
                MessageBox.Show("Please input  Password.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.Focus();
                return;
            }

            if (txtRePwd.Text == "")
            {
                MessageBox.Show("Please input Password again.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.Focus();
                return;
            }

            if (txtRePwd.Text.Trim() != txtRePwd.Text.Trim())
            {
                MessageBox.Show("The passwords you entered twice are different", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.Focus();
                return;
            }

            int qqNum;
            string message;
            string sex = rbtnMale.Checked ? rbtnMale.Text : rbtnFemale.Text;
            string sql = string.Format("INSERT INTO tb_User (Pwd, NickName, Sex, Age, Name, Star, BloodType) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'); " +
                "SELECT @@IDENTITY FROM tb_User",
                txtPwd.Text.Trim(),
                txtNickName.Text.Trim(),
                sex, int.Parse(txtAge.Text.Trim()),
                txtRealName.Text.Trim(),
                cboxStar.Text,
                cbocBloodType.Text);

            SqlCommand command = new SqlCommand(sql, DataOperator.connection);
            DataOperator.connection.Open();
            int result = command.ExecuteNonQuery();

            if (result == 1)
            {
                sql = "SELECT SCOPE_IDENTITY() FROM tb_User";
                command = new SqlCommand(sql, DataOperator.connection);
                // QQ 号为转换为数字的新插入标识值
                qqNum = Convert.ToInt32(command.ExecuteScalar());
                message = string.Format("Congras, Your QQ has been registered, your QQ number is " + qqNum);
            }
            else
            {
                message = "Please try again";
            }
            DataOperator.connection.Close();
            MessageBox.Show(message, "Registration Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
