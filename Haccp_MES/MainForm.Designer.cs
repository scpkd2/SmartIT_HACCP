namespace Haccp_MES
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelProdt_SubMenu = new System.Windows.Forms.Panel();
            this.btn_Time_Trend = new System.Windows.Forms.Button();
            this.btn_Result_Mng = new System.Windows.Forms.Button();
            this.btn_Work_CMD = new System.Windows.Forms.Button();
            this.btn_Product_Mng = new System.Windows.Forms.Button();
            this.panelOpt_SubMenu = new System.Windows.Forms.Panel();
            this.btn_Inven_Matching = new System.Windows.Forms.Button();
            this.btn_Inventory_Trend = new System.Windows.Forms.Button();
            this.btn_Out_item_Mng = new System.Windows.Forms.Button();
            this.btn_Input_Item_Mng = new System.Windows.Forms.Button();
            this.btn_Opt_Mng = new System.Windows.Forms.Button();
            this.panelMES_info_SubMenu = new System.Windows.Forms.Panel();
            this.btn_Sample1 = new System.Windows.Forms.Button();
            this.btn_Storg_Mng = new System.Windows.Forms.Button();
            this.btn_Prodt_Mng = new System.Windows.Forms.Button();
            this.btn_Clinet_Mng = new System.Windows.Forms.Button();
            this.btn_Std_Info = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabCilentMng = new System.Windows.Forms.Button();
            this.tabHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelProdt_SubMenu.SuspendLayout();
            this.panelOpt_SubMenu.SuspendLayout();
            this.panelMES_info_SubMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelSideMenu.Controls.Add(this.panelProdt_SubMenu);
            this.panelSideMenu.Controls.Add(this.btn_Product_Mng);
            this.panelSideMenu.Controls.Add(this.panelOpt_SubMenu);
            this.panelSideMenu.Controls.Add(this.btn_Opt_Mng);
            this.panelSideMenu.Controls.Add(this.panelMES_info_SubMenu);
            this.panelSideMenu.Controls.Add(this.btn_Std_Info);
            this.panelSideMenu.Controls.Add(this.btn_Home);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(219, 638);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelProdt_SubMenu
            // 
            this.panelProdt_SubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.panelProdt_SubMenu.Controls.Add(this.btn_Time_Trend);
            this.panelProdt_SubMenu.Controls.Add(this.btn_Result_Mng);
            this.panelProdt_SubMenu.Controls.Add(this.btn_Work_CMD);
            this.panelProdt_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProdt_SubMenu.Location = new System.Drawing.Point(0, 502);
            this.panelProdt_SubMenu.Name = "panelProdt_SubMenu";
            this.panelProdt_SubMenu.Size = new System.Drawing.Size(219, 105);
            this.panelProdt_SubMenu.TabIndex = 8;
            // 
            // btn_Time_Trend
            // 
            this.btn_Time_Trend.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Time_Trend.FlatAppearance.BorderSize = 0;
            this.btn_Time_Trend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Time_Trend.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Time_Trend.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Time_Trend.Image = ((System.Drawing.Image)(resources.GetObject("btn_Time_Trend.Image")));
            this.btn_Time_Trend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Time_Trend.Location = new System.Drawing.Point(0, 64);
            this.btn_Time_Trend.Name = "btn_Time_Trend";
            this.btn_Time_Trend.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_Time_Trend.Size = new System.Drawing.Size(219, 32);
            this.btn_Time_Trend.TabIndex = 4;
            this.btn_Time_Trend.Text = "     기간별 생산 현황";
            this.btn_Time_Trend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Time_Trend.UseVisualStyleBackColor = true;
            this.btn_Time_Trend.Click += new System.EventHandler(this.btn_Time_Trend_Click);
            // 
            // btn_Result_Mng
            // 
            this.btn_Result_Mng.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Result_Mng.FlatAppearance.BorderSize = 0;
            this.btn_Result_Mng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Result_Mng.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Result_Mng.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Result_Mng.Image = ((System.Drawing.Image)(resources.GetObject("btn_Result_Mng.Image")));
            this.btn_Result_Mng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Result_Mng.Location = new System.Drawing.Point(0, 32);
            this.btn_Result_Mng.Name = "btn_Result_Mng";
            this.btn_Result_Mng.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_Result_Mng.Size = new System.Drawing.Size(219, 32);
            this.btn_Result_Mng.TabIndex = 2;
            this.btn_Result_Mng.Text = "     생산 실적 관리";
            this.btn_Result_Mng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Result_Mng.UseVisualStyleBackColor = true;
            this.btn_Result_Mng.Click += new System.EventHandler(this.btn_Result_Mng_Click);
            // 
            // btn_Work_CMD
            // 
            this.btn_Work_CMD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Work_CMD.FlatAppearance.BorderSize = 0;
            this.btn_Work_CMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Work_CMD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Work_CMD.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Work_CMD.Image = ((System.Drawing.Image)(resources.GetObject("btn_Work_CMD.Image")));
            this.btn_Work_CMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Work_CMD.Location = new System.Drawing.Point(0, 0);
            this.btn_Work_CMD.Name = "btn_Work_CMD";
            this.btn_Work_CMD.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_Work_CMD.Size = new System.Drawing.Size(219, 32);
            this.btn_Work_CMD.TabIndex = 1;
            this.btn_Work_CMD.Text = "     작업 지시 등록";
            this.btn_Work_CMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Work_CMD.UseVisualStyleBackColor = true;
            this.btn_Work_CMD.Click += new System.EventHandler(this.btn_Work_CMD_Click);
            // 
            // btn_Product_Mng
            // 
            this.btn_Product_Mng.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Product_Mng.FlatAppearance.BorderSize = 0;
            this.btn_Product_Mng.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.btn_Product_Mng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_Product_Mng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product_Mng.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Product_Mng.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Product_Mng.Image = ((System.Drawing.Image)(resources.GetObject("btn_Product_Mng.Image")));
            this.btn_Product_Mng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Product_Mng.Location = new System.Drawing.Point(0, 460);
            this.btn_Product_Mng.Name = "btn_Product_Mng";
            this.btn_Product_Mng.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btn_Product_Mng.Size = new System.Drawing.Size(219, 42);
            this.btn_Product_Mng.TabIndex = 7;
            this.btn_Product_Mng.Text = "      생산관리";
            this.btn_Product_Mng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Product_Mng.UseVisualStyleBackColor = true;
            this.btn_Product_Mng.Click += new System.EventHandler(this.btn_Product_Mng_Click);
            // 
            // panelOpt_SubMenu
            // 
            this.panelOpt_SubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.panelOpt_SubMenu.Controls.Add(this.btn_Inven_Matching);
            this.panelOpt_SubMenu.Controls.Add(this.btn_Inventory_Trend);
            this.panelOpt_SubMenu.Controls.Add(this.btn_Out_item_Mng);
            this.panelOpt_SubMenu.Controls.Add(this.btn_Input_Item_Mng);
            this.panelOpt_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpt_SubMenu.Location = new System.Drawing.Point(0, 325);
            this.panelOpt_SubMenu.Name = "panelOpt_SubMenu";
            this.panelOpt_SubMenu.Size = new System.Drawing.Size(219, 135);
            this.panelOpt_SubMenu.TabIndex = 6;
            // 
            // btn_Inven_Matching
            // 
            this.btn_Inven_Matching.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Inven_Matching.FlatAppearance.BorderSize = 0;
            this.btn_Inven_Matching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inven_Matching.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Inven_Matching.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Inven_Matching.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inven_Matching.Image")));
            this.btn_Inven_Matching.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inven_Matching.Location = new System.Drawing.Point(0, 96);
            this.btn_Inven_Matching.Name = "btn_Inven_Matching";
            this.btn_Inven_Matching.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btn_Inven_Matching.Size = new System.Drawing.Size(219, 32);
            this.btn_Inven_Matching.TabIndex = 5;
            this.btn_Inven_Matching.Text = "     품목 창고 실사";
            this.btn_Inven_Matching.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inven_Matching.UseVisualStyleBackColor = true;
            this.btn_Inven_Matching.Click += new System.EventHandler(this.btn_Inven_Matching_Click);
            // 
            // btn_Inventory_Trend
            // 
            this.btn_Inventory_Trend.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Inventory_Trend.FlatAppearance.BorderSize = 0;
            this.btn_Inventory_Trend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inventory_Trend.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Inventory_Trend.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Inventory_Trend.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inventory_Trend.Image")));
            this.btn_Inventory_Trend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inventory_Trend.Location = new System.Drawing.Point(0, 64);
            this.btn_Inventory_Trend.Name = "btn_Inventory_Trend";
            this.btn_Inventory_Trend.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btn_Inventory_Trend.Size = new System.Drawing.Size(219, 32);
            this.btn_Inventory_Trend.TabIndex = 4;
            this.btn_Inventory_Trend.Text = "     품목 재고 현황";
            this.btn_Inventory_Trend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inventory_Trend.UseVisualStyleBackColor = true;
            this.btn_Inventory_Trend.Click += new System.EventHandler(this.btn_Inventory_Trend_Click);
            // 
            // btn_Out_item_Mng
            // 
            this.btn_Out_item_Mng.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Out_item_Mng.FlatAppearance.BorderSize = 0;
            this.btn_Out_item_Mng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Out_item_Mng.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Out_item_Mng.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Out_item_Mng.Image = ((System.Drawing.Image)(resources.GetObject("btn_Out_item_Mng.Image")));
            this.btn_Out_item_Mng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Out_item_Mng.Location = new System.Drawing.Point(0, 32);
            this.btn_Out_item_Mng.Name = "btn_Out_item_Mng";
            this.btn_Out_item_Mng.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btn_Out_item_Mng.Size = new System.Drawing.Size(219, 32);
            this.btn_Out_item_Mng.TabIndex = 1;
            this.btn_Out_item_Mng.Text = "     제품 출고 관리";
            this.btn_Out_item_Mng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Out_item_Mng.UseVisualStyleBackColor = true;
            this.btn_Out_item_Mng.Click += new System.EventHandler(this.btn_Out_item_Mng_Click);
            // 
            // btn_Input_Item_Mng
            // 
            this.btn_Input_Item_Mng.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Input_Item_Mng.FlatAppearance.BorderSize = 0;
            this.btn_Input_Item_Mng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Input_Item_Mng.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Input_Item_Mng.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Input_Item_Mng.Image = ((System.Drawing.Image)(resources.GetObject("btn_Input_Item_Mng.Image")));
            this.btn_Input_Item_Mng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Input_Item_Mng.Location = new System.Drawing.Point(0, 0);
            this.btn_Input_Item_Mng.Name = "btn_Input_Item_Mng";
            this.btn_Input_Item_Mng.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btn_Input_Item_Mng.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Input_Item_Mng.Size = new System.Drawing.Size(219, 32);
            this.btn_Input_Item_Mng.TabIndex = 1;
            this.btn_Input_Item_Mng.Text = "     품목 입고 관리";
            this.btn_Input_Item_Mng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Input_Item_Mng.UseVisualStyleBackColor = true;
            this.btn_Input_Item_Mng.Click += new System.EventHandler(this.btn_Input_Item_Mng_Click);
            // 
            // btn_Opt_Mng
            // 
            this.btn_Opt_Mng.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Opt_Mng.FlatAppearance.BorderSize = 0;
            this.btn_Opt_Mng.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.btn_Opt_Mng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_Opt_Mng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Opt_Mng.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Opt_Mng.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Opt_Mng.Image = ((System.Drawing.Image)(resources.GetObject("btn_Opt_Mng.Image")));
            this.btn_Opt_Mng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Opt_Mng.Location = new System.Drawing.Point(0, 283);
            this.btn_Opt_Mng.Name = "btn_Opt_Mng";
            this.btn_Opt_Mng.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btn_Opt_Mng.Size = new System.Drawing.Size(219, 42);
            this.btn_Opt_Mng.TabIndex = 5;
            this.btn_Opt_Mng.Text = "      영업관리";
            this.btn_Opt_Mng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Opt_Mng.UseVisualStyleBackColor = true;
            this.btn_Opt_Mng.Click += new System.EventHandler(this.btn_Opt_Mng_Click);
            // 
            // panelMES_info_SubMenu
            // 
            this.panelMES_info_SubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.panelMES_info_SubMenu.Controls.Add(this.btn_Sample1);
            this.panelMES_info_SubMenu.Controls.Add(this.btn_Storg_Mng);
            this.panelMES_info_SubMenu.Controls.Add(this.btn_Prodt_Mng);
            this.panelMES_info_SubMenu.Controls.Add(this.btn_Clinet_Mng);
            this.panelMES_info_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMES_info_SubMenu.Location = new System.Drawing.Point(0, 152);
            this.panelMES_info_SubMenu.Name = "panelMES_info_SubMenu";
            this.panelMES_info_SubMenu.Size = new System.Drawing.Size(219, 131);
            this.panelMES_info_SubMenu.TabIndex = 4;
            // 
            // btn_Sample1
            // 
            this.btn_Sample1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Sample1.FlatAppearance.BorderSize = 0;
            this.btn_Sample1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sample1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Sample1.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Sample1.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sample1.Image")));
            this.btn_Sample1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sample1.Location = new System.Drawing.Point(0, 96);
            this.btn_Sample1.Name = "btn_Sample1";
            this.btn_Sample1.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btn_Sample1.Size = new System.Drawing.Size(219, 32);
            this.btn_Sample1.TabIndex = 3;
            this.btn_Sample1.Text = "     공정 관리";
            this.btn_Sample1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sample1.UseVisualStyleBackColor = true;
            this.btn_Sample1.Click += new System.EventHandler(this.btn_Sample1_Click);
            // 
            // btn_Storg_Mng
            // 
            this.btn_Storg_Mng.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Storg_Mng.FlatAppearance.BorderSize = 0;
            this.btn_Storg_Mng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Storg_Mng.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Storg_Mng.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Storg_Mng.Image = ((System.Drawing.Image)(resources.GetObject("btn_Storg_Mng.Image")));
            this.btn_Storg_Mng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Storg_Mng.Location = new System.Drawing.Point(0, 64);
            this.btn_Storg_Mng.Name = "btn_Storg_Mng";
            this.btn_Storg_Mng.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btn_Storg_Mng.Size = new System.Drawing.Size(219, 32);
            this.btn_Storg_Mng.TabIndex = 2;
            this.btn_Storg_Mng.Text = "     보관 창고 관리";
            this.btn_Storg_Mng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Storg_Mng.UseVisualStyleBackColor = true;
            this.btn_Storg_Mng.Click += new System.EventHandler(this.btn_Storg_Mng_Click);
            // 
            // btn_Prodt_Mng
            // 
            this.btn_Prodt_Mng.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Prodt_Mng.FlatAppearance.BorderSize = 0;
            this.btn_Prodt_Mng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prodt_Mng.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Prodt_Mng.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Prodt_Mng.Image = ((System.Drawing.Image)(resources.GetObject("btn_Prodt_Mng.Image")));
            this.btn_Prodt_Mng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Prodt_Mng.Location = new System.Drawing.Point(0, 32);
            this.btn_Prodt_Mng.Name = "btn_Prodt_Mng";
            this.btn_Prodt_Mng.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btn_Prodt_Mng.Size = new System.Drawing.Size(219, 32);
            this.btn_Prodt_Mng.TabIndex = 1;
            this.btn_Prodt_Mng.Text = "     품목 관리";
            this.btn_Prodt_Mng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Prodt_Mng.UseVisualStyleBackColor = true;
            this.btn_Prodt_Mng.Click += new System.EventHandler(this.btn_Prodt_Mng_Click);
            // 
            // btn_Clinet_Mng
            // 
            this.btn_Clinet_Mng.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Clinet_Mng.FlatAppearance.BorderSize = 0;
            this.btn_Clinet_Mng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clinet_Mng.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Clinet_Mng.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Clinet_Mng.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clinet_Mng.Image")));
            this.btn_Clinet_Mng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clinet_Mng.Location = new System.Drawing.Point(0, 0);
            this.btn_Clinet_Mng.Name = "btn_Clinet_Mng";
            this.btn_Clinet_Mng.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btn_Clinet_Mng.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Clinet_Mng.Size = new System.Drawing.Size(219, 32);
            this.btn_Clinet_Mng.TabIndex = 1;
            this.btn_Clinet_Mng.Text = "     고객사 관리";
            this.btn_Clinet_Mng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clinet_Mng.UseVisualStyleBackColor = true;
            this.btn_Clinet_Mng.Click += new System.EventHandler(this.btn_Clinet_Mng_Click);
            // 
            // btn_Std_Info
            // 
            this.btn_Std_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Std_Info.FlatAppearance.BorderSize = 0;
            this.btn_Std_Info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.btn_Std_Info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_Std_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Std_Info.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Std_Info.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Std_Info.Image = ((System.Drawing.Image)(resources.GetObject("btn_Std_Info.Image")));
            this.btn_Std_Info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Std_Info.Location = new System.Drawing.Point(0, 110);
            this.btn_Std_Info.Name = "btn_Std_Info";
            this.btn_Std_Info.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btn_Std_Info.Size = new System.Drawing.Size(219, 42);
            this.btn_Std_Info.TabIndex = 3;
            this.btn_Std_Info.Text = "      MES 기준정보";
            this.btn_Std_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Std_Info.UseVisualStyleBackColor = true;
            this.btn_Std_Info.Click += new System.EventHandler(this.btn_Std_Info_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Home.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(0, 68);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btn_Home.Size = new System.Drawing.Size(219, 42);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = "      HOME";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(219, 68);
            this.panelLogo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(219, 610);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 28);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(896, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clock";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(352, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "COPYLIGHT ⓒ Team_1 ALL RIGHTS RESERVED";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.panelChildForm.Location = new System.Drawing.Point(219, 39);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(965, 571);
            this.panelChildForm.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.tabCilentMng);
            this.panel2.Controls.Add(this.tabHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(219, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 34);
            this.panel2.TabIndex = 3;
            // 
            // tabCilentMng
            // 
            this.tabCilentMng.BackColor = System.Drawing.Color.Transparent;
            this.tabCilentMng.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabCilentMng.FlatAppearance.BorderSize = 0;
            this.tabCilentMng.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.tabCilentMng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.tabCilentMng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabCilentMng.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabCilentMng.ForeColor = System.Drawing.SystemColors.Control;
            this.tabCilentMng.Location = new System.Drawing.Point(86, 0);
            this.tabCilentMng.Name = "tabCilentMng";
            this.tabCilentMng.Size = new System.Drawing.Size(86, 34);
            this.tabCilentMng.TabIndex = 1;
            this.tabCilentMng.Text = "고객사관리";
            this.tabCilentMng.UseVisualStyleBackColor = false;
            this.tabCilentMng.Click += new System.EventHandler(this.tabCilentMng_Click);
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.Transparent;
            this.tabHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabHome.FlatAppearance.BorderSize = 0;
            this.tabHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.tabHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.tabHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabHome.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabHome.ForeColor = System.Drawing.SystemColors.Control;
            this.tabHome.Location = new System.Drawing.Point(0, 0);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(86, 34);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "HOME";
            this.tabHome.UseVisualStyleBackColor = false;
            this.tabHome.Click += new System.EventHandler(this.tabHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(219, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 5);
            this.panel3.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 638);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 677);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HACCP MESSI v1.0";
            this.panelSideMenu.ResumeLayout(false);
            this.panelProdt_SubMenu.ResumeLayout(false);
            this.panelOpt_SubMenu.ResumeLayout(false);
            this.panelMES_info_SubMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelOpt_SubMenu;
        private System.Windows.Forms.Button btn_Inven_Matching;
        private System.Windows.Forms.Button btn_Inventory_Trend;
        private System.Windows.Forms.Button btn_Out_item_Mng;
        private System.Windows.Forms.Button btn_Input_Item_Mng;
        private System.Windows.Forms.Button btn_Opt_Mng;
        private System.Windows.Forms.Panel panelMES_info_SubMenu;
        private System.Windows.Forms.Button btn_Storg_Mng;
        private System.Windows.Forms.Button btn_Prodt_Mng;
        private System.Windows.Forms.Button btn_Clinet_Mng;
        private System.Windows.Forms.Button btn_Std_Info;
        private System.Windows.Forms.Panel panelProdt_SubMenu;
        private System.Windows.Forms.Button btn_Time_Trend;
        private System.Windows.Forms.Button btn_Result_Mng;
        private System.Windows.Forms.Button btn_Work_CMD;
        private System.Windows.Forms.Button btn_Product_Mng;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button tabHome;
        private System.Windows.Forms.Button tabCilentMng;
        private System.Windows.Forms.Button btn_Sample1;
    }
}

