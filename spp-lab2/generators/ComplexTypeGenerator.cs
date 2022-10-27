using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace spp_lab2.generators
{
    public class ComplexTypeGenerator : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return true;
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            var constructors = typeToGenerate.GetConstructors().ToList()
            .OrderByDescending(c => c.GetParameters().Length).ToList();
            var instance = constructors[0].Invoke(constructors[0].GetParameters().Select(p => context.Faker.Create(p.ParameterType)).ToArray());

            var fields = instance.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var field in fields)
            {
                if (!field.IsInitOnly)
                {
                    field.SetValue(instance, context.Faker.Create(field.FieldType));
                }
            }
            var properties = instance.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var property in properties)
            {
                if (property.CanWrite)
                {
                    property.SetValue(instance, context.Faker.Create(property.PropertyType));
                }
            }
            return instance;
        }
    }
    
}
