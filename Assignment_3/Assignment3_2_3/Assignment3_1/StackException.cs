using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1
{
    internal class StackException : Exception
    {
        public StackException(String msg) : base(msg)
        {
        }
    }
}
