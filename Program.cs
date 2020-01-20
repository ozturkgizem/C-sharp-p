using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kahin OYUNU";

            //repeat etmesi için kesin şart koyuldu.
            while(0==0)
            {
                Console.Clear();
                //1-99 arasında rastgele sayı tuttuk.
                Random rastgele = new Random();
                int sayi = rastgele.Next(1, 99);
                
                //döngü
                int i = 0;
                while ( i < 5 )
                {
                    //tahmin isteme
                    Console.Write("1-99 arasında bir sayı tahmin ediniz:");
                    int tahmin = int.Parse(Console.ReadLine());

                    if (tahmin > 1 && tahmin < 99)
                    {
                        if (sayi < tahmin)
                        {
                            if (i == 4)
                            {
                               Console.Write("Doğru cevap:{0}. Üzülmeyin, groot.\n", sayi);
                            }
                            else
                                Console.Write("Aşağı inin.");

                        }
                        else if (sayi > tahmin)
                        {
                            if (i == 4)
                            {
                                Console.Write("Doğru cevap:{0}. Üzülmeyin, groot.\n", sayi);
                            }
                            else
                                Console.Write("Yukarı çıkın.");
                        }
                        else if (sayi == tahmin)
                        {
                            Console.WriteLine("Doğru cevabı buldunuz, tebrikler.");
                            break;
                        }

                        i++;
                    }

                    else
                    {
                        Console.WriteLine("Sayınız verilen aralıkta değil.Lütfen kurallara uyun.");
                    }
                }

                Console.WriteLine("Lütfen tekrar oynamak için Enter'a basın.");
                Console.ReadLine();
 
            } 


        }
    }
}
