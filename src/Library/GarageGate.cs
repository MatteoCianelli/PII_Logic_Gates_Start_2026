namespace Ucu.Poo.Exercise
{
    public class GarageGate
    {
        public bool Open(bool a, bool b, bool c)
        {
            bool result;
            ILogicValue inputA;
            ILogicValue inputB;
            ILogicValue inputC;

            if (a)
            {
                inputA = new TrueValue();
            }
            else
            {
                inputA = new FalseValue();
            }

            if (b)
            {
                inputB = new TrueValue();
            }
            else
            {
                inputB = new FalseValue();
            }

            if (c)
            {
                inputC = new TrueValue();
            }
            else
            {
                inputC = new FalseValue();
            }

            NotGate notGateA = new NotGate(inputA);
            NotGate notGateB = new NotGate(inputB);
            AndGate andGate1 = new AndGate(inputA, inputB);
            AndGate andGate2 = new AndGate(new GateValue(notGateA), new GateValue(notGateB));
            OrGate orGate = new OrGate(new GateValue(andGate1), new GateValue(andGate2));
            AndGate andGate3 = new AndGate(new GateValue(orGate), inputC);
            result = andGate3.Output;

            return result;
        }
    }
}