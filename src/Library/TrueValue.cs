using System.Text.RegularExpressions;

namespace Ucu.Poo.Exercise
{
    public class TrueValue : ILogicValue
    {
        public bool Value
        {
            get { return true; }
        }
    }
}