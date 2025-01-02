using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace hafta3
{
    internal class Program
    {
        /*
          Soru 2 - Hazır Metod Kullanımı 
          Kullanıcıdan bir cümle girmesini isteyin ve bu cümledeki kelime sayısını hesaplayıp 
          ekrana yazdıran bir program yazınız. 
          Kelime sayısını hesaplamak için Split() metodunu kullanabilirsiniz.
          */

        static void Main(string[] args)
        {
            
            Console.Write("Lütfen bir cümle giriniz: ");
            string cumle = Console.ReadLine();

            
            string[] kelimeler = cumle.Split(' ');

            
            int kelimeSayisi = kelimeler.Length;

            
            Console.WriteLine($"Girdiğiniz cümledeki kelime sayısı: {kelimeSayisi}");
            Console.ReadKey()
        }

    }

}

