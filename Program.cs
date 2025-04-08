using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        private static string totalPrice;
        private static string totalÇantaPrice;

        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //Console.WriteLine("Merhaba Dünya");

            //Console.Write("selam");

            //Console.WriteLine("***** Yemek Kategorisi *****");
            //Console.WriteLine("");
            //Console.WriteLine("1- Corbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Salatalar");
            //Console.WriteLine("4- Tatlılar");
            //Console.WriteLine("5- İcecekler");
            //Console.WriteLine("6- Spesial");
            //Console.WriteLine("");

            //Console.WriteLine("***** Yemek Kategorisi *****");
            #endregion

            #region String DEĞİŞKENLER


            //String customerName;
            //String customerSurname;
            //String customerPhone;
            //String customerEmail, district, city;


            //customerName = "MUHAMMED";
            //customerSurname = "GÜLEŞÇE";
            //customerPhone = "+90 505 040 72 60";
            //customerEmail = "gulesce67@gmail.com";
            //district = "EDREMİT";
            //city = "VAN";

            //Console.WriteLine("****** REZERVASYON BİLGİ KARTI *******");
            //Console.WriteLine("");
            //Console.WriteLine("-----------------------------------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("-----------------------------------------------------------------");

            #endregion
            #region İnt DEĞİŞKENLER

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 15;
            //int priesPrice = 55;
            //int pizzaPrice = 200;
            //int lemonadePrice = 70;


            //Console.WriteLine("******** RESTORAN MENÜ FİYATLARI **********");
            //Console.WriteLine("");
            //Console.WriteLine("------------------------------------------------------------");
            //Console.WriteLine("HAMBURGER: " + hamburgerPrice + " TL");
            //Console.WriteLine("KOLA: " + cokePrice + " TL");
            //Console.WriteLine("SU: " + waterPrice + " TL");
            //Console.WriteLine("KIZARTMA: " + priesPrice + " TL");
            //Console.WriteLine("PİZZA: " + pizzaPrice + " TL");
            //Console.WriteLine("LİMONATA: " + lemonadePrice + " TL");


            //Console.WriteLine("");
            //Console.WriteLine("------------------------------------------------------------");

            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int priesCount;
            //int pizzaCount;
            //int lemonadeCount;

            //int totalHamburgerPrice;
            //int totalCokePrice;
            //int totalWaterPrice;
            //int totalPriesPrice;
            //int totalPizzaPrice;
            //int totalLemonadePrice;



            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //priesCount = 0;
            //pizzaCount = 0;
            //lemonadeCount = 0;

            //totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            //totalCokePrice = cokeCount * cokePrice;
            //totalWaterPrice = waterCount * waterPrice;
            //totalPriesPrice = priesCount * priesPrice;
            //totalPizzaPrice = pizzaCount * pizzaPrice;
            //totalLemonadePrice = lemonadeCount * lemonadePrice;

            //Console.WriteLine("------------------------------------");

            //Console.WriteLine("Hamburger Tutarı:" + totalHamburgerPrice + " TL");
            //Console.WriteLine("Kola Tutarı:" + totalCokePrice + " TL");
            //Console.WriteLine("Su Tutarı:" + totalWaterPrice + " TL");
            //Console.WriteLine("Kızartma Tutarı:" + totalPriesPrice + " TL");
            //Console.WriteLine("Pizza Tutarı:" + totalPizzaPrice + " TL");
            //Console.WriteLine("Limonata Tutarı:" + totalLemonadePrice + " TL");

            //Console.WriteLine("");

            //int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalPriesPrice + totalPizzaPrice + totalLemonadePrice;




            //Console.WriteLine("TOPLAM ÖDENECEK TUTAR:" + totalPrice + " TL");


            //int masaPrice = 500;
            //int sandalyePrice = 400;
            //int perdePrice = 100;
            //int konsolPrice = 600;
            //int avizePrice = 350;

            //Console.WriteLine("ÇEYİZCİ FİYAT LİSTESİ");
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("");
            //Console.WriteLine("Masa:" + masaPrice + "TL");
            //Console.WriteLine("Sandalye:" + sandalyePrice + " TL");
            //Console.WriteLine("Perde:" + perdePrice + " TL");
            //Console.WriteLine("Konsol:" + konsolPrice + " TL");
            //Console.WriteLine("Avize:" + avizePrice + " TL");

            //int masaCount;
            //int sandalyeCount;
            //int perdeCount;
            //int konsolCount;
            //int avizeCount;

            //int totalMasaPrice;
            //int totalSandalyePrice;
            //int totalPerdePrice;
            //int totalKonsolPrice;
            //int totalAvizePrice;


            //masaCount = 5;
            //sandalyeCount = 20;
            //perdeCount = 4;
            //konsolCount = 1;
            //avizeCount = 2;

            //totalMasaPrice = masaCount * masaPrice;
            //totalSandalyePrice = sandalyeCount * sandalyePrice;
            //totalPerdePrice = perdeCount * perdePrice;
            //totalKonsolPrice = konsolCount * konsolPrice;
            //totalAvizePrice = avizeCount * avizePrice;

            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Masa:" + totalMasaPrice + " TL");
            //Console.WriteLine("Sandalye:" + totalSandalyePrice + " TL");
            //Console.WriteLine("Perde:" + totalPerdePrice + " TL");
            //Console.WriteLine("Konsol:" + totalKonsolPrice + " TL");
            //Console.WriteLine("Avize:" + totalAvizePrice + " TL");
            //Console.WriteLine("");

            //int totalPrice = totalMasaPrice + totalSandalyePrice + totalPerdePrice + totalKonsolPrice + totalAvizePrice;

            //Console.WriteLine("TOPLAM ÖDENECEK TUTAR:" + totalPrice + " TL");

            //Console.WriteLine("");









            #endregion
            #region Kendi Yaptığım
            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail;
            //string customerDisrict;
            //string customerCity;

            //customerName = "MUHAMMED";
            //customerSurname = "ŞAHİN";
            //customerPhone = "545464665";
            //customerEmail = "SAHİNJFS@GSFA6564";
            //customerDisrict = "EDREMİT";
            //customerCity = "VANN";

            //Console.WriteLine("MÜŞTERİ BİLGİ KARTI");

            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("");
            //Console.WriteLine("Adı Soyadı:" + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon Numarası:" + customerPhone);
            //Console.WriteLine("E posta Adresi:" + customerEmail);
            //Console.WriteLine("İlçe:" + customerDisrict);
            //Console.WriteLine("Şehir:" + customerCity);
            //Console.WriteLine("");
            //Console.WriteLine("-------------------------------------");
            #endregion
            #region

            //int kalemPrice = 10;
            //int silgiPrice = 5;
            //int acacakPrice = 2;
            //int defterPrice = 10;
            //int cantaPrice = 100;

            //Console.WriteLine("********KIRTASİYE*************");
            //Console.WriteLine("");
            //Console.WriteLine("Kalem:" + kalemPrice + "TL");
            //Console.WriteLine("Silgi:" + silgiPrice + "TL");
            //Console.WriteLine("Açacak:" + acacakPrice + "TL");
            //Console.WriteLine("Defter:" + defterPrice + "TL");
            //Console.WriteLine("Çanta:" + cantaPrice + "TL");

            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("");

            //int kalemCount;
            //int silgiCount;
            //int acacakCount;
            //int defterCount;
            //int cantaCount;

            //int totalKalemPrice;
            //int totalSilgiPrice;
            //int totalAçacakPrice;
            //int totalDefterPrice;
            //int totalCantaPrice;

            //kalemCount = 100;
            //silgiCount = 500;
            //acacakCount = 200;
            //defterCount = 1000;
            //cantaCount = 213;



            //totalKalemPrice = kalemCount * kalemPrice;
            //totalSilgiPrice = silgiCount * silgiPrice;
            //totalAçacakPrice = acacakCount * acacakPrice;
            //totalDefterPrice = defterCount * defterPrice;
            //totalCantaPrice = cantaCount * cantaPrice;


            //Console.WriteLine("KALEM FİYATI:" + totalKalemPrice + "TL");
            //Console.WriteLine("SİLGİ FİYATI:" + totalSilgiPrice + "TL");
            //Console.WriteLine("AÇACAK FİYATI:" + totalAçacakPrice + "TL");
            //Console.WriteLine("DEFTER FİYATI:" + totalDefterPrice + "TL");
            //Console.WriteLine("ÇANTA FİYATI:" + totalÇantaPrice + "TL");
            //Console.WriteLine("");
            //int totalPrice = totalKalemPrice + totalSilgiPrice + totalAçacakPrice + totalDefterPrice + totalCantaPrice;

            //Console.WriteLine("Toplam Ödenecek Tutar:" + totalPrice + "TL");
            //Console.WriteLine("**************************");


            #endregion



            Console.Read();
        }
    }
}
