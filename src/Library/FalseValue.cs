using System.Text.RegularExpressions;

namespace Ucu.Poo.Exercise
{
    public class FalseValue : ILogicValue
    {
        public bool Value
        {
            get { return false; }
        }
    }
}