using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_stack
{
    class MyStack3 <T>
    {
        private T[] array;
        public int count;
        private const int der = 1;
        public MyStack3()
        {
            array = new T[der];
        }
        public void Push(T x)
        {
            T[] newAr = new T[2*array.Length];
            Array.Copy(array, 0, newAr, 0, count);
            array = newAr;
            array[count++] = x;
            

        }

        public T Peek()
        { 
            if (count > 0)
            {
                return (array[count - 1]);
            }
            else return (default(T));
        }
        public T Pop()
        {
            if (count > 0)
            {
                count--;
                var temp = Peek();
                T [] result = new T[array.Length-1];
                Array.Copy(array, 0, result, 0, count);
                array = result;
                
                return temp;
            }
            else
            {
                return default(T);
            }
        }
        public int Size ()
        {
            return count;
        }
        public T Top()
        {
            if (count > 0)
            {
                var item = Peek();
                return item;
            }
            else return default(T);
        }
        public bool Empty()
        {
            return count == 0;
        }
        public void Clear()
        {
            count = 0;
        }
    }
}
