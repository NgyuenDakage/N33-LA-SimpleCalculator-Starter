using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {

            return int.Parse(argTextInput);
        }
    }
}
