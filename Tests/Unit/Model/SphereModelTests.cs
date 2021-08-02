using NUnit.Framework;
using UnityEngine;
using System;

namespace Tests.NUnit
{
    [TestFixture]
    public class SphereModelTests
    {
        private SphereModel _model;

        [SetUp]
        public void SetUp()
        {
            _model = new SphereModel();
            _model.Awake(new Vector3(0f,0.5f,0f));
        }

        [Test]
        public void UpdatePosition_ReceivesPlayerInput0f0fAndReturnsNoChangeInDisplacement()
        {
            Vector2 input = new Vector2(0f,0f);

            var result = _model.UpdatePosition(input);

            Assert.AreEqual(0f, result.x);
            // the ball floats up 0.5 in the y direction
            Assert.AreEqual(0.5f, result.y);
            Assert.AreEqual(0f, result.z);
        }

        [TestCase(1, 0)]
        [TestCase(0, 1)]
        public void UpdatePosition_ReceivesPlayerInputAndReturnsChangeInDisplacement(float x, float y)
        {
            Vector2 input = new Vector2(x,y);

            var result = _model.UpdatePosition(input);

            Assert.AreEqual(x, result.x);
            // the ball floats up 0.5 in the y direction
            Assert.AreEqual(0.5f, result.y);
            Assert.AreEqual(y, result.z);
        }

        [Test]
        public void UpdatePosition_ItClampsTheInput() 
        {
            Vector2 input = new Vector2(1,1);

            var result = _model.UpdatePosition(input);

            Assert.AreEqual((float)(Math.Sqrt(Math.Pow(input.x, 2.0) + Math.Pow(input.y, 2.0)) / 2.0), result.x);
        }

        [Test]
        public void UpdatePosition_AddsDisplacementVectorToPreviousPosition()
        {
            Vector2 input = new Vector2(1,1);
            Vector2 clamped = Vector2.ClampMagnitude(input, 1f);
            Vector3 expected = new Vector3(0f,0.5f,0f);
            expected += new Vector3(clamped.x, 0f, clamped.y) + new Vector3(clamped.x, 0f, clamped.y);

            _model.UpdatePosition(input);

            var result = _model.UpdatePosition(input);

            Assert.AreEqual(expected, result);
        }
    }
}
