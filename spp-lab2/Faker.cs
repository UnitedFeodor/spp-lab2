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
        private Dictionary<Type, int> _createdTypes = new();
        private const int _maxDepth = 2;

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
            // cycle check
            if(!isMaxDepthAndAdd(type)) { return null; }

            var obj = _valueGenerators.FirstOrDefault(g => g.CanGenerate(type), new ComplexTypeGenerator())
            .Generate(type, _generatorContext);

            removeType(type);
            return obj;
        }

        private bool isMaxDepthAndAdd(Type type)
        {
            if (_createdTypes.ContainsKey(type))
            {
                _createdTypes[type]++;
            }
            else
            {
                _createdTypes.Add(type, 1);
            }

            return _createdTypes[type] <= _maxDepth;

        }

        private void removeType(Type type)
        {
            _createdTypes[type]--;
        }
    }
}
