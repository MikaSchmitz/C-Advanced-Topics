using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //* Constraints are used to limit generic input posibilities
    // where T : IComparable
    // where T : struct
    // where T : class
    // where T : new()

    // input HAS to be comparable or new
    public class Constraints <T> where T : IComparable, new()
    {
        //we can only compare the two classes if they are comparable, thanks to the constraint IComparable
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public T NewObj(T value)
        {
            return new T();
        }
    }


    // input HAS to be a struct
    public class Nullable<T> where T : struct
    {
        private object _value;

        //construct for value not set
        public Nullable()
        {

        }
        
        //overflow for value is set
        public Nullable(T value)
        {
            _value = value;
        }

        //check if there is a value
        public bool HasValue
        {
            get { return _value != null; }
        }

        //return value or default
        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }


    // input HAS to be of class product
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public double CalculateDiscount(TProduct product)
        {
            return product.Price * 0.2;
        }
    }
}
