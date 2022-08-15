using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamyApi2.Repositories
{
    public class CalculatorRepository : ICalculatorRepository
    {
        public int Somar (int a, int b)
        {
            return a + b;
        }

        public int Diminuir(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }
}
