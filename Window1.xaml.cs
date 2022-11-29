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

namespace lab6
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            Close();
            
        }

        private void AboutProgramClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Использовать класс Pair (пара четных чисел).\nОпределить производный класс треугольник RightAngled с полями-катетами.\nОпределить методы вычисления гипотенузы и площади треугольника.\nСоздатель: Халимов Виктор.");
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void HypotenuseCountClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int fc = Convert.ToInt32(FirstCathet.Text);
                int sc = Convert.ToInt32(SecondCathet.Text);
                RightAngled cathets = new(fc, sc);
                Hypotenuse.Text = Convert.ToString(Convert.ToInt32(cathets.Hypotenuse(cathets)));
            }
            catch 
            {

            }
            
            
            
            
        }

        private void SquareCountClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int fc = Convert.ToInt32(FirstCathet.Text);
                int sc = Convert.ToInt32(SecondCathet.Text);
                int hyp = Convert.ToInt32(Hypotenuse.Text);
                RightAngled cathets = new(fc, sc);
                Square.Text = Convert.ToString(Convert.ToInt32(cathets.Square(cathets, hyp)));
            }
            catch
            {

            }
        }
    }
}
