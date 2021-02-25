using System;
using System.Numerics;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var save = false;
            BigInteger big = 2;
            
            while(!save)
            {
                try
                {
                    big = BigInteger.Pow(2, (int)big);

                    Console.WriteLine("\n\n\n\n");
                    Console.WriteLine(big);
                }
                catch(OutOfMemoryException)
                {
                    Console.WriteLine("ERROR MEMORY");
                    save = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    save = true;
                }
                
            }
            Console.ReadLine();
        }
    }
}
