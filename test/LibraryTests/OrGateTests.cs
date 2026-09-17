using System;
using NUnit.Framework;

namespace Ucu.Poo.Exercise
{
    public class OrGateTests
    {
        [TestCase(true, true, true)]
        [TestCase(true, false, true)]
        [TestCase(false, true, true)]
        [TestCase(false, false, false)]
        public void Output_GivenVariousInputs_ReturnsExpectedResult(bool input1, bool input2, bool expected)
        {
            // Arrange
            ILogicValue Input1;
            ILogicValue Input2;
            if (input1) 
            {
                Input1 = new TrueValue();
            }
            else 
            {
                Input1 = new FalseValue();
            }
            if (input2)
            {
                Input2 = new TrueValue();
            }
            else
            {
                Input2 = new FalseValue();
            }

            // Act
            OrGate orGate = new OrGate(Input1, Input2);

            // Assert
            Assert.That(orGate.Output, Is.EqualTo(expected));
        }
    }
}