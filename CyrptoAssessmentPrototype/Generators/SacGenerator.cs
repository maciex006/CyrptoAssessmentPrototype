using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrptoAssessment.Generators
{
    class SacGenerator
    {
        internal static List<EncriptionData> InvokeFixedKey(IEncriptable Algorithm, byte[] key)
        {
            // Dodać unique key id generator.
            byte[] input = new byte[Algorithm.BlockSize];
            byte[] shifts = new byte[9] { 0, 1, 2, 4, 8, 16, 32, 64, 128 };
            List<EncriptionData> output = new List<EncriptionData>();

            for(int i = 0; i < Algorithm.BlockSize; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    input[i] += shifts[j];
                    Algorithm.Input = input;
                    Algorithm.Key = key;
                    Algorithm.Run();
                    output.Add(new EncriptionData(input, Algorithm.Output, key, TestTypes.SacInput));
                }
            }

            return output;
        }

        internal static List<EncriptionData> InvokeFixedInput(IEncriptable Algorithm, byte[] input)
        {
            byte[] key = new byte[Algorithm.KeySize];
            byte[] shifts = new byte[9] { 0, 1, 2, 4, 8, 16, 32, 64, 128 };
            List<EncriptionData> output = new List<EncriptionData>();

            for (int i = 0; i < Algorithm.BlockSize; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    key[i] += shifts[j];
                    try
                    {
                        Algorithm.Input = input;
                        Algorithm.Key = key;
                        Algorithm.Run();
                        output.Add(new EncriptionData(input, Algorithm.Output, key, TestTypes.SacInput));
                    }
                    catch (Exception)
                    {
                        // Do nothing.
                    }
                    
                }
            }

            return output;
        }
    }
}
