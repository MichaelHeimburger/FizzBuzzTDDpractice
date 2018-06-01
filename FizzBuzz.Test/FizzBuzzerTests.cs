using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Test
{
    [TestFixture] // click on this first and select using n unit framework
    class FizzBuzzerTests
    {
        [Test]
        public void Get_Returns_1_for_1()
        {
            var fizzBuzzer = new FizzBuzzer();
            // first you need to make a class to satisfy the previous red line, then you need to set it public to satisfy
            var result = fizzBuzzer.Get(1);
            // write a method in fizzbuzzer called Get, set it to public, then set an empty string
            Assert.That(result, Is.EqualTo("1"));
            //should come up with no build errors but a failed test, 
        }
        [Test]
        public void Get_Returns_2_for_2()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(2);

            Assert.That(result, Is.EqualTo("2"));
        }
        [Test]
        public void Get_Returns_Fizz_for_3()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void for_mul_3()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(6);

            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void Get_Returns_Fizz_for_4()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(4);

            Assert.That(result, Is.EqualTo("4"));
        }
        [Test]
        public void Get_Returns_Fizz_for_5()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(5);
            // added if for == 5
            Assert.That(result, Is.EqualTo("Buzz"));

        }
        [Test]
        public void for_mul_5()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(10);
            // changed if to mod 5 ==
            Assert.That(result, Is.EqualTo("Buzz"));
        }
        [Test]
        public void for_mul_3and5()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(15);
            // changed if to mod 5 ==
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
        [Test]
        public void for_mul_3and52()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(30);
            // changed if to mod 5 ==
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

    }
}
