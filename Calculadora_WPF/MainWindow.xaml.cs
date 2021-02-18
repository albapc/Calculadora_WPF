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

namespace Calculadora_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string input = "0";
        string num1 = "0";
        string num2 = "0";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_siete_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Btn_ocho_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_nueve_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_multiplicacion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_cuatro_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_cinco_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_seis_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_resta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_uno_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_dos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_tres_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_suma_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_cero_Click(object sender, RoutedEventArgs e)
        {
            if(input != "0")
            {
                input += "0";

            }
        }

        private void Btn_coma_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_igual_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_division_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
