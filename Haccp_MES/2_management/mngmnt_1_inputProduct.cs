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
        DataTable dtHead;
        DataTable dtBody;


        public mngmnt_1_inputProduct()
        {
            InitializeComponent();
            conn = new MySqlConnection(DatabaseInfo.DBConnectStr());
            dtHead = new DataTable();

            gridManageInputHead.RowHeadersVisible = false;
            gridManageInputBody.RowHeadersVisible = false;
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
            
            string orderInfoHeadQuery = "SELECT input_idx, mat_name, mat_type, mat_spec, input_count, ware_name, input_date FROM manage_input, info_material, info_warehouse " + 
                "WHERE manage_input.mat_no = info_material.mat_no and manage_input.ware_no = info_warehouse.ware_no;";
            cmd = new MySqlCommand(orderInfoHeadQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtHead);

            gridManageInputHead.DataSource = dtHead;
            lblHeadCount.Text = gridManageInputHead.Rows.Count.ToString();
            //dt.Dispose();
            conn.Close();
        }

        private void gridManageInput_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex == -1)
            {
                e.PaintBackground(e.ClipBounds, false);

                Point pt = e.CellBounds.Location;

                int nChkBoxWidth = 15;
                int nChkBoxHeight = 15;
                int offsetx = (e.CellBounds.Width - nChkBoxWidth) / 2;
                int offsety = (e.CellBounds.Height - nChkBoxHeight) / 2;

                pt.X += offsetx;
                pt.Y += offsety;

                CheckBox cb = new CheckBox();
                cb.Size = new Size(nChkBoxWidth, nChkBoxHeight);
                cb.Location = pt;
                cb.CheckedChanged += new EventHandler(gvSheetListCheckBox_CheckedChanged);

                ((DataGridView)sender).Controls.Add(cb);

                e.Handled = true;
            }
        }

        private void gvSheetListCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in gridManageInputHead.Rows)
            {
                r.Cells["colCheck"].Value = ((CheckBox)sender).Checked;
            }
        }

        private void mngmnt_1_inputProduct_Shown(object sender, EventArgs e)
        {
            //gridManageInputHead.CurrentCell = null;
        }

        private void gridManageInput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtBody = new DataTable();

            conn.Open();

            string orderInfoBodyQuery = "SELECT info_material.mat_no, mat_name, mat_type, mat_spec, mat_price, input_count, mat_price * input_count as 'input_totprc', "
                + "input_inspec, com_name, ware_name, input_admin, input_date "
                + "FROM manage_input, info_material, info_warehouse, info_company "
                + "WHERE manage_input.mat_no = info_material.mat_no and manage_input.ware_no = info_warehouse.ware_no and info_material.com_no = info_company.com_no;";
            cmd = new MySqlCommand(orderInfoBodyQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtBody);

            gridManageInputBody.DataSource = dtBody;
            lblBodyCount.Text = gridManageInputBody.Rows.Count.ToString();

            conn.Close();
        }

        private void gridManageInputHead_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //gridManageInputHead.CurrentCell.Style.SelectionBackColor = Color.WhiteSmoke;
            e.CellStyle.BackColor = Color.Brown;
            
        }

        private void gridManageInputBody_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //gridManageInputBody.CurrentCell.Style.SelectionBackColor = Color.WhiteSmoke;
            e.CellStyle.BackColor = Color.Brown;
        }
    }
}
