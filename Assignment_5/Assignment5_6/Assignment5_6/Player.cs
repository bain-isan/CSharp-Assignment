using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_6
{
    internal class Player
    {
        string name;
        int runScored;

        public string Name { get { return name; } set { this.name = value; } }

        public Player(string name, int runScored)
        {
            Name = name;
            RunScored = runScored;
        }

        public int RunScored { get { return runScored; } set {this.runScored = value; } }
    }
}
