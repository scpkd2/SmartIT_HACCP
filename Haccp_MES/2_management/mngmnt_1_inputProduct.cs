using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haccp_MES._2_management
{
    public partial class mngmnt_1_inputProduct : Form
    {
        public mngmnt_1_inputProduct()
        {
            InitializeComponent();
            // 창기 주석테스트
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            mngmnt_1_1_insertData dlg = new mngmnt_1_1_insertData();
            dlg.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
