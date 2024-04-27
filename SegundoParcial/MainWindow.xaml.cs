using System.Security.Claims;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using static SegundoParcial.MainWindow;
using static System.Net.Mime.MediaTypeNames;

namespace SegundoParcial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double cantidad1 = Convert.ToDouble(txtcantidad1.Text);
            double cantidad2 = Convert.ToDouble(txtcantidad2.Text);
            string operacion = ((ComboBoxItem)cmboperacion.SelectedItem).Content.ToString();

            Calculadora calculadora;
            if (operacion == "+" || operacion == "-" || operacion == "*" || operacion == "/")
            {
                calculadora = new Calculadora();
            }
            else
            {
                calculadora = new CalculadoraCientifica();
            }

            double resultado = Calculadora.calcular(cantidad1, cantidad2, operacion);
            MessageBox.Show("El resultado es: " + resultado);
        }
    }

    public class Calculadora
    {
        public static double calcular(double cantidad1, double cantidad2, string operacion)
        {
            switch (operacion)
            {
                case "+":
                    return cantidad1 + cantidad2;
                case "-":
                    return cantidad1 - cantidad2;
                case "*":
                    return cantidad1 * cantidad2;
                case "/":
                    return cantidad1 / cantidad2;
                default:
                    throw new ArgumentException("Operación no válida");
            }
        }
    }

    public class CalculadoraCientifica : Calculadora
    {
        public static new double calcular(double cantidad1, double cantidad2, string operacion)
        {
            switch (operacion)
            {
                case "potencia":
                    return Math.Pow(cantidad1, cantidad2);
                case "raiz":
                    return Math.Sqrt(cantidad1);
                case "seno":
                    return Math.Sin(cantidad1);
                case "coseno":
                    return Math.Cos(cantidad1);
                case "tangente":
                    return Math.Tan(cantidad1);
                default:
                    return Calculadora.calcular(cantidad1, cantidad2, operacion);
            }
        }
    }
}