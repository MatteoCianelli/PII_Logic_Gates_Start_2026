namespace Ucu.Poo.Exercise
{
    public class NotGate : IGate
    {
        public ILogicValue Input { get; }

        public bool Output
        {
            get { return !this.Input.Value; }
        }

        public NotGate(ILogicValue input)
        {
            this.Input = input;
        }
    }
}