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
        public string Text;
        public bool Check { get; set; }
        public static int Static { get; set; }

        public Class2 SameClass;

        /*
        public Class2(Class2 sameClass)
        {
            SameClass = sameClass;
        }
        */
        public Class2(int number, string text)
        {
            Number = number;
            Text = text;
        }
    }
}
