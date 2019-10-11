using NoLibrary.ViewModels;
using System;
using System.Windows.Controls;

namespace NoLibrary.Views
{
    /// <summary>
    /// DateTimeControl.xaml の相互作用ロジック
    /// </summary>
    public partial class DateTimeControl : UserControl
    {
        public DateTimeControl(DateTime time)
        {
            DataContext = new DateTimeControlViewModel(time);
            InitializeComponent();
        }
    }
}
