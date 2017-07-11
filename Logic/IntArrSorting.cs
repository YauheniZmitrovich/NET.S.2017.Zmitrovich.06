using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class IntArrSorting
    {

        #region Enums

        /// <summary>
        /// Ascending or descending ordering.
        /// </summary>
        public enum OrderBy { Asc, Desc }

        /// <summary>
        /// Types of comparison of two int[] arrays.
        /// </summary>
        public enum ArrayComparisonBy { SumOfMembers, MaxMember, MinMember }

        #endregion


        #region Sorting algorithms

        /// <summary>
        /// Bubble sorting for jagged int[][] array by rows.
        /// </summary>
        /// <param name="arr"> Jagged int[][] array. </param>
        /// <param name="arrComparisonBy"> Type of comparison two rows. </param>
        /// <param name="orderBy"> Ascending or descending ordering. </param>
        public static void BubbleSortByRows(int[][] arr, ArrayComparisonBy arrComparisonBy, OrderBy orderBy)
        {
            CheckInputArray(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (Compare(arr[j], arr[j + 1], arrComparisonBy, orderBy) > 0)
                    {
                        int[] temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }

        #endregion


        #region Private

        /// <summary>
        ///  Compares two int[] arrays  objects and returns an integer that indicates
        ///  their relative position in the sort order.
        /// </summary>
        /// <param name="arr1"> The first array to compare. </param>
        /// <param name="arr2"> The second array to compare. </param>
        /// <param name="arrComparisonBy"> How we compare our arrays. </param>
        /// <returns>
        ///  A 32-bit signed integer that indicates relationship between the two
        ///  comparands. Value Condition Less than zero arr1 is less than arr2. Zero arr1 equals
        ///  arr2. Greater than zero arr1 is greater than arr2.
        private static int Compare(int[] arr1, int[] arr2, ArrayComparisonBy arrComparisonBy, OrderBy orderBy)
        {
            int res = 0;
            switch (arrComparisonBy)
            {
                case ArrayComparisonBy.SumOfMembers:
                    res = arr1.Sum() - arr2.Sum();
                    return (orderBy == OrderBy.Asc) ? res : -res;

                case ArrayComparisonBy.MaxMember:
                    res = arr1.Max() - arr2.Max();
                    return (orderBy == OrderBy.Asc) ? res : -res;

                case ArrayComparisonBy.MinMember:
                    res = arr1.Min() - arr2.Min();
                    return (orderBy == OrderBy.Asc) ? res : -res;
            }

            return 0;
        }

        private static void CheckInputArray(int[][] arr)
        {
            if (arr == null)
                throw new ArgumentNullException();

            if (arr.Length == 0)
                throw new ArgumentException();

            foreach (int[] internArr in arr)
            {
                if (internArr == null)
                    throw new ArgumentNullException();
                if (internArr.Length == 0)
                    throw new ArgumentException();
            }
        }

        #endregion

    }
}
