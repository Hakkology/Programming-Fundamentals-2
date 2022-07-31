using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakanHW2_ConsoleApp_MarketplaceItems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int IronSword = 0;
                int SilverSword = 0;
                int LeatherArmor = 0;
                int SteelArmor = 0;
                int IronSwordPrice = 40;
                int SilverSwordPrice = 120;
                int LeatherArmorPrice = 30;
                int SteelArmorPrice = 85;
                //bunların tamamını tek bir satırda tanımlayabilir miyiz ? Birden fazla int tanımlamanın daha az satırla yolu ?
                //byte Market = 1;

                Console.Write("Karakterinizin üzerinde ne kadar altın var ?: ");
                int CharacterGold = Convert.ToInt16(Console.ReadLine());

                //while (Market == 1) -Sadece denemedir, lütfen önemsemeyiniz :)
                //{
                    Console.WriteLine($"Şu an için {CharacterGold} altınınız var.");
                    Console.WriteLine("Lütfen sepetinize eklemek istediğiniz eşyaları belirtiniz.");
                    Console.WriteLine("Demir Kılıç (40g) için '1', Gümüş Kılıç (120g) için '2', Deri Zırh (30g) için '3', Çelik Zırh için (85g) '4'e: ");
                    Console.Write("Marketten çıkmak için '9', sepetinizi görmek için '0'a basınız.");
                    byte item = Convert.ToByte(Console.ReadLine());
                if (item == 1)
                {
                    Console.Write("Lütfen kaç adet almak istediğinizi belirtiniz: ");
                    byte IronSwordPurchase = Convert.ToByte(Console.ReadLine());
                    int IronSwordcheckout = IronSword + IronSwordPurchase;
                    int Checkout = IronSwordcheckout * IronSwordPrice;
                    Console.Write($"Sepetinizde {IronSwordcheckout} Demir Kılıç var, {Checkout} altın ödemek üzeresiniz. Devam etmek için bir tuşa basın...");
                    //Satın almak istediğinizden emin misiniz diye sorgu eklenecek, başa dönmeli, loop ?
                    Console.ReadLine();
                    if (CharacterGold > Checkout)
                    {
                        int RemainingGold = CharacterGold - Checkout;
                        Console.WriteLine($"Satın alım gerçekleşti. Geriye {RemainingGold} altınınız kaldı.");
                        Console.Write("Bizi tercih ettiğiniz için teşekkür ederiz.");
                        Console.ReadLine();
                        #region LoopDenemesi
                        //Console.Write("Başka bir item satın almak isterseniz '1' e, sonlandırmak isterseniz '2' ye basın.");
                        //byte Input = Convert.ToByte(Console.ReadLine());
                        //if (Input == 2)
                        //{
                        //    Market++;
                        //    Console.Write("Marketimizi kullandığınız için teşekkürler, yine Bekleriz.");
                        //    Console.ReadLine();
                        //}
                        //else
                        //{
                        //    CharacterGold = RemainingGold;
                        //    IronSword = 0;
                        //    Console.Write("Sizi tekrar satın alma bölümüne gönderiyoruz.");
                        //    Console.ReadLine();
                        //}
                        #endregion
                    }
                    else
                    {
                        //Checkout u ödeyebildiğimiz kadar alınacak şekilde güncelleme çalışılacak. Çözüldü, gerek yok.
                        IronSwordcheckout = 0;
                        Console.WriteLine("Yeterince altınınız yok. Toplayıp gelin.");
                        Console.ReadLine();
                    }
                }
                else if (item == 2)
                {
                    Console.Write("Lütfen kaç adet almak istediğinizi belirtiniz: ");
                    byte SilverSwordPurchase = Convert.ToByte(Console.ReadLine());
                    int SilverSwordcheckout = SilverSword + SilverSwordPurchase;
                    int Checkout = SilverSwordcheckout * SilverSwordPrice;
                    Console.Write($"Sepetinizde {SilverSwordcheckout} Gümüş Kılıç var, {Checkout} altın ödemek üzeresiniz. Devam etmek için bir tuşa basın...");
                    //Satın almak istediğinizden emin misiniz diye sorgu eklenecek, başa dönmeli, loop ?
                    Console.ReadLine();

                    if (CharacterGold > Checkout)
                    {
                        int RemainingGold = CharacterGold - Checkout;
                        Console.Write($"Satın alım gerçekleşti. Geriye {RemainingGold} altınınız kaldı.");
                        Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz.");
                        Console.ReadLine();
                    }
                    else
                    {
                        SilverSwordcheckout = 0;
                        Console.WriteLine("Yeterince altınınız yok. Toplayıp gelin.");
                        Console.ReadLine();
                    }
                }
                else if (item == 3)
                {
                    Console.Write("Lütfen kaç adet almak istediğinizi belirtiniz: ");
                    byte LeatherArmorPurchase = Convert.ToByte(Console.ReadLine());
                    int LeatherArmorcheckout = LeatherArmor + LeatherArmorPurchase;
                    int Checkout = LeatherArmorcheckout * LeatherArmorPrice;
                    Console.Write($"Sepetinizde {LeatherArmorcheckout} Deri Zırh var, {Checkout} altın ödemek üzeresiniz. Devam etmek için bir tuşa basın...");
                    //Satın almak istediğinizden emin misiniz diye sorgu eklenecek, başa dönmeli, loop ?
                    Console.ReadLine();
                    if (CharacterGold > Checkout)
                    {
                        int RemainingGold = CharacterGold - Checkout;
                        Console.Write($"Satın alım gerçekleşti. Geriye {RemainingGold} altınınız kaldı.");
                        Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz.");
                        Console.ReadLine();
                    }
                    else
                    {
                        LeatherArmorcheckout = 0;
                        Console.WriteLine("Yeterince altınınız yok. Toplayıp gelin.");
                        Console.ReadLine();
                    }
                }
                else if (item == 4)
                {
                    Console.Write("Lütfen kaç adet almak istediğinizi belirtiniz: ");
                    byte SteelArmorPurchase = Convert.ToByte(Console.ReadLine());
                    int SteelArmorcheckout = SteelArmor + SteelArmorPurchase;
                    int Checkout = SteelArmorcheckout * SteelArmorPrice;
                    Console.Write($"Sepetinizde {SteelArmorcheckout} adet Çelik Zırh var. Devam etmek için bir tuşa basın...");
                    //Satın almak istediğinizden emin misiniz diye sorgu eklenecek, başa dönmeli, loop ?
                    Console.ReadLine();
                    if (CharacterGold > Checkout)
                    {
                        int RemainingGold = CharacterGold - Checkout;
                        Console.Write($"Satın alım gerçekleşti. Geriye {RemainingGold} altınınız kaldı.");
                        Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz.");
                        Console.ReadLine();
                    }
                    else
                    {
                        SteelArmorcheckout = 0;
                        Console.WriteLine("Yeterince altınınız yok. Toplayıp gelin.");
                        Console.ReadLine();
                    }
                }
                else if (item == 9)
                {
                    Console.WriteLine("Marketi kullandığınız için teşekkür ederiz.");
                    Console.ReadLine();
                }
                else if (item == 0)
                {
                    Console.WriteLine($"Şu an sepetinizde {IronSword} adet demir kılıç, {SilverSword} adet gümüş kılıç, {LeatherArmor} kadar deri zırh, {SteelArmor} kadar çelik zırh bulunmakta.");
                    //Satın almak istediğinizden emin misiniz diye sorgu eklenecek, başa dönmeli, loop ?
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Lütfen belirtilen parametrelerden birini giriniz");
                    Console.ReadLine();
                }
                //} - While son braketi, lütfen dikkate almayın :).
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen altın sayınızı tamsayı olarak giriniz.");
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
