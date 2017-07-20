using System;
using System.Collections.Generic;

namespace Logic
{
    public static class IntArrSortingInterfaceInDelegate
    {
        #region Sorting algorithms

        /// <summary>
        /// Bubble sorting for jagged int[][] array by rows.
        /// </summary>
        /// <param name="arr"> Jagged int[][] array. </param>
        /// <param name="comparer"> 
        /// Option of comparison two rows. Implementation of <see cref="IComparer{T}"/>
        /// </param>
        public static void BubbleSortByRows(int[][] arr, IComparer<int[]> comparer)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (comparer.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        int[] temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Bubble sorting for jagged int[][] array by rows.
        /// </summary>
        /// <param name="arr"> Jagged int[][] array. </param>
        /// <param name="comparer"> 
        /// Option of comparison two rows.
        /// </param>
        public static void BubbleSortByRows(int[][] arr, Comparison<int[]> comparer)
        {
            CheckInputArray(arr);

            BubbleSortByRows(arr,Comparer<int[]>.Create(comparer));
        }

        #endregion

        #region Private fields

        /// <summary>
        /// Determines restrictions on input array,
        /// null references and empty rows management.
        /// </summary>
        /// <param name="arr"> Input jagged array. </param>
        /// <exception cref="ArgumentNullException">
        /// Throws exceptions when <see cref="arr"/> or 
        /// arr[i] is null reference.
        /// </exception>
        /// /// <exception cref="ArgumentException">
        /// Throws exceptions when length of <see cref="arr"/> or 
        /// arr[i] is equals to zero.
        /// </exception>
        public static void CheckInputArray(int[][] arr)
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
