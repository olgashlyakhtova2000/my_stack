using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_stack
{
    public class MyStack
    {
        private int[] array;
        public int count;
        public MyStack(int length)
        { 
            array = new int[length];
        }
        public void Push (int x)
        {
            array[count] = x;
            count++;
            if (count >= array.Length)
            {
                Console.WriteLine("-1");
            }
            
        }

        public int Peek()
        {
            if (count > 0)
            {
                return (array[count - 1]);
            }
            else return (default(int));
        }
        public int Pop ()
        {
            if (count > 0)
            {
                int temp = Peek();
                return array[--count];
            }
            else
            {
                throw new Exception("Stack-");
            }
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
