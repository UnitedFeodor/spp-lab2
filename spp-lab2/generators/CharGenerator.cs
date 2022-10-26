using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spp_lab2.generators
{
    public class CharGenerator : IValueGenerator
	{
		private static char[] _chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_-=+~`'".ToCharArray();

		public bool CanGenerate(Type type)
		{
			return type == typeof(char);
		}
		public object Generate(Type typeToGenerate, GeneratorContext context)
		{
			return _chars[context.Random.Next(_chars.Length)];
		}
	
    }
}
