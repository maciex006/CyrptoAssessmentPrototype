using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrptoAssessment.Generators
{
    static class RandomGenerator
    {
        internal static List<EncriptionData> InvokeFixedKey(int reqDataCount, IEncriptable Algorithm, byte[] key, TestTypes testTypes)
        {
            Byte[] input = new Byte[Algorithm.BlockSize];
            List<EncriptionData> output = new List<EncriptionData>();

            for (int i = 0; i < reqDataCount; i++)
            {
                SequenceGenerator.Invoke(input);
                Algorithm.Input = input;
                Algorithm.Key = key;
                Algorithm.Run();
                output.Add(new EncriptionData(input, Algorithm.Output, key, testTypes));
            }

            return output;
        }

        internal static List<EncriptionData> InvokeFixedInput(int reqDataCount, IEncriptable Algorithm, byte[] input, TestTypes testTypes)
        {
            Byte[] key = new Byte[Algorithm.KeySize];
            List<EncriptionData> output = new List<EncriptionData>();

            for (int i = 0; i < reqDataCount; i++)
            {
                SequenceGenerator.Invoke(key);
                Algorithm.Input = input;
                Algorithm.Key = key;
                Algorithm.Run();
                output.Add(new EncriptionData(input, Algorithm.Output, key, testTypes));
            }

            return output;
        }

        internal static List<EncriptionData> Invoke(int reqDataCount, IEncriptable Algorithm, TestTypes testTypes)
        {
            Byte[] key = new Byte[Algorithm.KeySize];
            Byte[] input = new Byte[Algorithm.BlockSize];
            List<EncriptionData> output = new List<EncriptionData>();

            for (int i = 0; i < reqDataCount; i++)
            {
                SequenceGenerator.Invoke(input);
                SequenceGenerator.Invoke(key);
                Algorithm.Input = input;
                Algorithm.Key = key;
                Algorithm.Run();
                output.Add(new EncriptionData(input, Algorithm.Output, key, testTypes));
            }

            return output;
        }
    }
}
