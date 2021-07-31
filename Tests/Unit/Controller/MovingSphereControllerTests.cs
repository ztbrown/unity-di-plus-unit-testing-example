using NUnit.Framework;
using UnityEngine;
using System;

namespace Tests.NUnit
{
    [TestFixture]
    public class MovingSphereControllerTests
    {
        private MovingSphereController _controller;

        [Test]
        public void UpdatePosition_ReceivesPlayerInput0f0fAndReturnsNoChangeInDisplacement()
        {
            _controller = new MovingSphereController();

            Vector2 input = new Vector2(0f,0f);

            var result = _controller.UpdatePosition(input);

            Assert.AreEqual(0f, result.x);
            // the ball floats up 0.5 in the y direction
            Assert.AreEqual(0.5f, result.y);
            Assert.AreEqual(0f, result.z);
        }

        [TestCase(1, 0)]
        [TestCase(0, 1)]
        public void UpdatePosition_ReceivesPlayerInputAndReturnsChangeInDisplacement(float x, float y)
        {
            _controller = new MovingSphereController();

            Vector2 input = new Vector2(x,y);

            var result = _controller.UpdatePosition(input);

            Assert.AreEqual(x, result.x);
            // the ball floats up 0.5 in the y direction
            Assert.AreEqual(0.5f, result.y);
            Assert.AreEqual(y, result.z);
        }

        [Test]
        public void UpdatePosition_ItNormalizesTheVector() 
        {
            _controller = new MovingSphereController();

            Vector2 input = new Vector2(1,1);

            var result = _controller.UpdatePosition(input);

            Assert.AreEqual((float)(Math.Sqrt(Math.Pow(input.x, 2.0) + Math.Pow(input.y, 2.0)) / 2.0), result.x);
        }
    }
}