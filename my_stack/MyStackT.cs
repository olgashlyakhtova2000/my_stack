using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_stack
{
    class MyStackT <T>
    {
            private T[] array;
            public int count;
            public MyStackT(int length)
            {

                try
                {
                    array = new T[length];
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            public void Push(T x)
            {
                try
                {
                     array[count] = x;
                     count++;
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //if (count >= array.Length)
                //{
                //    Console.WriteLine("-1");
                //}
            }
            public int Size()
            {
                return count;
            }
            public T Peek()
            {
            try
            {
                return (array[count - 1]);
            }
            catch (IndexOutOfRangeException ex) when (count<0)
            {
                Console.WriteLine(ex.Message);
                return default(T);
            }
            catch when (count <= 0)
            {
                return default(T);
            }
            //if (count<=0)
            //    {
            //      return default(T);                
            //    }
            //    else return (array[count - 1]);
        }
            public T Pop()
            {
            try
            {
                T temp = Peek();
                --count;
                return temp;
            }
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return default(T);
            //}
            catch when (count <0)
            {
                return default(T);
            }
            //if (count > 0)
            //{
            //    T temp = Peek();
            //    --count;
            //    return temp;     
            //}
            //else return default(T);
            }
            public T Top ()
            {
            try
            {
                T temp = Peek();
                return temp;
            }
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return default(T);
            //}
            catch when (count <0)
            {
                return default(T);
            }
            //if (count > 0)
            //    {
            //        T temp = Peek();
            //        return temp;
            //    }
            //    else return default(T);
            }
            public bool Empty()
            {
                return count == 0||count==-1;
            }
            public void Clear()
            {
                count = 0;
            }

        }
   // }
}
