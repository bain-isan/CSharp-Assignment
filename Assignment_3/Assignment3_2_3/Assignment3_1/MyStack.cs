using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1
{
    public class MyStack : ICloneable
    {
        #region Fields
        private int[] stack;
        private int TOP;
        private int size;
        #endregion

        #region Clone
        public Object Clone()
        {
            return new MyStack(this);
        }
        #endregion

        #region Constructor
        public MyStack(MyStack ms)
        {
            this.stack = ms.stack;
            this.TOP = ms.TOP;
            this.size = ms.size;
        }

        public MyStack(int size)
        {
            this.size = size;
            this.stack = new int[size];
            this.TOP = -1;
        }
        #endregion

        #region Push
        public void Push(int element)
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
                    throw new StackException("Stack is Already Full...Can't Push...");
                }
            }
            catch(StackException stEx)
            {
                Console.WriteLine(stEx.Message);
            }
        }
        #endregion

        #region Pop
        public int? Pop()
        {
            int temp = 0;
            try
            {
                if (this.TOP == -1)
                {
                    throw new StackException("Stack is Empty...Can't Pop...");
                }
                else
                {
                    temp = this.stack[this.TOP];
                    this.TOP--;
                    return temp;
                }
            }
            catch (StackException stEx)
            {
                Console.WriteLine(stEx.Message);
            }
            return null;
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

        #region Main
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack(5);
            myStack.Push(100);
            myStack.Push(150);
            myStack.Push(200);
            myStack.Push(300);
            myStack.Push(400);


            myStack.Display();
            
            myStack.Push(400);

            Console.WriteLine("POP 1: " + myStack.Pop());
            Console.WriteLine("POP 2: " + myStack.Pop());
            Console.WriteLine("POP 3: " + myStack.Pop());
            Console.WriteLine("POP 4: " + myStack.Pop());

            myStack.Display();

            Console.WriteLine("POP 5: " + myStack.Pop());
            Console.WriteLine("POP 6: " + myStack.Pop());

            Console.ReadLine();



        }
        #endregion
    }

}

