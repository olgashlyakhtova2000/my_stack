using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_stack
{
    class MyStack2 <T>
    {
        private T[] array_2;
        public int count_2;

        public MyStack2 ()
        {
            array_2 = new T[0];
        }
        public void Push(T x)
        {
            Array.Resize(ref array_2, count_2 + 1);
            array_2[count_2] = x;
            count_2++;
        }
        public int Size()
        {
            return count_2;
        }
        public T Peek()
        {
            if (count_2 > 0)
            {
                return array_2[count_2 - 1];
            }
            else return default(T);
        }
        public T Pop ()
        {
            if (count_2>0)
            {
                var item = Peek();
                Array.Resize(ref array_2, count_2 - 1);
                count_2--;
                return item;
            }
            else return default(T);
        }
        public T Top ()
        {
            if (count_2 > 0)
            {
                var item = Peek();
                return item;
            }
            else return default(T);
        }
        public bool Empty ()
        {
            return count_2 == 0;
        }
        public void Clear()
        {
            count_2 = 0;
        }
    }
}
