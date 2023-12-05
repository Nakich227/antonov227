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

namespace antonov227
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(TbNumberA.Text);
            double g = Convert.ToDouble(TbNumberB.Text);
            double y = x + Math.Sqrt(Math.Abs(1 - x * x));
            double z = Math.Pow(Math.Sin(x+g),2)+(Math.Cos(x)/(x+Math.Pow(y,2)*Math.Log(Math.Abs(x-y))));
            TextBlockAnswer.Text = $"Ответ:\n z = {z}";
        }
    }
}
