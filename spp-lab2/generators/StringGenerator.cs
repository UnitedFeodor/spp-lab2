using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spp_lab2.generators
{
    
    public class StringGenerator :IValueGenerator
    {
        private static char[] _chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_-=+~`'".ToCharArray();

        public bool CanGenerate(Type type)
        {
            return type == typeof(string);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            var builder = new StringBuilder();

            for (int i = 0; i < context.Random.Next(10, 101); i++)
                builder.Append(_chars[context.Random.Next(_chars.Length)]);

            return builder.ToString();
        }
    }
}
