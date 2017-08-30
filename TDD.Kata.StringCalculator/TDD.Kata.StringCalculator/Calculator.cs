using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Kata.StringCalculator
{
    public class Calculator
    {
        public int add(string numbers)
        {
            string value = numbers.Equals(String.Empty) ? "0" : numbers;
            return Int32.Parse(value);
        }
    }
}
