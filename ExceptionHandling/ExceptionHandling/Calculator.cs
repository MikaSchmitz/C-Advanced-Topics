using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Calculator : IDisposable
    {
        public void Dispose()
        {
            
        }

        public double Divide(int numerator, int denomenator)
        {
            return numerator / denomenator;
        }
    }
}
