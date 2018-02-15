using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----HESAP MAKİNESİ-----");
            Console.WriteLine("1. Toplama İşlemi");
            Console.WriteLine("2. Çıkarma İşlemi");
            Console.WriteLine("3. Çarpma İşlemi");
            Console.WriteLine("4. Bölme İşlemi");
            Console.WriteLine("5. Mod Alma İşlemi");
            Console.WriteLine("6. Üs Alma İşlemi");
            Console.WriteLine("7. Faktöriyel İşlemi");

            int girdi = Convert.ToInt32(Console.ReadLine());
            int a, b;

            switch (girdi)
            {
                case 1:
                    Console.Write("1. sayıyı giriniz:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. sayıyı giriniz:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Toplama.toplamaIslemi(a, b);
                    break;
                case 2:
                    Console.Write("1. sayıyı giriniz:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. sayıyı giriniz:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Cikarma.cikarmaIslemi(a, b);
                    break;
                case 3:
                    Console.Write("1. sayıyı giriniz:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. sayıyı giriniz:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Carpma.carpmaIslemi(a, b);
                    break;
                case 4:
                    Console.Write("1. sayıyı giriniz:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. sayıyı giriniz:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Bolme.bolmeIslemi(a, b);
                    break;
                case 5:
                    Console.Write("1. sayıyı giriniz:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. sayıyı giriniz:");
                    b = Convert.ToInt32(Console.ReadLine());
                    
                    break;
                case 6:
                    Console.Write("1. sayıyı giriniz:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. sayıyı giriniz:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Toplama.toplamaIslemi(a, b);
                    break;
                case 7:
                    Console.Write("1. sayıyı giriniz:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. sayıyı giriniz:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Toplama.toplamaIslemi(a, b);
                    break;
                default:
                    break;
            }
        }
    }
}
