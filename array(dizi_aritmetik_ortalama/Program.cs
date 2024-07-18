using System;

namespace array_dizi_aritmetik_ortalama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n degerini giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] X = new Dizi().Olustur(n);

            Console.WriteLine("Dizinin AritmetikOrtalaması: {0:F2}", Dizi.AritmetikOrtalama(X));
        }
    }
}
