using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Haccp_MES
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
            HideTabbarButton();
          #region 시간표시용 타이머
            timer1.Start();
            timer1.Interval = 1000;
          #endregion
        }

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
            if(activeForm != null)
            {
                activeForm.Close();
            }
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
            if (btn_Sample1.ForeColor == System.Drawing.Color.Crimson)
                btn_Sample1.ForeColor = System.Drawing.Color.LightGray;
            if (btn_Sample2.ForeColor == System.Drawing.Color.Crimson)
                btn_Sample2.ForeColor = System.Drawing.Color.LightGray;
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
            if (btn_Prodt_In_Trend.ForeColor == System.Drawing.Color.Crimson)
                btn_Prodt_In_Trend.ForeColor = System.Drawing.Color.LightGray;
            if (btn_Prodt_Out_Trend.ForeColor == System.Drawing.Color.Crimson)
                btn_Prodt_Out_Trend.ForeColor = System.Drawing.Color.LightGray;
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
            if (btn_Prodt_Plan.ForeColor == System.Drawing.Color.Crimson)
                btn_Prodt_Plan.ForeColor = System.Drawing.Color.LightGray;
            if (btn_Work_CMD.ForeColor == System.Drawing.Color.Crimson)
                btn_Work_CMD.ForeColor = System.Drawing.Color.LightGray;
            if (btn_Result_Mng.ForeColor == System.Drawing.Color.Crimson)
                btn_Result_Mng.ForeColor = System.Drawing.Color.LightGray;
            if (btn_defect_Mng.ForeColor == System.Drawing.Color.Crimson)
                btn_defect_Mng.ForeColor = System.Drawing.Color.LightGray;
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
            tabHome.Visible = false;
            tabCilentMng.Visible = false;
        }
        #endregion

        #region 탭버튼 활성화
        private void tabBtnActiveOn(Button tbtn)
        {
            tbtn.Visible = true;  // 일단 탭버튼 보여주고

            #region 활성화된 탭버튼 끄기
            if (tabHome.BackColor == Color.Teal)
                tabHome.BackColor = Color.Transparent;
            if (tabCilentMng.BackColor == Color.Teal)
                tabCilentMng.BackColor = Color.Transparent;
            #endregion

            if (tbtn.BackColor == Color.Transparent)
            {
                tbtn.BackColor = Color.Teal;
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
        // 고객사 관리버튼
        private void btn_Clinet_Mng_Click(object sender, EventArgs e)
        {
            btnColorChange_StdInfo(btn_Clinet_Mng);
            tabBtnActiveOn(tabCilentMng);            

        }

        //품목관리버튼
        private void btn_Prodt_Mng_Click(object sender, EventArgs e)
        {
          
            btnColorChange_StdInfo(btn_Prodt_Mng);
        }

        // 보관창고관리버튼
        private void btn_Storg_Mng_Click(object sender, EventArgs e)
        {
            btnColorChange_StdInfo(btn_Storg_Mng);
        }

        // Sample1 버튼
        private void btn_Sample1_Click(object sender, EventArgs e)
        {
            btnColorChange_StdInfo(btn_Sample1);
        }

        // Sample2 버튼
        private void btn_Sample2_Click(object sender, EventArgs e)
        {
            btnColorChange_StdInfo(btn_Sample2);
        }
        #endregion

        #region 영업관리 메뉴버튼
        // 품목 입고등록 버튼
        private void btn_Input_Item_Mng_Click(object sender, EventArgs e)
        {
            btnColorChange_OptInfo(btn_Input_Item_Mng);
        }

        // 품목 출하등록 버튼
        private void btn_Out_item_Mng_Click(object sender, EventArgs e)
        {
            btnColorChange_OptInfo(btn_Out_item_Mng);
        }

        // 제품 입고현황 버튼
        private void btn_Prodt_In_Trend_Click(object sender, EventArgs e)
        {
            btnColorChange_OptInfo(btn_Prodt_In_Trend);
        }

        // 제품출하현황 버튼
        private void btn_Prodt_Out_Trend_Click(object sender, EventArgs e)
        {
            btnColorChange_OptInfo(btn_Prodt_Out_Trend);
        }

        // 제품 재고현황 버튼
        private void btn_Inventory_Trend_Click(object sender, EventArgs e)
        {
            btnColorChange_OptInfo(btn_Inventory_Trend);
        }

        // 창고 실사정리 버튼
        private void btn_Inven_Matching_Click(object sender, EventArgs e)
        {
            btnColorChange_OptInfo(btn_Inven_Matching);
        }



        #endregion

        #region 생산관리 메뉴버튼

        //생산계획등록 버튼
        private void btn_Prodt_Plan_Click(object sender, EventArgs e)
        {
            btnColorChange_ProdtMng(btn_Prodt_Plan);
        }

        //작업지시등록 버튼
        private void btn_Work_CMD_Click(object sender, EventArgs e)
        {
            btnColorChange_ProdtMng(btn_Work_CMD);
        }

        //생산실적관리 버튼
        private void btn_Result_Mng_Click(object sender, EventArgs e)
        {
            btnColorChange_ProdtMng(btn_Result_Mng);
        }

        //불량유형관리 버튼
        private void btn_defect_Mng_Click(object sender, EventArgs e)
        {
            btnColorChange_ProdtMng(btn_defect_Mng);
        }

        //기관별생산현황 버튼
        private void btn_Time_Trend_Click(object sender, EventArgs e)
        {
            btnColorChange_ProdtMng(btn_Time_Trend);
        }


        #endregion


        //HOME 탭버튼
        private void tabHome_Click(object sender, EventArgs e)
        {
            tabBtnActiveOn(tabHome);
        }

        //고객사 관리 탭버튼
        private void tabCilentMng_Click(object sender, EventArgs e)
        {
            tabBtnActiveOn(tabCilentMng);
        }
    }

}
