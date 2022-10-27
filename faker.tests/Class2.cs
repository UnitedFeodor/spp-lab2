using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faker.tests
{
    public class Class2
    {
        public int Number;
        public string String;

        public Class2 SameClass;

        public Class2(int number, string @string)
        {
            Number = number;
            String = @string;
        }

        public Class2(Class2 sameClass)
        {
            SameClass = sameClass;
        }
    }
}
