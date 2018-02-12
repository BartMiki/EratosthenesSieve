using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EratosthenesSieve
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int range = Int32.Parse(Console.ReadLine());
                var primes = PrimeGenerator.GeneratePrimes(range);
                foreach (var prime in primes)
                {
                    Console.Write("{0},", prime);
                }

                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Range must be integer value.");
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
