using System;

namespace Logic
{
    public static class IntArrSorting
    {

        #region Enums

        //To my mind it's more readable code than a bool flag.
        /// <summary>
        /// Ascending or descending ordering.
        /// </summary>
        public enum SortingOrder { Asc, Desc }

        #endregion


        #region Sorting algorithms

        /// <summary>
        /// Bubble sorting for jagged int[][] array by rows.
        /// </summary>
        /// <param name="arr"> Jagged int[][] array. </param>
        /// <param name="iComparer"> 
        /// Option of comparison two rows. Implementation of IComparer 
        /// </param>
        /// <param name="sortingOrder"> Ascending or descending ordering. </param>
        public static void BubbleSortByRows(int[][] arr, IComparer iComparer, SortingOrder sortingOrder = SortingOrder.Asc)
        {
            CheckInputArray(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (iComparer.Compare(arr[j], arr[j + 1], sortingOrder) > 0)
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
