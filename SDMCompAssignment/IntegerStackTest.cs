using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SDMCompAssignment
{
    [TestClass()]
    public class IntegerStackTest
    {

        [TestMethod()]
        public void AssertPush()
        {
            IStackInteger stack = new IntegerStack();
            stack.Push(10);
            Assert.AreEqual(10, stack.Get()[0]);
        }

        [TestMethod()]
        public void AssertSize()
        {
            IStakInteger stack = new IntegerStack();
            stack.Push(11);
            stack.Push(22);
            stack.Push(33);
            Assert.AreEqual(3, stack.Size());
        }

        [TestMethod()]
        public void AssertPop()
        {
            IStackInteger stack = new IntegerStack();
            stack.Push(11);
            stack.Push(22);
            stack.Push(33);
            Assert.AreEqual(33, stack.Pop());
            Assert.AreEqual(2, stack.Size());
        }
        [TestMethod()]
        public void AssertTop()
        {
            IStackInteger stack = new IntegerStack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Assert.AreEqual(30, stack.Pop());
        }
        [TestMethod()]
        public void AssertClear()
        {
            IStackInteger stack = new IntegerStack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Assert.AreEqual(3, stack.Size());
            stack.Clear();
            Assert.AreEqual(0, stack.Size());
        }

        [TestMethod()]
        public void AssertAddition()
        {
            IStackInteger stack = new IntegerStack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(60);
            stack.Addition();
            Assert.AreEqual(2, stack.Size());
            Assert.AreEqual(80, stack.Top());
        }

        [TestMethod()]
        public void AssertMultiply()
        {
            IStackInteger stack = new IntegerStack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(60);
            stack.Multiply(3);
            Assert.AreEqual(30, stack.Get()[0]);
            Assert.AreEqual(60, stack.Get()[1]);
            Assert.AreEqual(180, stack.Top());
        }
    }
}
