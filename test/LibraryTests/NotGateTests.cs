using System;
using NUnit.Framework;

namespace Ucu.Poo.Exercise
{
    public class NotGateTests
    {
        [TestCase(true, false)]
        [TestCase(false, true)]
        public void Output_GivenInput_ReturnsExpectedResult(bool input, bool expected)
        {
            // Arrange
            ILogicValue Input;
            if (input) 
            {
                Input = new TrueValue();
            }
            else 
            {
                Input = new FalseValue();
            }

            // Act
            NotGate notGate = new NotGate(Input);

            // Assert
            Assert.That(notGate.Output, Is.EqualTo(expected));
        }
    }
}