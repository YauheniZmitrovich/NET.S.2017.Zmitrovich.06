using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logic.IntArrSorting;
using NUnit.Framework;

namespace Logic.Tests
{

    [TestFixture]
    public class IntArrSortingTests
    {

        #region Auxiliary data

        private int[][] JaggedArray { get; } = new int[][]
        {
            new int[] {1,3,5,7,9},
            new int[] {11,22},
            new int[] {0,2,4,6}
        };

        #endregion


        #region Simple option tests

        [Test]
        [Category("Simple option tests")]
        public void BubbleSort_AscSortingBySumOfMembers_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {1,3,5,7,9},
                new int[] {11,22}
            };

            IntArrSorting.BubbleSortByRows(arr, new ComparatorBySum());

            Assert.AreEqual(arr, expectedArray);
        }

        [Test]
        [Category("Simple option tests")]
        public void BubbleSort_DescSortingByMaxMember_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {11,22},
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
            };

            IntArrSorting.BubbleSortByRows(arr, new ComparatorByMaxMember(), SortingOrder.Desc);

            Assert.AreEqual(arr, expectedArray);
        }

        [Test]
        [Category("Simple option tests")]
        public void BubbleSort_DescSortingByMin_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {1,3,5,7,9},
                new int[] {11,22},
            };

            IntArrSorting.BubbleSortByRows(arr, new ComparatorByMinMember());

            Assert.AreEqual(arr, expectedArray);
        }

        #endregion


        #region Exception's tests

        [Test]
        [Category("Exception's tests")]
        public void BubbleSort_EmptyString_ThrowsArgumentException()
        {
            int[][] arr = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {},
                new int[] {11,22},
            };

            Assert.Catch<ArgumentException>(() =>
            IntArrSorting.BubbleSortByRows(arr, new ComparatorByMinMember()));
        }

        [Test]
        [Category("Exception's tests")]
        public void BubbleSort_NullString_ThrowsArgumentNullException()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 2 };

            Assert.Catch<ArgumentNullException>(() =>
           IntArrSorting.BubbleSortByRows(arr, new ComparatorByMinMember()));
        }

        #endregion

    }

}


