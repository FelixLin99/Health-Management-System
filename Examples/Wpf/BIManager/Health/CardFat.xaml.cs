using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Wpf.Annotations;

namespace Wpf
{
    /// <summary>
    /// 体脂率信息卡片
    /// </summary>
    public partial class CardFat : UserControl
    {
        public CardFat()
        {
            InitializeComponent();
            Value = "20";
            DataContext = this;
        }

        public string Value { get; set; }
    }
}
