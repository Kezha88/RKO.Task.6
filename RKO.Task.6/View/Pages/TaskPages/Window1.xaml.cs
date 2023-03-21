using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private int Constant;
        public Window1(int variable)
        {
            InitializeComponent();
            Constant = variable;
            TbA.Text = ($"{variable}");
        }

        private void Btn101_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
