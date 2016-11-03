using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMCompAssignment
{
    class IntegerStack : IStackInteger
    {
        List<int> list = new List<int>();

        public void Push(int value)
        {
            list.Add(value);
        }

        public int Pop()
        {
            var lastValue = list[list.Count - 1];
            list.Remove(lastValue);
            return lastValue;
        }

        public int Top()
        {
            return list[list.Count - 1];
        }

        public void Clear()
        {
            list.Clear();
        }

        public int Size()
        {
            return list.Count;
        }

        public void Addition()
        {
            int last = list[list.Count - 1];
            int secondToLast = list[list.Count - 2];
            int value = last + secondToLast;
            list.Remove(last);
            list.Remove(secondToLast);
            list.Add(value);
        }

        public void Multiply(int times)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] *= times;
            }
        }

        public IList<int> Get()
        {
            return new List<int>(list);
        }
    }
}
