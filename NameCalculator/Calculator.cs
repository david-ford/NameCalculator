using System;
using System.Linq;

namespace NameCalculator
{
    public class Calculator
    {
        public static double CalculateName(string name, int position)
        {
            char[] nameLetters = name.ToCharArray();
            var num = nameLetters.Sum(letter => GetCharVal(letter)) * position;
            return num;
        }

        public static double GetCharVal(char alph)
        {
            int subtr = 64;
            return (double)(Char.ToUpper(alph)) - subtr;
        }
    }
}
