using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spp_lab2.generators
{
    public class ListGenerator : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            var list = (IList)Activator.CreateInstance(typeToGenerate);
            for (int i = 0; i < context.Random.Next(5, 50); i++)
                list.Add(context.Faker.Create(typeToGenerate.GetGenericArguments()[0]));

            return list;
        }
    }
}
