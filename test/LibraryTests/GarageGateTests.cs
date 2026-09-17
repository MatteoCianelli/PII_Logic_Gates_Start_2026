using System;
using NUnit.Framework;

namespace Ucu.Poo.Exercise
{
    public class GarageGateTests
    {
        [TestCase(true, true, true, true)]
        [TestCase(true, true, false, false)]
        [TestCase(true, false, true, false)]
        [TestCase(true, false, false, false)]
        [TestCase(false, true, true, false)]
        [TestCase(false, true, false, false)]
        [TestCase(false, false, true, true)]
        [TestCase(false, false, false, false)]
        public void Open_GivenVariousInputs_ReturnsExpectedResult(bool inputA, bool inputB, bool inputC, bool expected)
        {
            // Arrange
            GarageGate garageGate = new GarageGate();

            // Act
            bool actual = garageGate.Open(inputA, inputB, inputC);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}