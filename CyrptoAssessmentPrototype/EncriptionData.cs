using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrptoAssessment
{
    /// <summary>
    ///     Class representing a plaintext, cyphertext pair, along with key and information
    ///     of what test type is using that pair.
    /// </summary>
    class EncriptionData
    {
        internal EncriptionData(byte[] plainText, byte[] cypherText, byte[] key, TestTypes testType)
        {
            PlainText = plainText;
            CypherText = cypherText;
            Key = key;
            TestType = testType;
        }

        internal byte[] PlainText { get; private set; }
        internal byte[] CypherText { get; private set; }
        internal byte[] Key { get; private set; }
        internal TestTypes TestType { get; private set; }
    }
}
