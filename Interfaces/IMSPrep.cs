using System;
using System.Collections.Generic;

namespace Test
{
    public interface IMSPrep
    {
        string GetName(string name);

        List<string> SplitName(string myName);

        bool CheckTest();
    }
}