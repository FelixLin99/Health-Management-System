using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIManager
{
    /// <summary>
    /// 用户健康数据
    /// </summary>
    public partial class FBodyData : UITitlePage
    {
        public FBodyData()
        {
            InitializeComponent();
            // 若用户没填健康信息，则展示默认值
            Wpf.CardHeight cardHeight = new Wpf.CardHeight();
            Wpf.CardWeight cardWeight = new Wpf.CardWeight();
            Wpf.CardFat cardFat = new Wpf.CardFat();
            if (Program.userCurrHealth != null)
            {
                cardHeight.Value = Program.userCurrHealth.height.ToString();
                cardWeight.Value = Program.userCurrHealth.weight.ToString();
                cardFat.Value = Program.userCurrHealth.fatRate.ToString();
            }
            //else
            //{
            //    MessageBox.Show("请填写身体指标");
            //}

            this.elementHost1.Child = cardHeight;
            this.elementHost2.Child = cardWeight;
            this.elementHost3.Child = cardFat;


        }

        private void uiButton16_Click(object sender, EventArgs e)
        {
            FBodyEdit fBodyEdit = new FBodyEdit();
            fBodyEdit.ShowDialog();
            Program.fBmi.GetData();
            this.elementHost1.Child = new Wpf.CardHeight() { Value = Program.userCurrHealth.height.ToString() };
            this.elementHost2.Child = new Wpf.CardWeight() { Value = Program.userCurrHealth.weight.ToString() };
            this.elementHost3.Child = new Wpf.CardFat() { Value = Program.userCurrHealth.fatRate.ToString() };
        }

        private void PagePanel_Click(object sender, EventArgs e)
        {

        }

        public void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
        
    }
}
