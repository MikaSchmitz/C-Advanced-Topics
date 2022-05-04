using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //* First off: note that most of the time you wont be creating generics, you will most likely use existing ones like List<>, Dictionary<>, IEnumerable<>, etc...

    // a generic is a class that can use different classes
    // The T can be used to assign a class to the list
    internal class GenericList<T>
    {
        //add value to list function
        public void Add(T value)
        {

        }

        //get method
        public T this[int index]
        {
            get { throw new NotFiniteNumberException(); }
        }
    }

    //a generic dictionary
    public class GenericDictionary<TKey, TValue>
    {
        //add value to dictionary
        public void Add(TKey key, TValue value)
        {

        }
    }
}
