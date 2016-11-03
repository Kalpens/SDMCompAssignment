using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMCompAssignment
{
    interface IStackInteger
    {
        void Push(int value);

        int Pop();

        int Top();

        void Clear();

        int Size();

        void Addition();

        void Multiply(int times);

        IList<int> Get();
    }
}
