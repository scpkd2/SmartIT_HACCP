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

        private void button2_Click(object sender, EventArgs e)
        {
            info_1_2_inputacnt info = new info_1_2_inputacnt();
            info.ShowDialog();
        }
    }
}
