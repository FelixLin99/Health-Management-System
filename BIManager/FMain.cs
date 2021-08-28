using Sunny.UI;
using System;
using System.Windows.Forms;

namespace BIManager
{
    public partial class FMain : UIHeaderAsideMainFrame
    {
        public FMain()
        {
            //运动消耗实时窗体
            Program.fConsume = new FConsume();
            //运动特点分析实时窗体
            Program.fDistribution = new FDistribution();
            //机能指数实时窗体
            Program.fPai = new FPai();

            //添加饮食实时窗体
            Program.fAddDite = new FAddDite();
            //摄入与消耗实时窗体
            Program.fNutri = new FNutri();
            //营养结构实时窗体
            Program.fConstru = new FConstru();
            //饮食特点分析实时窗体
            Program.fDiteRecom = new FDiteRecom();

            //BMI实时窗体
            Program.fBmi = new FBmi();
            //健康计划实时窗体
            Program.fPlan = new FPlan();
            //徽章实时窗体
            Program.fMetal = new FMetal();
            InitializeComponent();
            

            int pageIndex = 1000;
            Header.SetNodePageIndex(Header.Nodes[0], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[0], 61923);
            TreeNode parent = Aside.CreateNode("运动", 61923, 24, pageIndex);
            //通过设置PageIndex关联
            Aside.CreateChildNode(parent, 61543, 24, AddPage(new FAddSport(), ++pageIndex));
            Aside.CreateChildNode(parent, 61568, 24, AddPage(Program.fConsume, ++pageIndex));
            Aside.CreateChildNode(parent, 62056, 24, AddPage(Program.fDistribution, ++pageIndex));
            Aside.CreateChildNode(parent, 61953, 24, AddPage(Program.fPai, ++pageIndex));
            // Aside.SetNodeTipsText(parent.Nodes[0], "1");

            pageIndex = 2000;
            Header.SetNodePageIndex(Header.Nodes[1], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[1], 61685);
            parent = Aside.CreateNode("饮食", 61685, 24, pageIndex);
            //通过设置GUID关联，节点字体图标和大小由UIPage设置
            Aside.CreateChildNode(parent, 61543, 24, AddPage(Program.fAddDite, Guid.NewGuid()));
            Aside.CreateChildNode(parent, 61568, 24, AddPage(Program.fNutri, Guid.NewGuid()));
            Aside.CreateChildNode(parent, 61568, 24, AddPage(Program.fConstru, Guid.NewGuid()));
            Aside.CreateChildNode(parent, 61638, 24, AddPage(Program.fDiteRecom, Guid.NewGuid()));

            pageIndex = 3000;
            Header.SetNodePageIndex(Header.Nodes[2], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[2], 61680);
            parent = Aside.CreateNode("健康", 61680, 24, pageIndex);
            //直接关联（默认自动生成GUID）
            Aside.CreateChildNode(parent, 62104, 24, AddPage(new FBodyData(), Guid.NewGuid()));
            Aside.CreateChildNode(parent, 61953, 24, AddPage(Program.fBmi, Guid.NewGuid()));
            Aside.CreateChildNode(parent, 61555, 24, AddPage(Program.fPlan, Guid.NewGuid()));
            Aside.CreateChildNode(parent, 61445, 24, AddPage(Program.fMetal, ++pageIndex));

            Header.SetNodeSymbol(Header.Nodes[3], 61502);
            var styles = UIStyles.PopularStyles();
            foreach (UIStyle style in styles)
            {
                Header.CreateChildNode(Header.Nodes[3], style.DisplayText(), style.Value());
            }

            Aside.SelectFirst();

            
        }

        private void Header_MenuItemClick(string text, int menuIndex, int pageIndex)
        {
            switch (menuIndex)
            {
                case 0:
                case 1:
                case 2:
                    Aside.SelectPage(pageIndex);
                    break;

                case 3:
                    UIStyle style = (UIStyle)pageIndex;
                    StyleManager.Style = style;
                    break;
            }
        }

        private void FMain_Selecting(object sender, TabControlCancelEventArgs e, UIPage page)
        {
            page?.Text.ConsoleWriteLine();
        }

        // 修改密码入口
        private void ItmModifyPwd_Click(object sender, EventArgs e)
        {
            FModifyPwd objPwd = new FModifyPwd();
            objPwd.ShowDialog();
        }

        // 切换账号
        private void ItmLogoutPwd_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("确定切换账号吗？", "切换账号", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //关闭主界面
                this.Hide();
                //显示登录窗体
                FLogin objFLogin = new FLogin();
                DialogResult reuslt = objFLogin.ShowDialog();


                //判断登录是否成功
                if (reuslt == DialogResult.OK)
                {
                    FMain fMain = new FMain();
                    fMain.ShowDialog();
                }  
                else
                    Application.Exit();//退出整个应用程序
            }
            else { return; }
            
        }

        private void Aside_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {

        }
    }
}
