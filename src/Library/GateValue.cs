using System.Text.RegularExpressions;

namespace Ucu.Poo.Exercise
{
    public class GateValue : ILogicValue
    {
        public bool Value
        {
            get { return this.Gate.Output; }
        }

        public IGate Gate { get; }

        public GateValue(IGate gate)
        {
            this.Gate = gate;
        }
    }
}