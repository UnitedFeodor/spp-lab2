﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spp_lab2.generators
{
    public class DateTimeGenerator : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(DateTime);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            return new DateTime(
                year: context.Random.Next(1, 10000),
                month: context.Random.Next(1, 13),
                day: context.Random.Next(1, 29),
                hour: context.Random.Next(0, 24),
                minute: context.Random.Next(0, 60),
                second: context.Random.Next(0, 60),
                millisecond: context.Random.Next(0, 1000)
            );
        }
    }
}
