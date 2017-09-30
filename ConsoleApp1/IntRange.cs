using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class IntRange
    {
        static public int Min, Max;

        public IntRange(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public int IterativeAdjust(int value, int adjustment)
        {
            bool under = value < Min;
            bool over = value > Max;

            if (!under && !over)
                return value;
            else if (under)
                return IterativeAdjust(value + adjustment, adjustment);
            else if (over)
                return IterativeAdjust(value - adjustment, adjustment);
            else
                throw new System.Exception("ERROR: Congrats, you broke math!");
        }


    }
}
