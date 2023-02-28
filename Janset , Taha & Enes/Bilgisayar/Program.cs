using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar
{
    internal class Program
    {
        class Bilgisayar
        {
            public string acKapa;
            public string donanım;
            public int sesDüzeni;
            
           public void oyunAc()
            {
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                System.Threading.Thread.Sleep(300);
                Console.Write("   Seçim Yapınız :   ");
                int secim2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Seçiminiz Onaylandı!");
                System.Threading.Thread.Sleep(500);
                if(secim2 == 1)
                {

                }
                if(secim2 == 2)
                {

                }
            }
           public void oyunGoster()
            {
                Console.WriteLine("         OYUNLAR  ");
                Console.WriteLine(" (1) Taş - Kağıt - Makas");
                Console.WriteLine("");
                Console.WriteLine(" (2) Zar Atma");
                Console.WriteLine("");
            }
           public void acKapat()
            {
                Console.WriteLine("");
                Console.WriteLine("| ------------------------------------------------------------------------ |");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("| ------------------------------------------------------------------------ |");
                Console.WriteLine("|                                                                          | ");
                Console.WriteLine("| --------------------------------  O ------------------------------------ |");
                System.Threading.Thread.Sleep(50);
                Console.WriteLine("");
                Console.Write(" Bilgisayar'ı Açmak İçin Ac / Yazınız :");
                string secim = Console.ReadLine();
                if(secim == "Ac")
                {
                
                a:    
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("| ------------------------------------------------------------------------ |");
                    Console.WriteLine("|                                                                          | ");
                    Console.WriteLine("|                                                                          | ");
                    Console.WriteLine("|                                                                          | ");
                    Console.WriteLine("|  GOOGLE                                                                  | "+" - 1");
                    Console.WriteLine("|                                                                          | ");
                    Console.WriteLine("|  FACEBOOK                                                                | "+" - 2");
                    Console.WriteLine("|                                                                          | ");
                    Console.WriteLine("|  GOAT SİM                                                                | "+" - 3");
                    Console.WriteLine("|                                                                          | ");
                    Console.WriteLine("|  DOSYA GEZGİNİ                                                           | "+" - 4");
                    Console.WriteLine("|                                                                          | ");
                    Console.WriteLine("|  SES DÜZEYİ                                                              | "+" - 5");
                    Console.WriteLine("|                                                                          | ");
                    Console.WriteLine("|  ZAR ATMA OYUNU                                                          | "+" - 6");
                    Console.WriteLine("|                                                                          | ");
                    Console.WriteLine("|  YILAN OYUNU                                                             | "+" - 7");
                    Console.WriteLine("|                                                                          | ");
                    Console.WriteLine("|                                                                          | ");
                    Console.WriteLine("|                                                                          | ");
                    Console.WriteLine("|                                                                          | ");
                    Console.WriteLine("| ------------------------------------------------------------------------ |");
                    Console.WriteLine("|                                                                          | ");
                    Console.WriteLine("| --------------------------------  O ------------------------------------ |");
                    Console.WriteLine("");
                    Console.Write(" Seçiniz : ");
                    int secim3 = Convert.ToInt32(Console.ReadLine());

                    if(secim3 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("");

                        Console.WriteLine("| --------------------------------------------------------------------- |");
                        Console.WriteLine("             Aramak İstediğiniz Filtreyi Giriniz");
                        Console.WriteLine("| --------------------------------------------------------------------- |");
                        goto a;

                    }
                    if(secim3 == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine(" | - - - - - - |");
                        Console.WriteLine(" |    ◯  ◯     |");
                        Console.WriteLine(" |      *      |");
                        Console.WriteLine(" | - - - - - - |");
                        Console.WriteLine("");
                        Console.WriteLine(" Kullanıcı : Janset");
                        Console.WriteLine("");
                        Console.WriteLine(" IOMTAL'DE OKUYOR.");
                        Console.WriteLine("");
                        goto a;
                    }
                    if(secim3 == 3)
                    {

                    }
                    if(secim3 == 4)
                    {

                    }
                    if(secim3 == 5)
                    {
                        sesDuzeyi();
                    }
                }
                
            }
            public void donanımGöster()
            {
                Console.WriteLine("    MASAÜSTÜ   ");
                Console.WriteLine("");
                Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - -  - - - - - ");
                Console.WriteLine("");
                Console.WriteLine(" RAM : 8GB");
                Console.WriteLine("");
                Console.WriteLine(" İşlemci : AMD RYZEN 5 5500");
                Console.WriteLine("");
                Console.WriteLine(" EkranKartı : MSI Radeon RX 6500 XT MECH 2X 4G OC 4GB 64Bit GDDR6");
                Console.WriteLine("");
                Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - -  - - - - - ");
            }
           public void sesDuzeyi()
            {
                Console.WriteLine(" Ses 〈 0 〉 ");
                Console.WriteLine("");
                Console.WriteLine(" Ses Düzeyini Arttırmak İçin + Ya Basınız.");
                string ses = Console.ReadLine();
                if(ses == "+" )
                {
                    Console.WriteLine(" Ses 〈 15 〉");
                    Console.WriteLine("");
                    Console.WriteLine(" SES ARTTIRILDI.");
                }
            }
        }
        static void Main(string[] args)
        {
            Bilgisayar blg = new Bilgisayar();
            Console.WriteLine("");
            Console.WriteLine("     VATAN PC  ");
            Console.WriteLine("");
            blg.acKapat();

            Console.ReadKey();
        }
    }
}
