using System;
using System.Numerics;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool save = false;
            BigInteger big = 2;
            
            while(!save)
            {


                try
                {

                    big*=big;
                    Console.WriteLine("\n\n\n\n");
                    Console.WriteLine(big);
                }
                catch(OutOfMemoryException)
                {
                    Console.WriteLine("ERROR MEMORY");
                    save = true;
                }
                catch
                {
                    Console.WriteLine("ERROR");
                    save = true;
                }
                
            }
            Console.ReadLine();
        }
    }
}
