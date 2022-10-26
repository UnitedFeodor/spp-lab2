using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spp_lab2.generators
{
    public class ShortGenerator : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(short);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            return (short)context.Random.Next(short.MinValue, short.MaxValue + 1);
        }
    }
}
