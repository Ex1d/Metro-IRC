using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Threading.Tasks;

namespace _20140731IRC_PRE
{
    public partial class MainWindow : MetroWindow
    {
        MetroDialogSettings mDialog = null;

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var x = await this.ShowInputAsync("커밋!!", "안녕?");
            // 4.0이라 ASYNC가 없네 잠만영
            MessageBox.Show(x);
            //this.("안녕", "안녕", MessageDialogStyle.AffirmativeAndNegative, mDialog);
        }

        private void MetroWindow_Loaded_1(object sender, RoutedEventArgs e)
        {
            this.mDialog = new MetroDialogSettings();
            mDialog.AffirmativeButtonText = "확인";
            mDialog.NegativeButtonText = "취소";
        }
    }
}
