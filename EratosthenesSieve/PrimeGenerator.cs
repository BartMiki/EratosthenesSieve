using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EratosthenesSieve
{
    class PrimeGenerator
    {
        private static bool[] _crossedOuts;

        public static List<int> GeneratePrimes(int range)
        {
            CreateSieve(range);
            RunSieve();
            return ReadPrimesFromSieve();
        }

        private static void CreateSieve(int size)
        {
            _crossedOuts = new bool[size + 1];
            for (int i = 0; i < _crossedOuts.Length; i++)
            {
                _crossedOuts[i] = false;
            }
        }

        private static void RunSieve()
        {
            int iterationLimit = CalculateIterationLimit();
            for (int i = 2; i < iterationLimit; i++)
            {
                if (_crossedOuts[i] == false)
                    CrossOutMultiplesOf(i);
            }
        }

        private static List<int> ReadPrimesFromSieve()
        {
            var _primeNumbers = new List<int>();
            for (int i = 2; i < _crossedOuts.Length; i++)
            {
                if (_crossedOuts[i] == false)
                    _primeNumbers.Add(i);
            }

            return _primeNumbers;
        }

        private static int CalculateIterationLimit()
        {
            return (int)Math.Sqrt(_crossedOuts.Length);
        }

        private static void CrossOutMultiplesOf(int number)
        {
            for (int i = 2; number * i < _crossedOuts.Length; i++)
            {
                int indexToCrossOut = i * number;
                _crossedOuts[indexToCrossOut] = true;
            }
        }
    }
}
