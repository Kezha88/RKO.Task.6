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
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        private int Constant1, Constant2;
        public Window7(int variable1, int variable2)
        {
            InitializeComponent();
            Constant1 = variable1;
            Constant2 = variable2;
            TbA.Text = ($"{variable1} {variable2}");
        }

        private void Btn101_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
