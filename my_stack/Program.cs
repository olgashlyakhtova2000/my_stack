using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_stack
{ 
    class Program
    {
        static void f(int x)
        {
            if (x > 0)
            {
                System.Console.WriteLine(x);
                f(x - 1);
                System.Console.WriteLine(x);
            }
        }
        static void f1 (int x, MyStackT<int> arr)
        {
            arr = new MyStackT<int>(x * 2);
            int n=1;
            int g = x+1;
            while (x>0)
            {
                arr.Push(x);
                x--;
                if (x==0)
                {
                    for (;n!=g;n++)
                    {
                        arr.Push(n);
                    }
                    
                }
            }
            while (!arr.Empty())
            {
                Console.WriteLine(arr.Pop());
            }
        }
        //static void f2 (int x)
        //{
        //    var arr = new Stack<int>();
        //    arr.Push(x);
        //    while(arr.Count!=0)
        //    {
        //        x = arr.Peek();
        //        arr.Pop();
        //        if(x>0)
        //        {
        //            arr.Push(x);
        //            arr.Push(x - 1);
        //        }
        //    }
        //    while (!arr.Empty())
        //    {
        //        Console.WriteLine(arr.Pop());
        //    }
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.1-2");
            MyStackT<string> st = new MyStackT<string>(5);
            Console.WriteLine(st.Size());
            Console.WriteLine(st.Top());
            st.Push("first");
            st.Push("second");
            Console.WriteLine(st.Empty());
            Console.WriteLine(st.Size());
            st.Push("third");
            st.Push("fourth");
            while (!st.Empty())
            {
                Console.WriteLine(st.Top());
                st.Pop();
            }
            st.Pop();
            Console.WriteLine(st.Empty());

            Console.WriteLine();
            Console.WriteLine("Задание 1.2");
            System.Diagnostics.Stopwatch watch;
            long elapsedMs;

            int N = 100000000;

            var stack = new System.Collections.Generic.Stack<int>();
            watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i != N; i++)
            {
                stack.Push(i);
            }
            for (int i = 0; i != N; i++)
            {
                stack.Pop();
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            System.Console.WriteLine("System.Collections.Generic.Stack: {0}", elapsedMs);

            long elapsedMs1;
            long elapsedMs2;
            long elapsedMs3;

            MyStackT<int> st1 = new MyStackT<int>(N + 1);
            watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i != N; i++)
            {
                st1.Push(i);
            }
            for (int i = 0; i != N; i++)
            {
                st1.Pop();
            }
            watch.Stop();
            elapsedMs1 = watch.ElapsedMilliseconds;

            System.Console.WriteLine("Стек с помощью массива фиксированной длины: {0} ", elapsedMs1);

            //MyStack2<int> st2 = new MyStack2<int>();
            //watch = System.Diagnostics.Stopwatch.StartNew();

            //for (int i = 0; i != N; i++)
            //{
            //    st2.Push(i);
            //}
            //for (int i = 0; i != N; i++)
            //{
            //    st2.Pop();
            //}
            //watch.Stop();
            //elapsedMs2 = watch.ElapsedMilliseconds;

            //System.Console.WriteLine("Стек с динамическим изменением размера через System.Array.Resize(): {0}", elapsedMs2);

            //MyStack3<int> st3 = new MyStack3<int>();
            //watch = System.Diagnostics.Stopwatch.StartNew();

            //for (int i = 0; i != N; i++)
            //{
            //    st3.Push(i);
            //}
            //for (int i = 0; i != N; i++)
            //{
            //    st3.Pop();
            //}
            //watch.Stop();
            //elapsedMs3 = watch.ElapsedMilliseconds;

            //System.Console.WriteLine("Стек с созданием нового массива в методах Push() и Pop(): {0}", elapsedMs3);

            Console.WriteLine();
            Console.WriteLine("Задание 1.3");
            MyStackT<int> arr3 = new MyStackT<int>(12);
            f1(3, arr3);

       
            
        }
     
    }
}
