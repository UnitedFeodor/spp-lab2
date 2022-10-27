using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faker.tests
{
    public class Class1
    {
        public int Number;
        public string Text;
        public bool Check { get; set; }
        public static int Static { get; set; }

        public Class1(int number, string text)
        {
            Number = number;
            Text = text;
        }
    }
}
