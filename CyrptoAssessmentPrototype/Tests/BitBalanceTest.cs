using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrptoAssessment
{
    class BitBalanceTest : Test
    {
        // Dummy implementation - do przemyślenia i poprawy - tymczasowe dla testów.
        BitBalanceTest(List<EncriptionData> pairs)
        {
            this.Pairs = pairs;
            this.Type = TestTypes.BitBalance;
        }

        internal override void Perform()
        {
            int countOnes = 0;
            int countAll = 0;
            foreach (var output in Pairs.Select(x => x.CypherText))
            {
                countAll += output.Length * 8;

                foreach (var b in output)
                {
                    countOnes += Bitcount(b);
                }
            }

            Result = Math.Abs(0.5 - ((float)countOnes / countAll));
        }

        private int Bitcount(byte input)
        {
            int count = 0;
            while (input != 0)
            {
                count++;
                input &= (byte)(input - 1);
            }
            return count;
        }
    }
}
