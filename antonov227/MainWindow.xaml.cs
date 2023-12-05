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
            double v1 = Convert.ToDouble(TbNumberA.Text);
            double v2 = Convert.ToDouble(TbNumberB.Text);
            double s = Convert.ToDouble(TbNumberB.Text);
            double t = Convert.ToDouble(TbNumberB.Text);
            double s2 = Math.Abs(s - t * (v1 + v2));
            TextBlockAnswer.Text = $"Ответ:\n расстояние между ними = {s2}";
        }
    }
}
