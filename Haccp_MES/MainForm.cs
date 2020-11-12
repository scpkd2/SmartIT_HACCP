using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using Haccp_MES._3_production;
using Haccp_MES._2_management;
using Haccp_MES._1_information;

namespace Haccp_MES
{
    public partial class MainForm : Form //동욱이의 만행
    {
        
        public MainForm()
        {
            Thread tr = new Thread(new ThreadStart(show_SplashForm));
            tr.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            tr.Abort();
            CustomizeDesign();
            HideTabbarButton();
            #region 시간표시용 타이머
            timer1.Start();
            timer1.Interval = 1000;
          #endregion
        }

        #region 실행파일 구동 시 가장 먼저 나타나는 화면
        /// <summary>
        /// 프로그램 구동시 있어보이려고 만든 기능
        /// </summary>
        public void show_SplashForm()
        {
            Application.Run(new Splash_Form());
        }
        #endregion

        private void CustomizeDesign()
        {
            panelMES_info_SubMenu.Visible = false;  // 기준정보 서브메뉴 패널창
            panelOpt_SubMenu.Visible = false;      // 운영관리 서브메뉴 패널창
            panelProdt_SubMenu.Visible = false;    // 생산관리 서브메뉴 패널창
        }

        #region 서브메뉴 열고닫기
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)  // 패널창이 닫혀있으면
            {
                subMenu.Visible = true;   // OPEN
            }
            else
                subMenu.Visible = false; // CLOSE

        }

        private void btn_Std_Info_Click(object sender, EventArgs e) // 기준정보버튼
        {
            ShowSubMenu(panelMES_info_SubMenu); // 클릭시 서브메뉴 보여주기
        }

        private void btn_Opt_Mng_Click(object sender, EventArgs e) // 영업관리버튼
        {
            ShowSubMenu(panelOpt_SubMenu);  
        }

        private void btn_Product_Mng_Click(object sender, EventArgs e) // 생산관리버튼
        {
            ShowSubMenu(panelProdt_SubMenu);
        }

        #endregion

        #region 자식폼 열기
        private Form activeForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            //if (activeForm != null)
            //{
            //    activeForm.Close();
            //}
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            ChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            
        }
        #endregion

        #region 하단 시간표시
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortTimeString();
        }
        #endregion

        #region 기준정보 서브메뉴 TEXT COLOR 변경
        /// <summary>
        /// 기준정보 각 메뉴 클릭하면 글자색상 바뀌게 하는 함수입니다.
        /// </summary>
        /// <param name="btn"></param>
        private void btnColorChange_StdInfo(Button btn)
        {
            #region 기준정보 메뉴 제목 컬러 OFF
            if (btn_Clinet_Mng.ForeColor == System.Drawing.Color.Crimson)
                btn_Clinet_Mng.ForeColor = System.Drawing.Color.LightGray;
            if (btn_Prodt_Mng.ForeColor == System.Drawing.Color.Crimson)
                btn_Prodt_Mng.ForeColor = System.Drawing.Color.LightGray;
            if (btn_Storg_Mng.ForeColor == System.Drawing.Color.Crimson)
                btn_Storg_Mng.ForeColor = System.Drawing.Color.LightGray;
            if (btn_ProcessMng.ForeColor == System.Drawing.Color.Crimson)
                btn_ProcessMng.ForeColor = System.Drawing.Color.LightGray;
            #endregion

            if (btn.ForeColor == System.Drawing.Color.LightGray)
                btn.ForeColor = System.Drawing.Color.Crimson;
        }
        #endregion

        #region 영업관리 서브메뉴 TEXT COLOR 변경
        /// <summary>
        /// 영업관리의 각 메뉴를 클릭하면 글자색 바뀌게 하는 함수입니다.
        /// </summary>
        /// <param name="btn"></param>
        private void btnColorChange_OptInfo(Button btn)
        {
            #region 영업관리 메뉴 제목 컬러 OFF
            if (btn_Input_Item_Mng.ForeColor == System.Drawing.Color.Crimson)
                btn_Input_Item_Mng.ForeColor = System.Drawing.Color.LightGray;
            if (btn_Out_item_Mng.ForeColor == System.Drawing.Color.Crimson)
                btn_Out_item_Mng.ForeColor = System.Drawing.Color.LightGray;
            if (btn_Inventory_Trend.ForeColor == System.Drawing.Color.Crimson)
                btn_Inventory_Trend.ForeColor = System.Drawing.Color.LightGray;
            if (btn_Inven_Matching.ForeColor == System.Drawing.Color.Crimson)
                btn_Inven_Matching.ForeColor = System.Drawing.Color.LightGray;
            #endregion

            if (btn.ForeColor == System.Drawing.Color.LightGray)
                btn.ForeColor = System.Drawing.Color.Crimson;
        }
        #endregion

        #region 생산관리 서브메뉴 TEXT COLOR 변경
        /// <summary>
        /// 생산관리의 각 메뉴를 클릭하면 글자색 바뀌게 하는 함수입니다.
        /// </summary>
        /// <param name="btn"></param>
        private void btnColorChange_ProdtMng(Button btn)
        {
            #region 생산관리 메뉴 제목 컬러 OFF
            if (btn_Work_CMD.ForeColor == System.Drawing.Color.Crimson)
                btn_Work_CMD.ForeColor = System.Drawing.Color.LightGray;
            if (btn_Result_Mng.ForeColor == System.Drawing.Color.Crimson)
                btn_Result_Mng.ForeColor = System.Drawing.Color.LightGray;
            if (btn_Time_Trend.ForeColor == System.Drawing.Color.Crimson)
                btn_Time_Trend.ForeColor = System.Drawing.Color.LightGray;
            #endregion

            if (btn.ForeColor == System.Drawing.Color.LightGray)
                btn.ForeColor = System.Drawing.Color.Crimson;
        }
        #endregion

        #region 상단 tab버튼 숨기기
        private void HideTabbarButton( )
        {
            tabHome.Visible = false;  //홈
            
            tabCilentMng.Visible = false; // 거래처관리
            tabItemInFoMng.Visible = false;  // 품목정보관리
            tabWHSmng.Visible = false;  // 보관창고관리
            tabProcess.Visible = false; // 공정관리

            tabitem_Input_mng.Visible = false; // 품목입고관리
            tabOutputProduct.Visible = false; // 제품출고관리
            tabStockState.Visible = false; // 품목재고현황
            tabRealSTKing.Visible = false;  // 품목창고실사

            tabWorkOder.Visible = false; // 작업지시등록
            tabPerformanceMng.Visible = false; // 생산실적관리
            tabProdTrend.Visible = false;  //기간별 생산현황
        }
        #endregion

        #region 탭버튼 활성화
        private void tabBtnActiveOn(Button tbtn)
        {
            if (tbtn.Visible == false)
            tbtn.Visible = true;  // 일단 탭버튼 보여주고

            #region 활성화된 탭버튼 끄기
            if (tabHome.BackColor == Color.Crimson) //홈
                tabHome.BackColor = Color.Transparent;

            if (tabCilentMng.BackColor == Color.Crimson)       // 거래처관리탭
                tabCilentMng.BackColor = Color.Transparent; 
            if (tabItemInFoMng.BackColor == Color.Crimson)     // 품목정보관리탭
                tabItemInFoMng.BackColor = Color.Transparent;
            if (tabWHSmng.BackColor == Color.Crimson)          // 보관창고관리탭
                tabWHSmng.BackColor = Color.Transparent;
            if (tabProcess.BackColor == Color.Crimson)        // 공정관리탭
                tabProcess.BackColor = Color.Transparent;

            if (tabitem_Input_mng.BackColor == Color.Crimson)      // 품목입고관리탭
                tabitem_Input_mng.BackColor = Color.Transparent;
            if (tabOutputProduct.BackColor == Color.Crimson)       // 제품출고관리탭
                tabOutputProduct.BackColor = Color.Transparent;
            if (tabStockState.BackColor == Color.Crimson)          // 품목재고현황탭
                tabStockState.BackColor = Color.Transparent;
            if (tabRealSTKing.BackColor == Color.Crimson)          // 품목창고실사탭
                tabRealSTKing.BackColor = Color.Transparent;

            if (tabWorkOder.BackColor == Color.Crimson)          // 작업지시등록탭
                tabWorkOder.BackColor = Color.Transparent;
            if (tabPerformanceMng.BackColor == Color.Crimson)    // 생산실적관리탭
                tabPerformanceMng.BackColor = Color.Transparent;
            if (tabProdTrend.BackColor == Color.Crimson)         // 기간별생산현황탭  
                tabProdTrend.BackColor = Color.Transparent;

            #endregion

            if (tbtn.BackColor == Color.Transparent)
            {
                tbtn.BackColor = Color.Crimson;
            }

        }
        #endregion

        #region HOME 버튼
        private void btn_Home_Click(object sender, EventArgs e)
        {
            tabBtnActiveOn(tabHome);
            OpenChildForm(new Home());
          
        }
        #endregion

        #region MES 기준정보 메뉴버튼

        // 거래처 관리버튼
        private void btn_Clinet_Mng_Click(object sender, EventArgs e)
        {
            btnColorChange_StdInfo(btn_Clinet_Mng);
            tabBtnActiveOn(tabCilentMng);
            OpenChildForm(new info_1_1_accountmng());

        }

        //품목 정보 관리버튼
        private void btn_Prodt_Mng_Click(object sender, EventArgs e)
        {
          
            btnColorChange_StdInfo(btn_Prodt_Mng);
            tabBtnActiveOn(tabItemInFoMng);
            OpenChildForm(new info_2_itemMng());

        }

        // 보관창고관리버튼
        private void btn_Storg_Mng_Click(object sender, EventArgs e)
        {
            btnColorChange_StdInfo(btn_Storg_Mng);
            tabBtnActiveOn(tabWHSmng);
            OpenChildForm(new info_3_WareHouseMng());

        }

        // 공정관리 버튼
        private void btn_ProcessMng_Click(object sender, EventArgs e)
        {
            btnColorChange_StdInfo(btn_ProcessMng);
            tabBtnActiveOn(tabProcess);
        }

        #endregion

        #region 영업관리 메뉴버튼

        // 품목입고관리 버튼
        private void btn_Input_Item_Mng_Click(object sender, EventArgs e)
        {
            btnColorChange_OptInfo(btn_Input_Item_Mng);
            tabBtnActiveOn(tabitem_Input_mng);
            OpenChildForm(new mngmnt_1_inputProduct());
        }

        // 제품출고관리 버튼
        private void btn_Out_item_Mng_Click(object sender, EventArgs e)
        {
            btnColorChange_OptInfo(btn_Out_item_Mng);
            tabBtnActiveOn(tabOutputProduct);
            OpenChildForm(new mngmnt_2_outputProduct());
        }

        // 품목재고현황 버튼
        private void btn_Inventory_Trend_Click(object sender, EventArgs e)
        {
            btnColorChange_OptInfo(btn_Inventory_Trend);
            tabBtnActiveOn(tabStockState);
            OpenChildForm(new mngmnt_3_StockState());
        }

        // 품목창고실사 버튼
        private void btn_Inven_Matching_Click(object sender, EventArgs e)
        {
            btnColorChange_OptInfo(btn_Inven_Matching);
            tabBtnActiveOn(tabRealSTKing);
            OpenChildForm(new mngmnt_4_RealStockTaking());
        }
        #endregion

        #region 생산관리 메뉴버튼

        //작업지시등록 버튼
        private void btn_Work_CMD_Click(object sender, EventArgs e)
        {
            btnColorChange_ProdtMng(btn_Work_CMD);
            tabBtnActiveOn(tabWorkOder);
            OpenChildForm(new Prod_1_WorkOrders());

        }

        //생산실적관리 버튼
        private void btn_Result_Mng_Click(object sender, EventArgs e)
        {
            btnColorChange_ProdtMng(btn_Result_Mng);
            tabBtnActiveOn(tabPerformanceMng);
            OpenChildForm(new Prod_2_PerformanceMng());
        }

        //기관별생산현황 버튼
        private void btn_Time_Trend_Click(object sender, EventArgs e)
        {
            btnColorChange_ProdtMng(btn_Time_Trend);
            tabBtnActiveOn(tabProdTrend);
            OpenChildForm(new Prod_3_Production_Trend());
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            tabBtnActiveOn(tabHome);
            OpenChildForm(new Home());
        }

        #region 상단 탭메뉴 버튼 관련

        //거래처관리 탭버튼
        private void tabCilentMng_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 마우스 좌클릭이면
            {     
                tabBtnActiveOn(tabCilentMng);

                // 패널 위에 열려있는 폼들 중에서 이름이 info_1_1_accountmng인 화면을 가장 앞으로 가져온다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "info_1_1_accountmng")
                    {
                        item.BringToFront();
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)  // 마우스 우클릭이면
            {
                // 패널에 추가된 여러 폼중에서 이름이 info_1-1_accountmng인 것을 찾아내 지운다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "info_1_1_accountmng")
                        panelChildForm.Controls.Remove(item);
                }

                tabCilentMng.Visible = false; // 상단 거래처 관리 탭버튼 비활성화
            }
        }

        // HOME 화면 탭버튼
        private void tabHome_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 마우스 좌클릭하면
            {
                tabBtnActiveOn(tabHome);  // 상단 HOME 메뉴버튼 활성화하고

                // 패널 위에 열려있는 폼들 중에서 이름이 Home인 화면을 가장 앞으로 가져온다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "Home")
                    {
                        item.BringToFront();
                    }
                }

            }
            else if (e.Button == MouseButtons.Right)  // 마우스 우클릭하면
            {
                // 패널에 추가된 여러 폼중에서 이름이 Home인것을 찾아내 지운다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "Home")
                        panelChildForm.Controls.Remove(item);
                }
               
                tabHome.Visible = false; // 상단 HOME 탭버튼 비활성화
            }
        }

        //품목정보관리 탭버튼
        private void tabItemInFoMng_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 마우스 좌클릭하면
            {
                tabBtnActiveOn(tabItemInFoMng);  // 상단 품목정보관리 메뉴버튼 활성화하고

                // 패널 위에 열려있는 폼들 중에서 이름이 info_2_itemMng인 화면을 가장 앞으로 가져온다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "info_2_itemMng")
                    {
                        item.BringToFront();
                    }
                }

            }
            else if (e.Button == MouseButtons.Right)  // 마우스 우클릭하면
            {
                // 패널에 추가된 여러 폼중에서 이름이 info_2_itemMng인것을 찾아내 지운다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "info_2_itemMng")
                        panelChildForm.Controls.Remove(item);
                }

                tabItemInFoMng.Visible = false; // 상단 품목정보관리 탭버튼 비활성화
            }
        }
      
        //보관창고관리 탭버튼
        private void tabWHSmng_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 마우스 좌클릭하면
            {
                tabBtnActiveOn(tabWHSmng);  // 상단 보관창고관리 메뉴버튼 활성화하고

                // 패널 위에 열려있는 폼들 중에서 이름이 info_3_WareHouseMng인 화면을 가장 앞으로 가져온다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "info_3_WareHouseMng")
                    {
                        item.BringToFront();
                    }
                }

            }
            else if (e.Button == MouseButtons.Right)  // 마우스 우클릭하면
            {
                // 패널에 추가된 여러 폼중에서 이름이 info_3_WareHouseMng인것을 찾아내 지운다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "info_3_WareHouseMng")
                        panelChildForm.Controls.Remove(item);
                }

                tabWHSmng.Visible = false; // 상단 품목정보관리 탭버튼 비활성화
            }
        }
        
        //공정관리 탭버튼
        private void tabProcess_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 마우스 좌클릭하면
            {
                tabBtnActiveOn(tabProcess);  // 상단 공정관리 메뉴버튼 활성화하고

                // 패널 위에 열려있는 폼들 중에서 이름이 info_4_ProcessMng인 화면을 가장 앞으로 가져온다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "info_4_ProcessMng")
                    {
                        item.BringToFront();
                    }
                }

            }
            else if (e.Button == MouseButtons.Right)  // 마우스 우클릭하면
            {
                // 패널에 추가된 여러 폼중에서 이름이 info_4_ProcessMng인것을 찾아내 지운다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "info_4_ProcessMng")
                        panelChildForm.Controls.Remove(item);
                }

                tabProcess.Visible = false; // 상단 공정관리 탭버튼 비활성화
            }
        }

        // 품목입고관리 탭버튼
        private void tabitem_Input_mng_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 마우스 좌클릭하면
            {
                tabBtnActiveOn(tabitem_Input_mng);

                // 패널 위에 열려있는 폼들 중에서 이름이 mngmnt_1_inputProduct인 화면을 가장 앞으로 가져온다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {

                    if (item.Name == "mngmnt_1_inputProduct")
                    {
                        item.BringToFront();
                    }
                }

            }
            else if (e.Button == MouseButtons.Right)  // 마우스 우클릭하면
            {
                // 패널에 추가된 여러 폼중에서 이름이 mngmnt_1_inputProduct인것을 찾아내 지운다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "mngmnt_1_inputProduct")
                        panelChildForm.Controls.Remove(item);
                }

                tabitem_Input_mng.Visible = false; // 상단 품목입고관리 탭버튼 비활성화
            }
        }

        // 제품출고관리 탭버튼
        private void tabOutputProduct_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 마우스 좌클릭하면
            {
                tabBtnActiveOn(tabOutputProduct);

                // 패널 위에 열려있는 폼들 중에서 이름이 mngmnt_2_outputProduct인 화면을 가장 앞으로 가져온다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {

                    if (item.Name == "mngmnt_2_outputProduct")
                    {
                        item.BringToFront();
                    }
                }

            }
            else if (e.Button == MouseButtons.Right)  // 마우스 우클릭하면
            {
                // 패널에 추가된 여러 폼중에서 이름이 mngmnt_2_outputProduct인것을 찾아내 지운다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "mngmnt_2_outputProduct")
                        panelChildForm.Controls.Remove(item);
                }

                tabOutputProduct.Visible = false; // 상단 품목입고관리 탭버튼 비활성화
            }
        }

        // 품목재고현황 탭버튼
        private void tabStockState_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 마우스 좌클릭하면
            {
                tabBtnActiveOn(tabStockState);

                // 패널 위에 열려있는 폼들 중에서 이름이 mngmnt_3_StockState인 화면을 가장 앞으로 가져온다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {

                    if (item.Name == "mngmnt_3_StockState")
                    {
                        item.BringToFront();
                    }
                }

            }
            else if (e.Button == MouseButtons.Right)  // 마우스 우클릭하면
            {
                // 패널에 추가된 여러 폼중에서 이름이 mngmnt_3_StockState인것을 찾아내 지운다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "mngmnt_3_StockState")
                        panelChildForm.Controls.Remove(item);
                }

                tabStockState.Visible = false; // 상단 품목재고현황 탭버튼 비활성화
            }
        }

        // 품목창고실사 탭버튼
        private void tabRealSTKing_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 마우스 좌클릭하면
            {
                tabBtnActiveOn(tabRealSTKing);

                // 패널 위에 열려있는 폼들 중에서 이름이 mngmnt_4_RealStockTaking인 화면을 가장 앞으로 가져온다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {

                    if (item.Name == "mngmnt_4_RealStockTaking")
                    {
                        item.BringToFront();
                    }
                }

            }
            else if (e.Button == MouseButtons.Right)  // 마우스 우클릭하면
            {
                // 패널에 추가된 여러 폼중에서 이름이 mngmnt_4_RealStockTaking인것을 찾아내 지운다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "mngmnt_4_RealStockTaking")
                        panelChildForm.Controls.Remove(item);
                }

                tabRealSTKing.Visible = false; // 상단 품목창고실사 탭버튼 비활성화
            }
        }

        //작업지시등록 탭버튼
        private void tabWorkOder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 마우스 좌클릭하면
            {
                tabBtnActiveOn(tabWorkOder);

                // 패널 위에 열려있는 폼들 중에서 이름이 Prod_1_WorkOrders인 화면을 가장 앞으로 가져온다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {

                    if (item.Name == "Prod_1_WorkOrders")
                    {
                        item.BringToFront();
                    }
                }

            }
            else if (e.Button == MouseButtons.Right)  // 마우스 우클릭하면
            {
                // 패널에 추가된 여러 폼중에서 이름이 Prod_1_WorkOrders인것을 찾아내 지운다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "Prod_1_WorkOrders")
                        panelChildForm.Controls.Remove(item);
                }

                tabWorkOder.Visible = false; // 상단 작업지시등록 탭버튼 비활성화
            }
        }

        //생산실적관리 탭버튼
        private void tabPerformanceMng_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 마우스 좌클릭하면
            {
                tabBtnActiveOn(tabPerformanceMng);

                // 패널 위에 열려있는 폼들 중에서 이름이 Prod_2_PerformanceMng인 화면을 가장 앞으로 가져온다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {

                    if (item.Name == "Prod_2_PerformanceMng")
                    {
                        item.BringToFront();
                    }
                }

            }
            else if (e.Button == MouseButtons.Right)  // 마우스 우클릭하면
            {
                // 패널에 추가된 여러 폼중에서 이름이 Prod_2_PerformanceMng인것을 찾아내 지운다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "Prod_2_PerformanceMng")
                        panelChildForm.Controls.Remove(item);
                }

                tabPerformanceMng.Visible = false; // 상단 생산실적관리 탭버튼 비활성화
            }
        }

        //기간별 생산현황 탭버튼
        private void tabProdTrend_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 마우스 좌클릭하면
            {
                tabBtnActiveOn(tabProdTrend);

                // 패널 위에 열려있는 폼들 중에서 이름이 Prod_3_Production_Trend인 화면을 가장 앞으로 가져온다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {

                    if (item.Name == "Prod_3_Production_Trend")
                    {
                        item.BringToFront();
                    }
                }

            }
            else if (e.Button == MouseButtons.Right)  // 마우스 우클릭하면
            {
                // 패널에 추가된 여러 폼중에서 이름이 Prod_3_Production_Trend인것을 찾아내 지운다.
                foreach (Control item in panelChildForm.Controls.OfType<Form>())
                {
                    if (item.Name == "Prod_3_Production_Trend")
                        panelChildForm.Controls.Remove(item);
                }

                tabProdTrend.Visible = false; // 상단 기간별생산현황 탭버튼 비활성화
            }
        }

        #endregion
    }

}
