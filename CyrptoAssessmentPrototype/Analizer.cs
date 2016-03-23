using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrptoAssessment
{
    public class Analizer
    {
        private IEncriptable Algorithm;
        private EncriptionDataGenerator DataGenerator;
        private TestInitializer TestInitializer;
        private TestTypes InitializedTypes;
        private List<Test> Tests;
        private List<EncriptionData> EncData;

        public Analizer(IEncriptable alg)
        {
            Algorithm = alg;
            DataGenerator = new EncriptionDataGenerator(Algorithm);
            TestInitializer = new TestInitializer();
            InitializedTypes = TestTypes.None;
            Tests = new List<Test>();
            EncData = new List<EncriptionData>();
        }

        public void Run(TestTypes types)
        {
            int newTypes = types - InitializedTypes;
            TestTypes typesToInit = (newTypes > 0) ? (TestTypes)newTypes : TestTypes.None;
            EncData.AddRange(DataGenerator.Invoke(typesToInit));
            Tests.AddRange(TestInitializer.Invoke(typesToInit, EncData));
            InitializedTypes = (TestTypes)(InitializedTypes + newTypes);
            PerformTests();
        }

        public void GetResults()
        {
            // Tymczasowa implementacja:
            // Tu nie może być wyświetlania - na razie w celu debugu
            foreach (var test in Tests)
            {
                Console.WriteLine(test.Result);
            }
        }

        public void GetResults(TestTypes types)
        {
            // TODO
        }

        private void PerformTests()
        {
            foreach (var test in Tests)
            {
                test.Perform();
            }
        }
    }
}
