using System;

namespace collatz_chain
{
    class Program
    {
        static void Main(string[] args)
        {
            long  best_sayi = 0,zincir=0,best=0;
            for (long i = 1000000; i > 1; i--)
            {
                long n = i;
                do {
                    if (n % 2 == 0)
                    {
                        n /= 2;
                        zincir++;
                    }
                    else 
                    {
                        if (n % 2 == 1 && n != 1)
                        {
                            n = n * 3 + 1;
                            zincir++;
                        } 
                    }
                } while (n != 1);
                if (best < zincir)
                {
                    best = zincir;
                    best_sayi =i;
                    zincir = 0;
                }
                else zincir =0;
            }
            Console.WriteLine("en uzun zincir:"+best);
            Console.WriteLine("en büyük sayı:"+best_sayi);
            Console.Read();
        }
    }
}
