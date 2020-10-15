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
    public partial class mngmnt_1_1_insertData : Form
    {
        public mngmnt_1_1_insertData()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gridRegisterInput.Rows.Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadMaterialList_Click(object sender, EventArgs e)
        {
            mngmnt_1_2_materialList dlg = new mngmnt_1_2_materialList();
            dlg.ShowDialog();
        }
    }
}
