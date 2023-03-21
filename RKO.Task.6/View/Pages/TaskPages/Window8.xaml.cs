using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RKO.Task._6.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        private int Constant1, Constant2, Constant3, Constant4, Constant5, Constant6, Constant7, Constant8, Constant9;
        public Window8(int variable1, int variable2, int variable3, int variable4, int variable5, int variable6, int variable7, int variable8, int variable9)
        {
            InitializeComponent();
            Constant1 = variable1;
            Constant2 = variable2;
            Constant3 = variable3;
            Constant4 = variable4;
            Constant5 = variable5;
            Constant6 = variable6;
            Constant7 = variable7;
            Constant8 = variable8;
            Constant9 = variable9;
            TbA.Text = ($"{variable1}, {variable2}, {variable3},\n{variable4}, {variable5}, {variable6},\n{variable7}, {variable8}, {variable9}");
        }
        private void Btn101_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
