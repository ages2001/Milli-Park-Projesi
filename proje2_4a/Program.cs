using System;
using System.Collections.Generic;
using System.Collections;

namespace proje2_4a
{
    class Program
    {
        static TamsayiKuyruk urunKuyrugu = new TamsayiKuyruk();

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            const int URUN_OKUMA_SURESI = 3;

            urunTamsayilariEkle();

            int listSize = urunKuyrugu.Size(), toplamSure = 0, musteriSuresi = 0, count = 0;

            while (!urunKuyrugu.isEmpty())
            {
                count++;
                musteriSuresi += urunKuyrugu.Dequeue() * URUN_OKUMA_SURESI;
                Console.WriteLine("{0}. musterinin islem tamamlanma suresi: {1} saniye", count, musteriSuresi);
                toplamSure += musteriSuresi;
            }

            double ortSure = (double)toplamSure / listSize;
            Console.WriteLine("\nOrtalama islem tamamlanma suresi: {0:0.00} saniye", ortSure);
        }

        static void urunTamsayilariEkle()
        {
            urunKuyrugu.Enqueue(8);
            urunKuyrugu.Enqueue(9);
            urunKuyrugu.Enqueue(6);
            urunKuyrugu.Enqueue(7);
            urunKuyrugu.Enqueue(10);
            urunKuyrugu.Enqueue(1);
            urunKuyrugu.Enqueue(11);
            urunKuyrugu.Enqueue(5);
            urunKuyrugu.Enqueue(3);
            urunKuyrugu.Enqueue(4);
            urunKuyrugu.Enqueue(2);
        }
    }
}
