using NUnit.Framework;
using spp_lab2;
using System;
using System.Collections;
using System.Collections.Generic;

namespace faker.tests
{
    public class UnitTest1
    {
        private IFaker _faker;

        [SetUp]
        public void Setup()
        {
            _faker = new Faker();
        }

		[Test]
		[TestCase(typeof(int))]
		[TestCase(typeof(double))]
		[TestCase(typeof(char))]
		[TestCase(typeof(string))]
		[TestCase(typeof(float))]
		[TestCase(typeof(long))]
		[TestCase(typeof(DateTime))]
		public void Primitives_DoesNotThrow(Type t)
		{
			Assert.DoesNotThrow(() => _faker.Create(t));
		}

		[Test]
		[TestCase(typeof(List<int>))]
		[TestCase(typeof(List<double>))]
		[TestCase(typeof(List<char>))]
		[TestCase(typeof(List<string>))]
		[TestCase(typeof(List<float>))]
		[TestCase(typeof(List<long>))]
		public void List_DoesNotThrow(Type t)
		{
			Assert.DoesNotThrow(() => _faker.Create(t));
			Assert.IsNotEmpty((IList)_faker.Create(t));
		}

        [Test]
        [TestCase(typeof(DateTime))]
        [TestCase(typeof(byte))]
        [TestCase(typeof(short))]
        [TestCase(typeof(int))]
        [TestCase(typeof(long))]
        [TestCase(typeof(float))]
        [TestCase(typeof(double))]
        [TestCase(typeof(decimal))]
        [TestCase(typeof(string))]
        [TestCase(typeof(bool))]
        [TestCase(typeof(char))]
        [TestCase(typeof(Class1))]
        
        [TestCase(typeof(Class2))]
        [TestCase(typeof(List<List<int>>))]

        public void CreatePrimitiveTest(Type type)
        {
            Assert.DoesNotThrow(() => _faker.Create(type));
        }
    }
}