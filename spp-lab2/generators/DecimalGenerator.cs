using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spp_lab2.generators
{
    internal class DecimalGenerator : IValueGenerator
    {
        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            int lo = context.Random.Next(0, int.MaxValue);
            int mid = context.Random.Next(0, int.MaxValue);
            int hi = context.Random.Next(0, int.MaxValue);
            bool isNegative = context.Random.Next(0, 2) == 1;
            byte scale = (byte)context.Random.Next(0, 29);
            return new decimal(lo, mid, hi, isNegative, scale);
        }

        public bool CanGenerate(Type type)
        {
            return type == typeof(decimal);
        }
    } 
}
