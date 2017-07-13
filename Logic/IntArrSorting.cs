using System;

namespace Logic
{
    public static class IntArrSorting
    {

        #region Sorting algorithms

        /// <summary>
        /// Bubble sorting for jagged int[][] array by rows.
        /// </summary>
        /// <param name="arr"> Jagged int[][] array. </param>
        /// <param name="iComparer"> 
        /// Option of comparison two rows. Implementation of IComparer 
        /// </param>
        public static void BubbleSortByRows(int[][] arr, IComparer iComparer)
        {
            iComparer.CheckInputArray(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (iComparer.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        int[] temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }

        #endregion

    }
}
