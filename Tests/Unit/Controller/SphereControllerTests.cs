using NUnit.Framework;
using NSubstitute;
using UnityEngine;
using System;

namespace Tests.NUnit
{
    [TestFixture]
    public class MovingSphereControllerTests
    {
        private SphereController _controller;
        private ISphereModel _model;
        Vector2 input;
        Vector3 returnValue;
        
        [SetUp]
        public void SetUp() 
        {
            input = new Vector2(0f,0f);
            returnValue = new Vector3(input.x, 0.5f, input.y);
            _model = Substitute.For<ISphereModel>();
            _model.UpdatePosition(Arg.Any<Vector2>()).Returns(returnValue);
        }

        [Test]
        public void Update_ItCallsTheModelUpdate()
        {
            _controller = new SphereController(_model);

            var result = _controller.Update(input);

            Assert.AreEqual(returnValue, result);
            _model.Received().UpdatePosition(input);

        }
    }
}
