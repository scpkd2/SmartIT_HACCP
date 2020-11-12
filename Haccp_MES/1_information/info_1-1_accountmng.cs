using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haccp_MES._1_information
{
    public partial class info_1_1_accountmng : Form
    {
        public info_1_1_accountmng()
        {
            InitializeComponent();

        }


        //신규 버튼 누르면 창띄우기
        private void btnInsert_Click(object sender, EventArgs e)
        {
            info_1_2_inputacnt newForm = new info_1_2_inputacnt();
            newForm.Show();
        }
    }
}
