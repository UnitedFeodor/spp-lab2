using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spp_lab2.generators
{
    public class FloatGenerator : IValueGenerator
	{
		public bool CanGenerate(Type type)
		{
			return type == typeof(float);
		}

		public object Generate(Type typeToGenerate, GeneratorContext context)
		{
			return context.Random.NextSingle();
		}
	}

}
