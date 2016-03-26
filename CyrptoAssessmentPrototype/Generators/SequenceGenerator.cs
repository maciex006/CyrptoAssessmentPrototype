using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrptoAssessment.Generators
{
    static class SequenceGenerator
    {
        private static Random pseudoRandomGenerator = new Random(); // Czy tego nie wywalić wyżej albo zaseedować.

        internal static void Invoke(byte[] input)
        {
            pseudoRandomGenerator.NextBytes(input);
        }
    }
}
