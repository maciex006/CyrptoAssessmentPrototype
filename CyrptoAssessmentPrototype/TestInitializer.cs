using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrptoAssessment
{
    class TestInitializer
    {
        internal List<Test> Invoke(TestTypes tests, List<EncriptionData> data)
        {
            if((tests & TestTypes.KeyLength) != 0)
            {
                Test bitBalanceTest = new BitBalanceTest(data.Where(x => (x.TestType & TestTypes.KeyLength) != 0));
            }

            if((tests & TestTypes.BitBalance) != 0)
            {
                Test bitBalanceTest = new BitBalanceTest(data.Where(x => (x.TestType & TestTypes.BitBalance) != 0));
            }

            if((tests & TestTypes.Nonlinearity) != 0)
            {
                Test bitBalanceTest = new BitBalanceTest(data.Where(x => (x.TestType & TestTypes.Nonlinearity) != 0));
            }

            // Tutaj uzupełnić też pola list EncriptionData w każdym z testów (jakoś sensownie żeby nie powtarzać instrukcji)
            //TODO: implement.
            return new List<Test>();
        }
    }
}
