using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrptoAssessment.Tests
{
    class BitBalanceTest : Test
    {
        // Dummy implementation - do przemyślenia i poprawy - tymczasowe dla testów.
        // Impl najlepiej w C :(
        internal BitBalanceTest(IEnumerable<EncriptionData> pairs)
        {
#if DEBUG
            Console.WriteLine(this.ToString() + " run with " + pairs.Count() + " samples.");
#endif
            this.Pairs = pairs;
            this.Type = TestTypes.BitBalance;
        }

        internal override void Perform()
        {
            Stopwatch sw = Stopwatch.StartNew();
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
            sw.Stop();
            Result = new TestResult(this, Pairs.Count(), sw.Elapsed, Math.Abs(0.5 - ((float)countOnes / countAll)));
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
