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
    }
}
