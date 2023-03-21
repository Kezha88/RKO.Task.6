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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RKO.Task._6.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }
        public int Constant;
        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            int A = Convert.ToInt32(TbA.Text);

            Constant = A;
            Window1 win1 = new Window1(Constant);
            win1.Show();
        }
    }
}
