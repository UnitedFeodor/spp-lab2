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
		[TestCase(typeof(List<int>))]
		[TestCase(typeof(List<double>))]
		[TestCase(typeof(List<char>))]
		[TestCase(typeof(List<string>))]
		[TestCase(typeof(List<float>))]
		[TestCase(typeof(List<long>))]
        [TestCase(typeof(List<List<int>>))]
        public void ListDoesNotThrow(Type t)
		{
			Assert.DoesNotThrow(() => _faker.Create(t));
			Assert.IsNotEmpty((IList)_faker.Create(t));
		}

        [Test]
        
        [TestCase(typeof(bool))]
        [TestCase(typeof(byte))]
        [TestCase(typeof(char))]
        [TestCase(typeof(DateTime))]
        [TestCase(typeof(double))]
        [TestCase(typeof(decimal))]
        [TestCase(typeof(short))]
        [TestCase(typeof(int))]
        [TestCase(typeof(long))]
        [TestCase(typeof(float))]
        [TestCase(typeof(string))]
        public void PrimitivesDoesNotThrow(Type type)
        {
            Assert.DoesNotThrow(() => _faker.Create(type));

        }
        [Test]


        [TestCase(typeof(Class1))]
        [TestCase(typeof(Class2))]
        public void ComplexDoesNotThrow(Type type)
        {
            Assert.DoesNotThrow(() => _faker.Create(type));

        }

        [Test]
        public void NoConstructorObject()
        {
            Class1 testClass = _faker.Create<Class1>();

            Assert.Multiple(() =>
            {
                Assert.NotZero(testClass.Int);
                Assert.NotZero(testClass.Byte);
                Assert.NotNull(testClass.String);
                Assert.NotZero(Class1.Static);
            });
        }

        [Test]
        public void NestedAndManyConstructorsObject()
        {
            Class2 testClass = _faker.Create<Class2>();

            Assert.Multiple(() =>
            {
                Assert.NotZero(testClass.Number);
                Assert.NotZero(testClass.SameClass.Number);
                Assert.NotNull(testClass.String);
                Assert.NotNull(testClass.SameClass.String);
            });
        }

    }
}