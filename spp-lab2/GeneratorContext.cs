﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spp_lab2
{
    public class GeneratorContext
    {
        
        public Random Random { get; }

        
        public Faker Faker { get; }

        public GeneratorContext(Random random, IFaker faker)
        {
            Random = random;
            Faker = (Faker?)faker;
        }
    }
}
