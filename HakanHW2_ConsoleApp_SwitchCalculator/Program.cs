using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakanHW2_ConsoleApp_SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Çağımızın en hızlı hesap makinesine hoşgeldiniz. Size ben yardımcı olacağım.");
                Console.WriteLine("");
                Console.Write("Başlatmak için '1' yazın: ");
                byte start = Convert.ToByte(Console.ReadLine());

                if (start == 1)
                {
                    Console.Write("1. rakamı girin: ");
                    decimal a = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("2. rakamı girin: ");
                    decimal b = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Toplama için '1', çıkarma için '2', çarpma için '3', bölme için '4' olarak girin: ");
                    byte işlem = Convert.ToByte(Console.ReadLine());

                    switch (işlem)
                    {
                        case 1:
                            Console.WriteLine("Toplama işlemini seçtiniz.");
                            decimal toplama = a + b;
                            Console.WriteLine($"{a} + {b} = {toplama}");
                            Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("Çıkarma işlemini seçtiniz.");
                            decimal çıkarma = a - b;
                            switch (çıkarma >= 0)
                            {
                                case true:
                                    Console.WriteLine($"{a} - {b} = {çıkarma}");
                                    Console.ReadLine();
                                    break;

                                case false:
                                    çıkarma *= -1;
                                    Console.WriteLine($"{b} - {a} = {çıkarma}");
                                    //Math.Abs(çıkarma);
                                    Console.ReadLine();
                                    break;
                            }
                            break;

                        case 3:
                            Console.WriteLine("Çarpma işlemini seçtiniz.");
                            decimal çarpma = a * b;
                            Console.WriteLine($"{a} * {b} = {çarpma}");
                            Console.ReadLine();
                            break;

                        case 4:
                            Console.WriteLine("Bölme işlemini seçtiniz.");
                            switch (b == 0)
                            {
                                case true:
                                    Console.WriteLine("0'a bölme hatası görüldü.");
                                    Console.ReadLine();
                                    break;

                                case false:
                                    decimal bölme = a / b;
                                    Console.Write($"{a} / {b} = {bölme}");
                                    Console.ReadLine();
                                    break;
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Toplama için '1', çıkarma için '2', çarpma için '3', bölme için '4' olarak giriniz: ");
                                Console.ReadLine();
                                break;
                            }


                    }
                }
                else
                {
                    Console.WriteLine("'1' e basılmadığı için program başlamamıştır. Lütfen tekrar deneyin.");
                    Console.ReadLine();
                }
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Tanımlanmamış işlem girdiniz.");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen işlem yapılabilecek rakam giriniz.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Beklenmedik bir hata oluştu.");
                Console.ReadLine();
            }
            finally
            { 
                Console.Write("Çağımızın en hızlı hesap makinesini kullandığınız için teşekkür ederiz.");
                Console.ReadLine();
            }


        }
    }
}
