using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabXUnit
{
    public class LeapYearValidator
    {

        public LeapYearValidator()
        {

        }

        public bool ValidateYear(int year)
        {
            bool isDividedByFour = year % 4 == 0;
            bool isDividedByHundred = year % 100 == 0;
            bool isDividedByFourHundred = year % 400 == 0;

            if (isDividedByFour)
            {
                if (isDividedByFourHundred && isDividedByHundred)
                {
                    return true;
                }
                else if (!isDividedByHundred)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}
