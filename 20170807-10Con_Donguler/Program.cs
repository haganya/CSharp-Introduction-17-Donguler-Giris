using System;
using System.Threading;
 

namespace _20170807_10Con_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aynı kodu belli bir mantığa göre birden fazla kez çalıştırılması gerektiği durumlarda döngüler karşımıza çıkmaktadır.
             * 
             * While , DoWhile , For , Foreach olmak üzere 4 adet döngü tipi mevcuttur.
             * 
             */

            // Console.Write("Merhaba dünya"); // örn. bu kodun belli bir miktarda çalışması isteniyor.
            /*
             
            while(koşul)
            {
            koşul true ise yapılacak işlemler.
            }
             
             */


            Console.Write("Kaç kere \"Merhaba Dünya\" yazayım ? : ");
            int adet = int.Parse(Console.ReadLine());
            int sayac = 0;
            while (sayac < adet)
            {
                sayac++;
                Thread.Sleep(1000);
                Console.WriteLine("Merhaba dünya {0}",sayac);
                
            }
            Console.Read();

        }
    }
}
