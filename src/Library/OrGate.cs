namespace Ucu.Poo.Exercise
{
    public class OrGate : IGate
    {
        public ILogicValue Input1 { get; }

        public ILogicValue Input2 { get; }

        public bool Output
        {
            get { return this.Input1.Value || this.Input2.Value; }
        }

        public OrGate(ILogicValue input1, ILogicValue input2)
        {
            this.Input1 = input1;
            this.Input2 = input2;
        }
    }
}