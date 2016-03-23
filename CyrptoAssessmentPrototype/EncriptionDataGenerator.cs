using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // TODO: implement.
            return new List<EncriptionData>();
        }
    }
}
