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
    /// Логика взаимодействия для Task10Page.xaml
    /// </summary>
    public partial class Task10Page : Page
    {
        public Task10Page()
        {
            InitializeComponent();
        }
        public int Constant;
        private void BtnTask10_Click(object sender, RoutedEventArgs e)
        {
            int[,] mas = new int[5, 10];
            int t1 = 0, t2 = 0;
            Random rnd = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(0, 100);
                }
            }
            bool k = false;
            int n = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int a = mas[i, j];
                    int b = mas[i, j + 1];
                    if (a < b)
                    {
                        k = true;
                    }
                    else k = false;
                }
                if (k == true)
                    n++;
            }
            Constant = n;
            Window10 win1 = new Window10(Constant);
            win1.Show();

        }
    }
}
