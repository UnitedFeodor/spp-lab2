using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spp_lab2.generators
{
    public class BoolGenerator : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(bool);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            return context.Random.Next(0, 2) != 0;
        }
    }
}
