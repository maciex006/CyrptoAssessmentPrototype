﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrptoAssessment
{
    static class Configuration
    {
        // To można by dać do pliku konfiguracyjnego:
        // 30k losowych par dla zrównoważenia.
        internal static int BalanceGenPairs = 30000;
        // 5k losowych par dla 20 x różnych kluczy dla nieliniowości.
        internal static int NonlinGenPars = 5000;
        internal static int NonlinGenKeys = 20;
        // input.Length sekwencji SAC dla 20 x różnych kluczy dla SACinput
        internal static int SacInputGenKeys = 20;
        // key.Length sekwencji SAC dla 20 x różnych wejść dla SACkey
        internal static int SacKeyGenInputs = 20;
        internal static TestTypes RandomGeneratorMapping = TestTypes.BitBalance;
        internal static TestTypes SacInputGeneratorMapping = TestTypes.BitBalance | TestTypes.SacInput;
        internal static TestTypes SacKeyGeneratorMapping = TestTypes.BitBalance | TestTypes.SacKey;
        internal static TestTypes RandomKeyGeneratorMapping = TestTypes.None;
        internal static TestTypes RandomInputGeneratorMapping = TestTypes.BitBalance | TestTypes.Nonlinearity;
    }
}
