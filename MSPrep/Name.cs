using System.Collections.Generic;
using System.Linq;

namespace Test
{
    public class Name : IMSPrep
    {
        public string GetName(string name)
        {
            return name;
        }

        public List<string> SplitName(string myName)
        {
            return myName.Split(" ").ToList();
        }

        public bool CheckTest()
        {
            return true;
        }
    }
}