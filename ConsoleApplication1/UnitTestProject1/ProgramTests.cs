using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SubListTest()
        {
            List<int> lista = new List<int> {1,2,3,4,5,6,7,8,9,10};
            List<int> sublista = new List<int> { 1, 2, 3, 4, 5 };
            Assert.AreEqual<List<int>>(Program.SubList(lista, 0, 4), sublista);
        }

        [TestMethod()]
        public void MergeTest()
        {
            List<int> lista1 = new List<int> {3,7,12,14};
            List<int> lista2 = new List<int> { 2,6,9,11};
            List<int> lista3 = new List<int> { 2,3,6,7,9,11,12,14};
            Assert.AreEqual<List<int>>(Program.Merge(lista1, lista2), lista3);
        }

        [TestMethod()]
        public void MergeSortTest()
        {
            List<int> lista1 = new List<int> { 10,9,8,7,6,5,4,3,2,1};
            List<int> lista2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.AreEqual<List<int>>(Program.MergeSort(lista1), lista2);
        }
    }
}