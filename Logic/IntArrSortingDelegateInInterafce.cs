using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class IntArrSortingDelegateInInterface
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
            CheckInputArray(arr);

            BubbleSortByRows(arr,comparer.Compare);
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
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (comparer(arr[j], arr[j + 1]) > 0)
                    {
                        int[] temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
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
