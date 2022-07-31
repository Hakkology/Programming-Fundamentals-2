using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakanHW2_ConsoleApp_Area_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Lütfen alan ya da çevre hesaplamak istediğiniz geometrik şekli belirtiniz.");
                Console.Write("Daire için '0', kare için '1', dikdörtgen için '2', üçgen için '3' giriniz: ");
                byte geometri = byte.Parse(Console.ReadLine());

                switch (geometri)
                {
                    case 0:
                        Console.Write("Lütfen dairenin yarıçapını giriniz: ");
                        double eskiyarıçap = Convert.ToDouble(Console.ReadLine());
                        double yarıçap = Math.Round(eskiyarıçap, 2);
                        //Gerek yok, amaç math operatörlerini incelemek.
                        Console.Write("Lütfen alan hesaplamak için '1', çevre hesaplamak için '2' giriniz. ");
                        byte hesap0 = byte.Parse(Console.ReadLine());
                        
                        //farklı caseler arasında neden aynı değişkeni koyamıyoruz ? Hesap0-1-2-3 şeklinde çözüldü.
                        if (hesap0 == 1)
                        {
                            Console.Write($"Yarıçapı {yarıçap} olan dairenin alanı: ");
                            Console.WriteLine(Math.Round((Math.Pow(yarıçap, 2) * Math.PI), 2));
                            Console.WriteLine("Alan hesabında beni kullandığın için teşekkürler.");
                            Console.ReadLine();
                        }
                        else if (hesap0 == 2)
                        {
                            Console.Write($"Yarıçapı {yarıçap} olan dairenin çevresi: ");
                            Console.WriteLine(Math.Round((2 * yarıçap * Math.PI), 2));
                            Console.WriteLine("Çevre hesabında beni kullandığın için teşekkürler.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen doğru hesap belirlemek için '1' veya '2' giriniz.");
                            Console.ReadLine();
                        }
                        break;
                    case 1:
                        Console.Write("Lütfen karenin bir kenarını giriniz: ");
                        double eskikenar = Convert.ToDouble(Console.ReadLine());
                        double kenar = Math.Round(eskikenar, 2);
                        Console.Write("Lütfen alan hesaplamak için '1', çevre hesaplamak için '2' giriniz: ");
                        byte hesap1 = byte.Parse(Console.ReadLine());

                        if (hesap1 == 1)
                        {
                            Console.Write($"Bir kenarı {kenar} olan karenin alanı: ");
                            Console.WriteLine(Math.Round((Math.Pow(kenar, 2)), 2));
                            Console.WriteLine("Alan hesabında beni kullandığın için teşekkürler.");
                            Console.ReadLine();
                        }
                        else if (hesap1 == 2)
                        {
                            Console.Write($"Bir kenarı {kenar} olan karenin çevresi: ");
                            Console.WriteLine(Math.Round((4 * kenar), 2));
                            Console.WriteLine("Çevre hesabında beni kullandığın için teşekkürler.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen doğru hesap belirlemek için '1' veya '2' giriniz.");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        //Dikdörtgen denemesidir, konuşulabilir.
                        Console.Write("Lütfen dikdörtgenin bir kenarını giriniz: ");
                        double kenar1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Lütfen dikdörtgenin diğer kenarını giriniz: ");
                        double kenar2 = Convert.ToDouble(Console.ReadLine());
                        double kısakenar = Math.Min(kenar1, kenar2);
                        double uzunkenar = Math.Max(kenar1, kenar2);
                        Console.Write("Lütfen alan hesaplamak için '1', çevre hesaplamak için '2' giriniz: ");
                        byte hesap2 = byte.Parse(Console.ReadLine());

                        if (hesap2 == 1)
                        {
                            Console.Write($"Kısa kenarı {kısakenar} ve uzun kenarı {uzunkenar} olan dikdörtgenin alanı: ");
                            Console.WriteLine(Math.Round((kısakenar * uzunkenar),2));
                            Console.WriteLine("Alan hesabında beni kullandığın için teşekkürler.");
                            Console.ReadLine();
                        }
                        else if (hesap2 == 2)
                        {
                            Console.Write($"Kısa kenarı {kısakenar} ve uzun kenarı {uzunkenar} olan dikdörtgenin çevresi: ");
                            Console.WriteLine(Math.Round((2 * (kısakenar + uzunkenar)), 2));
                            Console.WriteLine("Çevre hesabında beni kullandığın için teşekkürler.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen doğru hesap belirlemek için '1' veya '2' giriniz.");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        Console.Write("Lütfen üçgenin taban uzunluğunu giriniz: ");
                        double taban = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Lütfen üçgenin yan kenarını giriniz: ");
                        double yankenar1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Lütfen üçgenin diğer yan kenarını giriniz: ");
                        double yankenar2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Lütfen üçgen alanı hesaplamak için '1', çevre hesaplamak için '2' giriniz. ");
                        byte hesap3 = byte.Parse(Console.ReadLine());

                        if (hesap3 == 1)
                        {
                            Console.Write($"Taban uzunluğu {taban} ve yan kenarları sırayla {yankenar1} ve {yankenar2} olan üçgenin alanı: ");
                            double s = (taban + yankenar1 + yankenar2) / 2;
                            //Heron formülü 3 kenardan alan bulabilir. Aksi takdirde kullanıcıdan if altında veri alıp ilave satır yazılacaktı.
                            Console.WriteLine((Math.Round(Math.Sqrt(s * (s - taban) * (s - yankenar1) * (s * yankenar2)), 2)));
                            Console.WriteLine("Alan hesabında beni kullandığın için teşekkürler.");
                            Console.ReadLine();
                        }
                        else if (hesap3 == 2)
                        {
                            Console.Write($"Taban uzunluğu {taban} ve yan kenarları sırayla {yankenar1} ve {yankenar2} olan üçgenin çevresi: ");
                            Console.WriteLine(Math.Round((taban + yankenar1 + yankenar2), 2));
                            Console.WriteLine("Çevre hesabında beni kullandığın için teşekkürler.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen doğru hesap belirlemek için '1' veya '2' giriniz.");
                            Console.ReadLine();
                        }
                        break;
                    default:
                            Console.WriteLine("Lütfen geometrik şekil belirlemek için '0', '1', '2' veya '3' giriniz.");
                            Console.ReadLine();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen belirlenen parametrelerde değer veriniz.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Beklenmeyen bir hata oluştu.");
                Console.ReadLine();
            }   
        }
    }
}


