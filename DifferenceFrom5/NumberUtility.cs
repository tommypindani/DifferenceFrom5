using System;
using System.Collections.Generic;
using System.Text;

namespace DifferenceFrom5
{
    public class NumberUtility
    {

        public static int CalculateDifferenceFrom5(Object input)
        {
            var validNumber = int.TryParse(input.ToString(), out var numberInput);
            if (!validNumber) throw new ArgumentException();
            try
            {
                var differenceFrom5 = 8 - numberInput;

                return differenceFrom5;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static int CalculateDifferenceFrom5(int validNumber)
        {
            throw new NotImplementedException();
        }
    }
}


