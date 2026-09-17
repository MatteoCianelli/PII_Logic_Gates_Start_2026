using System;
using NUnit.Framework;

namespace Ucu.Poo.Exercise
{
    public class GateValueTests
    {
        [TestCase(true, false)]
        [TestCase(false, true)]
        public void Value_WhenGivenInput_ReturnsExpectedResult(bool input, bool expected)
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
            NotGate notGate = new NotGate(Input);

            // Act
            GateValue gateValue = new GateValue(notGate);

            // Assert
            Assert.That(gateValue.Value, Is.EqualTo(expected));
        }
    }
}