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
        #region Sorting by rows


        #region Auxiliary data

        private int[][] JaggedArray { get; } = new int[][]
        {
            new int[] {1,3,5,7,9},
            new int[] {11,22},
            new int[] {0,2,4,6}
        };

        #endregion


        #region Simple option tests


        #region Sorting by sum of members

        [Test]
        [Category("Simple option tests")]
        public void BubbleSortByRows_AscSortingBySumOfMembers_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {1,3,5,7,9},
                new int[] {11,22}
            };

            IntArrSorting.BubbleSortByRows(arr, new AscComparatorBySum());

            Assert.AreEqual(arr, expectedArray);
        }

        [Test]
        [Category("Simple option tests")]
        public void BubbleSortByRows_DescSortingBySumOfMembers_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {11,22},
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6}
            };

            IntArrSorting.BubbleSortByRows(arr, new DescComparatorBySum());

            Assert.AreEqual(arr, expectedArray);
        }

        #endregion

        #region Sorting by min member

        [Test]
        [Category("Simple option tests")]
        public void BubbleSortByRows_AscSortingByMin_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {1,3,5,7,9},
                new int[] {11,22},
            };

            IntArrSorting.BubbleSortByRows(arr, new AscComparatorByMinMember());

            Assert.AreEqual(arr, expectedArray);
        }

        [Test]
        [Category("Simple option tests")]
        public void BubbleSortByRows_DescSortingByMin_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {11,22},
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6}
            };

            IntArrSorting.BubbleSortByRows(arr, new DescComparatorByMinMember());

            Assert.AreEqual(arr, expectedArray);
        }

        #endregion

        #region  Sorting by max member

        [Test]
        [Category("Simple option tests")]
        public void BubbleSortByRows_AscSortingByMaxMember_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {1,3,5,7,9},
                new int[] {11,22}
            };

            IntArrSorting.BubbleSortByRows(arr, new AscComparatorByMaxMember());

            Assert.AreEqual(arr, expectedArray);
        }

        [Test]
        [Category("Simple option tests")]
        public void BubbleSortByRows_DescSortingByMaxMember_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {11,22},
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
            };

            IntArrSorting.BubbleSortByRows(arr, new DescComparatorByMaxMember());

            Assert.AreEqual(arr, expectedArray);
        }

        #endregion

        #region Sorting by length

        [Test]
        [Category("Simple option tests")]
        public void BubbleSortByRows_AscSortingByLength_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {11,22},
                new int[] {0,2,4,6},
                new int[] {1,3,5,7,9}
            };

            IntArrSorting.BubbleSortByRows(arr, new AscComparatorByLength());

            Assert.AreEqual(arr, expectedArray);
        }

        [Test]
        [Category("Simple option tests")]
        public void BubbleSortByRows_DescSortingByLength_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {11,22}
            };

            IntArrSorting.BubbleSortByRows(arr, new DescComparatorByLength());

            Assert.AreEqual(arr, expectedArray);
        }

        #endregion

        #region  Sorting by the first member

        [Test]
        [Category("Simple option tests")]
        public void BubbleSortByRows_AscSortingByFirstMember_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {1,3,5,7,9},
                new int[] {11,22},
            };

            IntArrSorting.BubbleSortByRows(arr, new AscComparatorByFirstMember());

            Assert.AreEqual(arr, expectedArray);
        }

        [Test]
        [Category("Simple option tests")]
        public void BubbleSortByRows_DescSortingByFirstMember_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {11,22},
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6} 
            };

            IntArrSorting.BubbleSortByRows(arr, new DescComparatorByFirstMember());

            Assert.AreEqual(arr, expectedArray);
        }

        #endregion


        #endregion


        #region Exception's tests

        [Test]
        [Category("Exception's tests")]
        public void BubbleSortByRows_EmptyString_ThrowsArgumentException()
        {
            int[][] arr = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {},
                new int[] {11,22},
            };

            Assert.Catch<ArgumentException>(() =>
            IntArrSorting.BubbleSortByRows(arr, new AscComparatorByMinMember()));
        }

        [Test]
        [Category("Exception's tests")]
        public void BubbleSortByRows_NullString_ThrowsArgumentNullException()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 2 };

            Assert.Catch<ArgumentNullException>(() =>
           IntArrSorting.BubbleSortByRows(arr, new AscComparatorByMinMember()));
        }

        #endregion


        #endregion
    }

}


