﻿using System;
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
using System.Numerics;
namespace KMZI13
{
    /// <summary>
    /// Логика взаимодействия для Encrypt.xaml
    /// </summary>
    public partial class Encrypt : Window
    {
        int mod(int k, int n) { return ((k %= n) < 0) ? k + n : k; }
        Dictionary<char, (int x,int y)> hash = new Dictionary<char, (int x,int y)>();
        Dictionary<(int x, int y),char> obrhash = new Dictionary<(int x, int y),char>();
        int p = 751;
        int d = 29;
        public Encrypt()
        {
            InitializeComponent();
        }
        string SumTwoPoints(int xP, int xQ, int yP, int yQ)
        {
            BigInteger lyambda;
            int raznX = xQ - xP;
            int raznY = yQ - yP;
            if (raznX < 0)
            {
                raznX += p;
            }
            if (raznY < 0)
            {
                raznY += p;
            }
            if (xP == 0 & yP == 0)
            {
                return xQ.ToString() + ',' + yQ.ToString();
            }
            if (xQ == 0 & yQ == 0)
            {
                return xP.ToString() + ',' + yP.ToString();
            }
            BigInteger xR = 0, yR = 0;
            if (xP == xQ && yP != yQ || (yP == 0 && yQ == 0 && xP == xQ))
            { }
            else
            {
                if (xP == xQ && yP == yQ)
                {
                    lyambda = (3 * BigInteger.Pow(xP, 2) - 1) * (Foo(2 * yP, p));
                }
                else
                {
                    lyambda = (raznY) * Foo(raznX, p);
                }
                xR = (BigInteger.Pow(lyambda, 2) - xP - xQ);
                yR = yP + lyambda * (xR - xP);
                xR = xR % p < 0 ? (xR % p) + p : xR % p;
                yR = -yR % p < 0 ? (-yR % p) + p : (-yR % p);
            }
            string Result = xR.ToString() + ',' + yR.ToString();
            return Result;
        }
        string Multiply(int k, int xP, int yP)
        {
            string[] numbers = { "", "" };
            int xQ = xP;
            int yQ = yP;
            string[] result = { "" };
            string[] addend = { xQ.ToString(), yQ.ToString() };
            while (k > 0)
            {
                if ((k & 1) > 0)
                {
                    if (result.Length == 2)
                    {
                        result = SumTwoPoints(int.Parse(result[0]), int.Parse(addend[0]), int.Parse(result[1]), int.Parse(addend[1])).Split(',');
                    }
                    else
                    {
                        result = addend;
                    }
                }
                addend = SumTwoPoints(int.Parse(addend[0]), int.Parse(addend[0]), int.Parse(addend[1]), int.Parse(addend[1])).Split(',');
                k >>= 1;
            }
            return result[0] + "," + result[1];
        }
        public void Init()
        {
            hash = new Dictionary<char, (int x, int y)>();
            hash.Add('А', (200,30));
            hash.Add('Б', (209,669));
            hash.Add('В', (200,721));
            hash.Add('Г', (189,297));
            hash.Add('Д', (184, 247));
            hash.Add('Е', (189, 293));
            hash.Add('Ё', (206, 264));
            hash.Add('Ж', (201, 299));
            hash.Add('З', (207, 291));
            hash.Add('И', (143, 254));
            hash.Add('Й', (187, 199));
            hash.Add('К', (113, 286));
            hash.Add('Л', (125, 277));
            hash.Add('М', (147, 242));
            hash.Add('Н', (153, 223));
            hash.Add('О', (181, 255));
            hash.Add('П', (175, 256));
            hash.Add('Р', (173, 267));
            hash.Add('С', (164, 238));
            hash.Add('Т', (215, 248));
            hash.Add('У', (211, 258));
            hash.Add('Ф', (166, 212));
            hash.Add('Х', (188, 277));
            hash.Add('Ц', (219, 233));
            hash.Add('Ч', (107, 241));
            hash.Add('Ш', (269, 357));
            hash.Add('Щ', (177, 482));
            hash.Add('Ъ', (150, 277));
            hash.Add('Ы', (244, 315));
            hash.Add('Ь', (213, 365));
            hash.Add('Э', (224, 398));
            hash.Add('Ю', (239, 450));
            hash.Add('Я', (318, 455));
            obrhash = new Dictionary<(int x, int y), char>();
            obrhash.Add((200, 30), 'А');
            obrhash.Add((209, 669), 'Б');
            obrhash.Add((200, 721), 'В');
            obrhash.Add((189, 297), 'Г');
            obrhash.Add((184, 247), 'Д');
            obrhash.Add((189, 293), 'Е');
            obrhash.Add((206, 264), 'Ё');
            obrhash.Add((201, 299), 'Ж');
            obrhash.Add((207, 291), 'З');
            obrhash.Add((143, 254), 'И');
            obrhash.Add((187, 199), 'Й');
            obrhash.Add((113, 286), 'К');
            obrhash.Add((125, 277), 'Л');
            obrhash.Add((147, 242), 'М');
            obrhash.Add((153, 223), 'Н');
            obrhash.Add((181, 255), 'О');
            obrhash.Add((175, 256), 'П');
            obrhash.Add((173, 267), 'Р');
            obrhash.Add((164, 238), 'С');
            obrhash.Add((215, 248), 'Т');
            obrhash.Add((211, 258), 'У');
            obrhash.Add((166, 212), 'Ф');
            obrhash.Add((188, 277), 'Х');
            obrhash.Add((219, 233), 'Ц');
            obrhash.Add((107, 241), 'Ч');
            obrhash.Add((269, 357), 'Ш');
            obrhash.Add((177, 482), 'Щ');
            obrhash.Add((150, 277), 'Ъ');
            obrhash.Add((244, 315), 'Ы');
            obrhash.Add((213, 365), 'Ь');
            obrhash.Add((224, 398), 'Э');
            obrhash.Add((239, 450), 'Ю');
            obrhash.Add((318, 455), 'Я');
            //obrhash.Add((200, 30),'Я');
            //obrhash.Add((209, 669),'Р');
            //obrhash.Add((200, 721),'М');
            //obrhash.Add((189, 297),'О');
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Init();
            string text = TextToEncrypt.Text;
            TextToDecrypt.Text = "";
            (int x, int y) cort;
            int k = 3;
            int xG = 0;
            int yG = 1;
            string[] numbersQ = Multiply(d, xG, yG).Split(',');
            int xQ = int.Parse(numbersQ[0]);
            int yQ = int.Parse(numbersQ[1]);
            foreach (char s in text)
            {
                hash.TryGetValue(s, out cort);
                string numbersC1 = Multiply(k, xG, yG);
                string[] numbersExpr1 = Multiply(k, xQ, yQ).Split(',');
                string numbersC2 = SumTwoPoints(cort.x, int.Parse(numbersExpr1[0]), cort.y, int.Parse(numbersExpr1[1]));
                TextToDecrypt.Text += numbersC1 + ' ' + numbersC2+' ';
            }
            TextToDecrypt.Text = TextToDecrypt.Text.Remove(TextToDecrypt.Text.Length - 1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string[] text = TextToDecrypt.Text.Split(' ');
            TextToEncrypt.Text = "";
            for(int i = 0;i<text.Length;i+=2 )
            {
                string[] numbers1 =text[i].Split(',');
                string[] numbers2 = text[i+1].Split(',');
                string[] numbersC1 = Multiply(d, int.Parse(numbers1[0]), int.Parse(numbers1[1])).Split(',');
                string[] result = SumTwoPoints(int.Parse(numbers2[0]), int.Parse(numbersC1[0]), int.Parse(numbers2[1]), mod(-int.Parse(numbersC1[1]),p)).Split(',');
                (int x, int y) cort = (int.Parse(result[0]), int.Parse(result[1]));
                char s;
                obrhash.TryGetValue(cort, out s);
                TextToEncrypt.Text += s;
            }
        }
        private int Foo(int a, int m)
        {
            int x, y;
            int g = GCD(a, m, out x, out y);
            if (g != 1)
                throw new ArgumentException();
            return (x % m + m) % m;
        }

        private int GCD(int a, int b, out int x, out int y)
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
            return d % p;
        }
    }
}
