using NUnit.Framework;
using UnityEngine;

namespace Tests.NUnit
{
    [TestFixture]
    public class GreeterTests
    {
        private Greeter _greeter;

        [Test]
        public void TheGreeterSaysHelloWorld()
        {
            _greeter = new Greeter("hello");

            var result = _greeter.sayHello();

            Assert.AreEqual(result, "hello");
        }
    }
}