using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using NUnit.Framework;


namespace Logic.Tests
{
    [TestFixture]
    public class IntArrSortingInterfaceInDelegateTests
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
        [Category("2. Simple option tests")]
        public void BubbleSortByRows_AscSortingBySumOfMembers_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {1,3,5,7,9},
                new int[] {11,22}
            };

            IntArrSortingInterfaceInDelegate.BubbleSortByRows(arr, (new AscComparatorBySum()).Compare);

            Assert.AreEqual(arr, expectedArray);
        }

        [Test]
        [Category("2. Simple option tests")]
        public void BubbleSortByRows_DescSortingBySumOfMembers_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {11,22},
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6}
            };

            IntArrSortingInterfaceInDelegate.BubbleSortByRows(arr, new DescComparatorBySum().Compare);

            Assert.AreEqual(arr, expectedArray);
        }

        #endregion

        #region Sorting by min member

        [Test]
        [Category("2. Simple option tests")]
        public void BubbleSortByRows_AscSortingByMin_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {1,3,5,7,9},
                new int[] {11,22},
            };

            IntArrSortingInterfaceInDelegate.BubbleSortByRows(arr, new AscComparatorByMinMember().Compare);

            Assert.AreEqual(arr, expectedArray);
        }

        [Test]
        [Category("2. Simple option tests")]
        public void BubbleSortByRows_DescSortingByMin_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {11,22},
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6}
            };

            IntArrSortingInterfaceInDelegate.BubbleSortByRows(arr, new DescComparatorByMinMember().Compare);

            Assert.AreEqual(arr, expectedArray);
        }

        #endregion

        #region  Sorting by max member

        [Test]
        [Category("2. Simple option tests")]
        public void BubbleSortByRows_AscSortingByMaxMember_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {1,3,5,7,9},
                new int[] {11,22}
            };

            IntArrSortingInterfaceInDelegate.BubbleSortByRows(arr, new AscComparatorByMaxMember().Compare);

            Assert.AreEqual(arr, expectedArray);
        }

        [Test]
        [Category("2. Simple option tests")]
        public void BubbleSortByRows_DescSortingByMaxMember_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {11,22},
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
            };

            IntArrSortingInterfaceInDelegate.BubbleSortByRows(arr, new DescComparatorByMaxMember().Compare);

            Assert.AreEqual(arr, expectedArray);
        }

        #endregion

        #region Sorting by length

        [Test]
        [Category("2. Simple option tests")]
        public void BubbleSortByRows_AscSortingByLength_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {11,22},
                new int[] {0,2,4,6},
                new int[] {1,3,5,7,9}
            };

            IntArrSortingInterfaceInDelegate.BubbleSortByRows(arr, new AscComparatorByLength().Compare);

            Assert.AreEqual(arr, expectedArray);
        }

        [Test]
        [Category("2. Simple option tests")]
        public void BubbleSortByRows_DescSortingByLength_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {11,22}
            };

            IntArrSortingInterfaceInDelegate.BubbleSortByRows(arr, new DescComparatorByLength());

            Assert.AreEqual(arr, expectedArray);
        }

        #endregion

        #region  Sorting by the first member

        [Test]
        [Category("2. Simple option tests")]
        public void BubbleSortByRows_AscSortingByFirstMember_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {1,3,5,7,9},
                new int[] {11,22},
            };

            IntArrSortingInterfaceInDelegate.BubbleSortByRows(arr, new AscComparatorByFirstMember().Compare);

            Assert.AreEqual(arr, expectedArray);
        }

        [Test]
        [Category("2. Simple option tests")]
        public void BubbleSortByRows_DescSortingByFirstMember_ReturnsSortedArray()
        {
            int[][] arr = (int[][])JaggedArray.Clone();
            int[][] expectedArray = new int[][]
            {
                new int[] {11,22},
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6}
            };

            IntArrSortingInterfaceInDelegate.BubbleSortByRows(arr, new DescComparatorByFirstMember().Compare);

            Assert.AreEqual(arr, expectedArray);
        }

        #endregion


        #endregion


        #region Exception's tests

        [Test]
        [Category("2. Exception's tests")]
        public void BubbleSortByRows_EmptyString_ThrowsArgumentException()
        {
            int[][] arr = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {},
                new int[] {11,22},
            };

            Assert.Catch<ArgumentException>(() =>
                IntArrSortingInterfaceInDelegate.BubbleSortByRows(arr, new AscComparatorByMinMember().Compare));
        }

        [Test]
        [Category("2. Exception's tests")]
        public void BubbleSortByRows_NullString_ThrowsArgumentNullException()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 2 };

            Assert.Catch<ArgumentNullException>(() =>
                IntArrSortingInterfaceInDelegate.BubbleSortByRows(arr, new AscComparatorByMinMember().Compare));
        }

        #endregion


        #endregion
    }
}
