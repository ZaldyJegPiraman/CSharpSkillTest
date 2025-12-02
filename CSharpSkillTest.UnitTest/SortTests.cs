using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSkillTest;
using CSharpSkillTest.Models;

namespace CSharpSkillTest.UnitTest
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void TestBubbleSort()
        {
            var sort = new BubbleSortStrategy();
            Assert.AreEqual("abcdef", sort.Sort("fedcba"));
        }

        [TestMethod]
        public void TestQuickSort()
        {
            var sort = new QuickSortStrategy();
            Assert.AreEqual("abcdef", sort.Sort("dfebca"));
        }
    }
}
