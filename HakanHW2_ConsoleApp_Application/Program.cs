using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakanHW2_ConsoleApp_ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.Write("Lütfen dilinizi seçiniz/please choose your language (Türkçe için 'TR'/'EN' for English): ");
            string dil = Console.ReadLine();

            if (dil.ToUpper()=="TR")
            //dil seçeneği switch-if
            {
                Console.WriteLine("Karakter geliştirme sayfasına hoşgeldiniz. Buradan karakterinizin girebileceği içerik hakkında bilgi alabilirsiniz.");
                Console.Write("Karakter ismini giriniz:");
                string name = Console.ReadLine();
                Console.Write("Karakter Soyadını giriniz:");
                string surname = Console.ReadLine();
                Console.Write("Karakterin Seviyesini giriniz: ");
                byte level = byte.Parse(Console.ReadLine());
                Console.Write("Karakterinizin ekipman seviyesini giriniz ");
                byte itemlevel = byte.Parse(Console.ReadLine());
                Console.WriteLine("");

                //Önce karakterin seviyesi hangi aralıkta ?
                if (level < 10)
                {
                    Console.WriteLine("Karakter seviyesi 10'dan düşük.");
                    Console.WriteLine($"{name} {surname} henüz içeriğe ulaşamaz.");
                    Console.ReadLine();
                }
                //Karakterin seviyesi eğer 10-30 arasındaysa bir içeriğe ulaşabilir, ancak ekipman seviyesine bakılması gerekiyor.
                else if (level >= 10 && level <30)
                {
                    Console.WriteLine("Karakter seviyesi 10 ile 30 arasında.");

                    if (itemlevel < 80)
                    {
                            Console.WriteLine("Ekipman gücü 80'in altında.");
                            Console.WriteLine($"{name} {surname} karakterinin ekipman gücünü artırması gerekiyor.");
                            Console.ReadLine();
                    }
                    //Eğer karakter 10-30 arası seviyesindeyse ve ekipman gücü 80 üstüyse ilk içeriğe ulaşabilir.
                    else
                    {
                            Console.WriteLine("Ekipman gücü 80 üzerinde.");
                            Console.WriteLine($"{name} {surname} ilk içeriğe ulaşabilir.");
                            Console.ReadLine();
                    }
                }
                //Karakter 30 üstü seviyede ise yine ekipman seviyesine bağlı olarak iki içeriğe ulaşabilir.
                else
                {
                    Console.WriteLine("Karakter seviyesi 30'un üzerinde.");

                    if (itemlevel <80)
                    {
                            Console.WriteLine("Ancak, ekipman gücü 80'in altında.");
                            Console.WriteLine($"{name} {surname} karakterinin ekipman gücünü artırması gerekiyor.");
                            Console.ReadLine();
                    }
                    else if (itemlevel >80 && itemlevel <150)
                    {
                            Console.WriteLine("Ekipman gücü 80 ve 150 arasında.");
                            Console.WriteLine($"{name} {surname} karakteri sadece ilk içeriğe ulaşabilir. Son içerik için ekipman gücünü artırmanız gerekiyor.");
                            Console.ReadLine();
                    }
                    else
                    {
                            Console.WriteLine("Ekipman gücü 150'nin üzerinde.");
                            Console.WriteLine($"{name} {surname} karakteri her iki içeriğe de ulaşabilir.");
                            Console.ReadLine();
                    }
                }
            }
            else if (dil.ToUpper()=="EN")
            {
                Console.WriteLine("Welcome to character development page. You can get information about accessible content for your character from here.");
                Console.Write("Please enter character name: ");
                string name = Console.ReadLine();
                Console.Write("Please enter character last name: ");
                string surname = Console.ReadLine();
                Console.Write("Please enter character's level: ");
                byte level = byte.Parse(Console.ReadLine());
                Console.Write("Please enter character's item level: ");
                byte itemlevel = byte.Parse(Console.ReadLine());
                Console.WriteLine("");

                    if (level < 10)
                    {
                        Console.WriteLine("Your character level is below 10.");
                        Console.WriteLine($"{name} {surname} cannot enter dungeons yet.");
                        Console.ReadLine();
                    }
                    else if (level >= 10 && level < 30)
                    {
                        Console.WriteLine("Your character level is between 10 and 30.");

                        if (itemlevel < 80)
                        {
                            Console.WriteLine("Your item level is below 80.");
                            Console.WriteLine($"{name} {surname} needs to boost its item level.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Your item level is above 80.");
                            Console.WriteLine($"{name} {surname} may enter the first content.");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your character level is above 30.");
                        if (itemlevel < 80)
                        {
                            Console.WriteLine("Your item level is below 80.");
                            Console.WriteLine($"{name} {surname} needs to boost its item level.");
                            Console.ReadLine();
                        }
                        else if (itemlevel < 80 && itemlevel > 150)
                        {
                            Console.WriteLine("Your item level is between 80 and 150.");
                            Console.WriteLine($"{name} {surname} may only enter the first available content. You need to boost item level for other contents.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Your item level is above 150.");
                            Console.WriteLine($"{name} {surname} may enter both available contents.");
                            Console.ReadLine();
                        }
                    }
                }
            else
            {
                Console.WriteLine("Lütfen dil belirlemek için 'TR' veya 'EN' giriniz / Please enter 'TR' or 'EN' to specify language.");
                Console.ReadLine();
            }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Lütfen karakter seviyesi için 1-50, ekipman seviyesi için 1-200 arası bir değer giriniz./ Please enter a value between 1-50 for level, 1-200 for item level.");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen karakter/ekipman seviyesini rakam olarak giriniz./Please enter character/equipment level as integers");
            }
            catch (Exception)
            {
                Console.WriteLine("Beklenmedik bir hata oluştu/Unexpected error has occured.");
                Console.ReadLine();
            }

        }
    }
}
