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

namespace lab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Pair pair1 = new Pair(_fpfv,_spfv);
        //Pair pair2 = new Pair(_fpsv, _spsv);
        //
        //public static int _fpfv = 0;
        //public static int _fpsv = 0;
        //public static int _spfv = 0;
        //public static int _spsv = 0;

        private void MultiplicateButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int _fpfv = Convert.ToInt32(FirstPairFirstValue.Text);
                int _fpsv = Convert.ToInt32(FirstPairSecondValue.Text);
                int _spfv = Convert.ToInt32(SecondPairFirstValue.Text);
                int _spsv = Convert.ToInt32(SecondPairSecondValue.Text);

                Pair pair1 = new(_fpfv, _spfv);
                Pair pair2 = new(_fpsv, _spsv);

                Pair pair = pair1.Multiplicate(pair2);
                ResultFirstValue.Text = $"{pair.First}";
                ResultSecondValue.Text = $"{pair.Second}";
            }
            catch
            {
                MessageBox.Show("Введите числа");
            }

        }

        private void DoubleButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int _fpfv = Convert.ToInt32(FirstPairFirstValue.Text);
                int _fpsv = Convert.ToInt32(FirstPairSecondValue.Text);
                int _spfv = Convert.ToInt32(SecondPairFirstValue.Text);
                int _spsv = Convert.ToInt32(SecondPairSecondValue.Text);

                Pair pair1 = new(_fpfv, _spfv);
                Pair pair2 = new(_fpsv, _spsv);

                pair1++;
                pair2++;


                FirstPairFirstValue.Text = pair1.First.ToString();
                SecondPairFirstValue.Text = pair1.Second.ToString();
                FirstPairSecondValue.Text = pair2.First.ToString();
                SecondPairSecondValue.Text = pair2.Second.ToString();
            }
            catch
            {
                MessageBox.Show("Введите числа");
            }

        }





        private void AboutProgramClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать класс Pair (пара четных чисел).\nСоздать необходимые методы и свойства.\nОпределить метод перемножения пар (а, b) * (с, d) = (а * c, b * d).\nСоздать перегруженный метод для удвоения пары чисел.\nСоздатель: Халимов Виктор.");
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            Close();
            
        }
    }
}
