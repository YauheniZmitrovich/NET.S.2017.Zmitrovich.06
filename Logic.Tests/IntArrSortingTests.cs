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

        private readonly  int[][] _jaggedArray = new int[][]
        {
            new int[] {1,3,5,7,9},
            new int[] {11,22},
            new int[] {0,2,4,6}
        };

        [Test]
        public void BubbleSort_AskSortingBySumOfMembers_ReturnsSortedArray()
        {
            int[][] arr=new int[3][];
            _jaggedArray.CopyTo(arr, 0);
            int[][] expectedArray = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {1,3,5,7,9},
                new int[] {11,22}
            };

            IntArrSorting.BubbleSortByRows(arr, ArrayComparisonBy.SumOfMembers, OrderBy.Asc);

            Assert.AreEqual(arr, expectedArray);
        }

        [Test]
        public void BubbleSort_DescSortingByMaxMember_ReturnsSortedArray()
        {
            int[][] arr = new int[3][];
            _jaggedArray.CopyTo(arr, 0);
            int[][] expectedArray = new int[][]
            {
                new int[] {11,22},
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},       
            };

            IntArrSorting.BubbleSortByRows(arr, ArrayComparisonBy.MaxMember, OrderBy.Desc);

            Assert.AreEqual(arr, expectedArray);
        }

        [Test]
        public void BubbleSort_DescSortingByMin_ReturnsSortedArray()
        {
            int[][] arr = new int[3][];
            _jaggedArray.CopyTo(arr, 0);
            int[][] expectedArray = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {1,3,5,7,9},
                new int[] {11,22},
            };

            IntArrSorting.BubbleSortByRows(arr, ArrayComparisonBy.MinMember, OrderBy.Asc);

            Assert.AreEqual(arr, expectedArray);
        }

        [Test]
        public void BubbleSort_EmptyString_ThrowsArgumentException()
        {
            int[][] arr = new int[][]
            {
                new int[] {0,2,4,6},
                new int[] {},
                new int[] {11,22},
            };

            Assert.Catch<ArgumentException>(()=> 
            IntArrSorting.BubbleSortByRows(arr, ArrayComparisonBy.MinMember, OrderBy.Asc));
        }

        [Test]
        public void BubbleSort_NullString_ThrowsArgumentNullException()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 2 };

            Assert.Catch <ArgumentNullException>(() =>
            IntArrSorting.BubbleSortByRows(arr, ArrayComparisonBy.MinMember, OrderBy.Asc));
        }
  
    }

}


