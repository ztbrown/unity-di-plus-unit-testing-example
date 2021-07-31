using NUnit.Framework;
using UnityEngine;

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

            var result = _controller.UpdatePosition(0f,0f);

            Assert.AreEqual(result.x, 0f);
            // the ball floats up 0.5 in the y direction
            Assert.AreEqual(result.y, 0.5f);
            Assert.AreEqual(result.z, 0.0f);
        }

        [Test]
        public void UpdatePosition_ReceivesPlayerInput1f1fAndReturnsChangeInDisplacement()
        {
            _controller = new MovingSphereController();

            var result = _controller.UpdatePosition(1f,1f);

            Assert.AreEqual(result.x, 1f);
            // the ball floats up 0.5 in the y direction
            Assert.AreEqual(result.y, 0.5f);
            Assert.AreEqual(result.z, 1f);
        }
    }
}