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

        int fromUserID;
        int friendHeadID;
        int messageImageIndex = 0;
        public static string nickName = "";
        public static string strFlag = "[Offline]";
        DataOperator dataOper = new DataOperator();
    }
}
