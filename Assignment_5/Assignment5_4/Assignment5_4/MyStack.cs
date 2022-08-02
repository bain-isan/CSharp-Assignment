using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_4
{
    internal class MyStack<T>
    {
        #region Fields
        private T[] stack;
        private int TOP;
        private int size;
        #endregion


        #region Constructor
        public MyStack(int size)
        {
            this.size = size;
            this.stack = new T[size];
            this.TOP = -1;
        }
        #endregion

        #region Push
        public void Push(T element)
        {
            try
            {
                if (this.TOP < this.size - 1)
                {
                    this.TOP++;
                    this.stack[this.TOP] = element;
                }
                else
                {
                    throw new Exception("Stack is Already Full...Can't Push...");
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }
        #endregion

        #region Pop
        public void Pop()
        {
            T temp;
            try
            {
                if (this.TOP == -1)
                {
                    throw new Exception("Stack is Empty...Can't Pop...");
                }
                else
                {
                    temp = this.stack[this.TOP];
                    this.TOP--;
                    Console.WriteLine("POP 1: " + temp);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            
        }
        #endregion

        #region Display
        public void Display()
        {
            for (int index = 0; index <= this.TOP; index++)
            {
                Console.WriteLine("Element {1} is: {0}", this.stack[index], index + 1);
            }

        }
        #endregion
    }

    public class MyClass
    {
        #region Main
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>(5);
            MyStack<string> myStack2 = new MyStack<string>(5);
            myStack.Push(100);
            myStack.Push(150);
            myStack.Push(200);
            myStack.Push(300);
            myStack.Push(400);

            myStack2.Push("Isan");
            myStack2.Push("Dia");
            myStack2.Push("Rahul");
            myStack2.Push("Nilava");
            myStack2.Push("Ratul");

            Console.WriteLine("-------int Stack-------");
            myStack.Display();
            Console.WriteLine("-------String Stack-------");
            myStack2.Display();

            myStack.Push(400);

            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();

            
            myStack2.Pop();
            myStack2.Pop();
            myStack2.Pop();

            Console.WriteLine("-------int Stack-------");
            myStack.Display();
            Console.WriteLine("-------String Stack-------");
            myStack2.Display();

            Console.ReadLine();
        }
        #endregion
    }
}
