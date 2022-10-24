using spp_lab2.generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spp_lab2
{
    public class Faker : IFaker
    {
        private readonly GeneratorContext _generatorContext;
        private readonly List<IValueGenerator> _valueGenerators;
        // cycle check needed

        public Faker()
        {
            _generatorContext = new GeneratorContext(new Random(),this);
            _valueGenerators = new List<IValueGenerator>()
            {
                new BoolGenerator(),
                new ByteGenerator(),
                new CharGenerator(),
                new DateTimeGenerator(),
                new DecimalGenerator(),
                new DoubleGenerator(),
                new FloatGenerator(),
                new IntGenerator(),
                new LongGenerator(),
                new ShortGenerator(),

                new StringGenerator(),
                new ListGenerator(),
                new ComplexTypeGenerator()
            }; ;
        }
        public T Create<T>()
        {
            return (T)Create(typeof(T));
        }

        public object Create(Type type)
        {
            throw new NotImplementedException();
        }
    }
}
