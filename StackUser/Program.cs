using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDMCompAssignment;

namespace StackUser
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new IntegerStack();
            stack.Push(19);
            stack.Push(21);
            Console.WriteLine(stack.Get()[0]);
            Console.WriteLine(stack.Get()[1]);
            Console.ReadLine();
        }
    }
}
