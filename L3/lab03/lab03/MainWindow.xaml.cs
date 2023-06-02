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

namespace lab03
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

        private int Foo(int a, int m)
        {
            int x, y;
            int g = GCD(a, m, out x, out y);
            if (g != 1)
                throw new ArgumentException();
            return (x % m + m) % m;
        }

        private static int GCD(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            int x1, y1;
            int d = GCD(b % a, a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }

        public int findGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private bool IsPrimeNumber(int number)
        {
            int sqrtNumber = (int)(Math.Sqrt(number));
            for (int i = 2; i <= sqrtNumber; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Numbers.Text = "";
            /*int count = 0;*//**/
            int number1 = 0;
            int number2 = 0;
            double count2 = 0;
            int.TryParse(Number1.Text, out number1);
            int.TryParse(Number2.Text, out number2);
            /*for (int i = number1; i <= number2; i++)
            {
                if (IsPrimeNumber(i))
                {
                    count++;
                    Numbers.Text += i + ",";
                }
            }*/
            /*Result.Text = count.ToString();*/

            /*count2 = count * 0.98;
            nLn.Text = count2.ToString();*/

            int n, j = 0;
            int count = 0;
            n = number2;
            int[] a = new int[n];
            for (int i = number1; i < n; i++)
            {
                a[i] = i;
            }
            a[1] = 0;
            int m = 2;
            while (m < n)
            {
                if (a[m] != 0)
                    j = m * 2;
                while (j < n)
                {
                    a[j] = 0;
                    j = j + m;
                }
                m += 1;
            }
            foreach (int x in a)
            {
                if (x != 0)
                {
                    Numbers.AppendText(x + " ");
                    count++;
                }
                    /*Console.Write(x + " ");*/
            }
            /*Console.ReadKey();*/

            Result.Text = count.ToString();
            nLn.Text = ((number2 / Math.Log(number2, Math.E)) - (number1 / Math.Log(number1, Math.E))).ToString();

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;
            int nod1 = 0, nod2 = 0, nod3 = 0;
            int.TryParse(NumberNOD.Text, out nod1);
            int.TryParse(Number2NOD.Text, out nod2);
            int.TryParse(Number3NOD.Text, out nod3);
            if (nod1 != 0 && nod2 != 0 && nod3 != 0)
            {
                result = findGreatestCommonDivisor(findGreatestCommonDivisor(nod1, nod2), nod3);
            }
            else
            {
                if (nod1 == 0)
                {
                    result = findGreatestCommonDivisor(nod2, nod3);
                }
                else if (nod2 == 0)
                {
                    result = findGreatestCommonDivisor(nod1, nod3);
                }
                else
                {
                    result = findGreatestCommonDivisor(nod1, nod2);
                }
            }
            ResultNOD.Text = result.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                ResultMod.Text = Foo(int.Parse(NumberMod1.Text), int.Parse(NumberMod2.Text)).ToString();
            }
            catch
            {
                ResultMod.Text = "Не существует обратного числа";
            }
        }
    }
}
