using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyrptoAssessment.Generators;

namespace CyrptoAssessment
{
    class EncriptionDataGenerator
    {
        private IEncriptable m_Algorithm;

        internal EncriptionDataGenerator(IEncriptable alg)
        {
            m_Algorithm = alg;
        }

        internal List<EncriptionData> Invoke(TestTypes tests)
        {
            List<EncriptionData> enc = new List<EncriptionData>();

            if ((tests & TestTypes.BitBalance) != 0)
            {
                enc.AddRange(RandomGenerator.Invoke(Configuration.BalanceGenPairs, m_Algorithm));
            }

            if ((tests & TestTypes.Nonlinearity) != 0)
            {
                enc.AddRange(RandomGenerator.InvokeGeneratedKeys(
                    Configuration.NonlinGenPars,
                    Configuration.NonlinGenKeys, 
                    m_Algorithm));
            }

            if ((tests & TestTypes.SacInput) != 0)
            {
                enc.AddRange(SacGenerator.InvokeGeneratedKeys(Configuration.SacInputGenKeys, m_Algorithm));
            }

            if ((tests & TestTypes.SacKey) != 0)
            {
                enc.AddRange(SacGenerator.InvokeGeneratedInputs(Configuration.SacKeyGenInputs, m_Algorithm));
            }

            return enc;

            // asynchronicznie?
        }
    }
}
