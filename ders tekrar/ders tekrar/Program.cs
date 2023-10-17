using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_tekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, i, maks = 0, imaks = 0, puan, toplam = 0, imin = 0, min = 100;
            Console.WriteLine("öğrenci sayısı: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (i =1; i <= sayi; i++)
            {
                Console.WriteLine("{0}.öğrencinin notu",i);
                puan= Convert.ToInt32(Console.ReadLine());
                if (puan < 0 || puan > 100)
                {
                    Console.WriteLine("hatalı not girdiniz");
                    i--;
                }
                else
                {
                    toplam = toplam + puan;
                    if (puan > maks)
                    {
                        maks = puan;
                        imaks = i;
                    }
                    if (puan < min)
                    {
                        min = puan;
                        imin = i;
                    }


                }

            }
            Console.WriteLine("ortalama={0}",(float)toplam/sayi);
            Console.WriteLine("en yüksek not{0}. sıradaki    {1}puan",imaks,maks);
            Console.WriteLine("en düşük not{0}. sıradaki    {1}puan",imin,min);
            Console.ReadLine();

        }
    }
}
