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
        string num1 = string.Empty;
        string num2 = string.Empty;
        char operador;
        double resultado;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Inputs numéricos
        private void Btn_cero_Click(object sender, RoutedEventArgs e)
        {
            if(input != "0")
            {
                input += "0";
            } else
            {
                input = "0";
            }
            tb_resultado.Text = "";
            tb_resultado.Text += input;
        }

        private void Btn_uno_Click(object sender, RoutedEventArgs e)
        {
            if (input != "0")
            {
                input += "1";
            }
            else
            {
                input = "1";
            }
            tb_resultado.Text = "";
            tb_resultado.Text += input;
        }

        private void Btn_dos_Click(object sender, RoutedEventArgs e)
        {
            if (input != "0")
            {
                input += "2";
            }
            else
            {
                input = "2";
            }
            tb_resultado.Text = "";
            tb_resultado.Text += input;
        }

        private void Btn_tres_Click(object sender, RoutedEventArgs e)
        {
            if (input != "0")
            {
                input += "3";
            }
            else
            {
                input = "3";
            }
            tb_resultado.Text = "";
            tb_resultado.Text += input;
        }

        private void Btn_cuatro_Click(object sender, RoutedEventArgs e)
        {
            if (input != "0")
            {
                input += "4";
            }
            else
            {
                input = "4";
            }
            tb_resultado.Text = "";
            tb_resultado.Text += input;
        }

        private void Btn_cinco_Click(object sender, RoutedEventArgs e)
        {
            if (input != "0")
            {
                input += "5";
            }
            else
            {
                input = "5";
            }
            tb_resultado.Text = "";
            tb_resultado.Text += input;
        }

        private void Btn_seis_Click(object sender, RoutedEventArgs e)
        {
            if (input != "0")
            {
                input += "6";
            }
            else
            {
                input = "6";
            }
            tb_resultado.Text = "";
            tb_resultado.Text += input;
        }

        private void Btn_siete_Click(object sender, RoutedEventArgs e)
        {
            if (input != "0")
            {
                input += "7";
            }
            else
            {
                input = "7";
            }
            tb_resultado.Text = "";
            tb_resultado.Text += input;
        }

        private void Btn_ocho_Click(object sender, RoutedEventArgs e)
        {
            if (input != "0")
            {
                input += "8";
            }
            else
            {
                input = "8";
            }
            tb_resultado.Text = "";
            tb_resultado.Text += input;
        }

        private void Btn_nueve_Click(object sender, RoutedEventArgs e)
        {
            if (input != "0")
            {
                input += "9";
            }
            else
            {
                input = "9";
            }
            tb_resultado.Text = "";
            tb_resultado.Text += input;
        }

        private void Btn_coma_Click(object sender, RoutedEventArgs e)
        {
            // Si el input no contiene una coma, la añade; de lo contrario no hace nada
            if(!input.Contains("."))
            {
                input += ".";
            }
        }

        // Inputs de operadores
        private void Btn_suma_Click(object sender, RoutedEventArgs e)
        {
            // Almacena lo introducido en el textbox en la variable del primer operando
            num1 = input;
            operador = '+';
            input = string.Empty;
            tb_resultado.Text = ""; 
        }

        private void Btn_resta_Click(object sender, RoutedEventArgs e)
        {
            num1 = input;
            operador = '-';
            input = string.Empty;
            tb_resultado.Text = "";
        }

        private void Btn_multiplicacion_Click(object sender, RoutedEventArgs e)
        {
            num1 = input;
            operador = '*';
            input = string.Empty;
            tb_resultado.Text = "";
        }


        private void Btn_division_Click(object sender, RoutedEventArgs e)
        {
            num1 = input;
            operador = '/';
            input = string.Empty;
            tb_resultado.Text = "";
        }


        // Cálculo de resultados
        private void Btn_igual_Click(object sender, RoutedEventArgs e)
        {
            num2 = input;
            double.TryParse(num1, out double n1);
            double.TryParse(num2, out double n2);

            switch(operador)
            {
                case '+':
                    resultado = n1 + n2;
                    tb_resultado.Text = resultado.ToString();
                    break;
                case '-':
                    resultado = n1 - n2;
                    tb_resultado.Text = resultado.ToString();
                    break;
                case '*':
                    resultado = n1 * n2;
                    tb_resultado.Text = resultado.ToString();
                    break;
                case '/':
                    try
                    {
                        resultado = n1 / n2;
                        tb_resultado.Text = resultado.ToString();
                    } catch (DivideByZeroException dbz)
                    {
                        tb_resultado.Text = "Err";
                    }
                    break;
            }
        }

        
        // Borrar input
        private void Btn_borrar_Click(object sender, RoutedEventArgs e)
        {
            input = "0";
            num1 = string.Empty;
            num2 = string.Empty;
            tb_resultado.Text = "0";
        }

        // Cerrar la aplicación
        private void Btn_salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
