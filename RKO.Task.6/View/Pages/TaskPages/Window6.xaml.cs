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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        private int Constant;
        public Window6(int variable)
        {
            InitializeComponent();
            Constant = variable;
            TbA.Text = ($"{variable}");
        }

        private void Btn101_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
