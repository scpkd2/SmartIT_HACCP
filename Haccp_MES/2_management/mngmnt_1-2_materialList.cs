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
    public partial class mngmnt_1_2_materialList : Form
    {
        // 문혁이 체크 s
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;


        public mngmnt_1_2_materialList()
        {
            InitializeComponent();
            conn = new MySqlConnection(DatabaseInfo.DBConnectStr());
            dt = new DataTable();

            gridMaterialList.RowHeadersVisible = false;
        }

        private void mngmnt_1_2_materialList_Load(object sender, EventArgs e)
        {
            conn.Open();

            string orderInfoHeadQuery = "SELECT mat_no, mat_name, mat_type, mat_spec, mat_price, com_name, mat_etc FROM info_material m LEFT JOIN info_company c on m.com_no=c.com_no WHERE NOT mat_type IN ('제품');";
            cmd = new MySqlCommand(orderInfoHeadQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            gridMaterialList.DataSource = dt;
            //dt.Dispose();
            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridMaterialList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rowIndex = gridMaterialList.CurrentRow.Index;

            mngmnt_1_1_insertData parentForm = (mngmnt_1_1_insertData)Owner;
            parentForm.childVal = gridMaterialList.CurrentRow;
            this.Close();
        }
    }
}
