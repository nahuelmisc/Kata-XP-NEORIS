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
            if (numbers.Equals(string.Empty))
                return 0;

            List<String> listaNumeros = numbers.Split(',').ToList();

            int acumulador = 0;

            foreach (var item in listaNumeros)
            {
                acumulador += Int32.Parse(item);
            }

            return acumulador;
        }
    }
}
