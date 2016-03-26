using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyrptoAssessment.Generators;

namespace CyrptoAssessment
{
    class EncriptionDataGenerator
    {
        private IEncriptable Algorithm;

        internal EncriptionDataGenerator(IEncriptable alg)
        {
            Algorithm = alg;
        }

        internal List<EncriptionData> Invoke(TestTypes tests)
        {
            // To można by dać do pliku konfiguracyjnego:
            // 30k losowych par dla zrównoważenia.
            // 5k losowych par dla 20 x różnych kluczy dla nieliniowości.
            // input.Length sekwencji SAC dla 20 x różnych kluczy dla SACinput
            // key.Length sekwencji SAC dla 20 x różnych wejść dla SACkey


            Random r = new Random();
            byte[] key = new byte[Algorithm.KeySize];
            r.NextBytes(key);
            List<EncriptionData> enc = SacGenerator.InvokeFixedInput(Algorithm, key);
            return RandomGenerator.Invoke(30000, Algorithm, tests);

            // asynchronicznie?
        }
    }
}
