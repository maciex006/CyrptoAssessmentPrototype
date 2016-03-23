using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrptoAssessment
{
    abstract class Test
    {
        private TestTypes _type;

        internal TestTypes Type
        {
            get
            {
                return _type;
            }
            set
            {
                int val = (int)value;
                if (val != 1 && val % 2 != 0)
                {
                    throw new Exception("Cannot assign multiple test types to the test instance.");
                }
                else
                {
                    _type = value;
                }
            }
        }

        internal double Result { get; set; }
        public List<EncriptionData> Pairs { protected get; set; }
        internal abstract void Perform();
    }
}
