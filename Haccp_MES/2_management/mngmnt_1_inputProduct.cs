using MySql.Data.MySqlClient;
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
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public mngmnt_1_inputProduct()
        {
            InitializeComponent();
            conn = new MySqlConnection(DatabaseInfo.DBConnectStr());
            dt = new DataTable();
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

        private void mngmnt_1_inputProduct_Load(object sender, EventArgs e)
        {
            conn.Open(); 
            
            string orderInfoHeadQuery = "select input_idx, mat_name, mat_type, mat_spec, input_count, ware_name, input_date from manage_input, info_material, info_warehouse"+
                " where manage_input.mat_no = info_material.mat_no and manage_input.ware_no = info_warehouse.ware_no;";
            cmd = new MySqlCommand(orderInfoHeadQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            gridManageInput.DataSource = dt;

            lblHeadCount.Text = dt.Rows.Count.ToString();

            //dt.Dispose();
            conn.Close();
        }
    }
}
