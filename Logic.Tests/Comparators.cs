using System;
using static Logic.IntArrSorting;
using System.Linq;

namespace Logic.Tests
{

    /// <summary>
    /// Comparator of two int[] arrays by the sum of the elements.
    /// Implements <see cref="IComparer"/> interface.
    /// </summary>
    public class ComparatorBySum : IComparer
    {
        /// <summary>
        ///  Compares two int[] arrays by the sum of the elements
        ///  and returns an integer that indicates
        ///  their relative position in the sort order.
        /// </summary>
        /// <param name="arr1"> The first array to compare. </param>
        /// <param name="arr2"> The second array to compare. </param>
        /// <param name="sortingOrder"> Ascending or descending ordering. </param>
        /// <returns>
        ///  A 32-bit signed integer that indicates relationship between the two
        ///  comparands. Value Condition Less than zero arr1 is less than arr2. Zero arr1 equals
        ///  arr2. Greater than zero arr1 is greater than arr2.
        /// </returns>
        public int Compare(int[] arr1, int[] arr2, SortingOrder sortingOrder = SortingOrder.Asc)
        {
            int res = arr1.Sum() - arr2.Sum();
            return (sortingOrder == SortingOrder.Asc) ? res : -res;
        }
    }

    /// <summary>
    /// Comparator of two int[] arrays by the minimum elements.
    /// Implements <see cref="IComparer"/> interface.
    /// </summary>
    public class ComparatorByMinMember : IComparer
    {
        /// <summary>
        ///  Compares two int[] arrays by the minimum elements
        ///  and returns an integer that indicates
        ///  their relative position in the sort order.
        /// </summary>
        /// <param name="arr1"> The first array to compare. </param>
        /// <param name="arr2"> The second array to compare. </param>
        /// <param name="sortingOrder"> Ascending or descending ordering. </param>
        /// <returns>
        ///  A 32-bit signed integer that indicates relationship between the two
        ///  comparands. Value Condition Less than zero arr1 is less than arr2. Zero arr1 equals
        ///  arr2. Greater than zero arr1 is greater than arr2.
        /// </returns>
        public int Compare(int[] arr1, int[] arr2, SortingOrder sortingOrder = SortingOrder.Asc)
        {
            int res = arr1.Min() - arr2.Min();
            return (sortingOrder == SortingOrder.Asc) ? res : -res;
        }
    }

    /// <summary>
    /// Comparator of two int[] arrays by the maximum elements.
    /// Implements <see cref="IComparer"/> interface.
    /// </summary>
    public class ComparatorByMaxMember : IComparer
    {
        /// <summary>
        ///  Compares two int[] arrays by the minimum elements
        ///  and returns an integer that indicates
        ///  their relative position in the sort order.
        /// </summary>
        /// <param name="arr1"> The first array to compare. </param>
        /// <param name="arr2"> The second array to compare. </param>
        /// <param name="sortingOrder"> Ascending or descending ordering. </param>
        /// <returns>
        ///  A 32-bit signed integer that indicates relationship between the two
        ///  comparands. Value Condition Less than zero arr1 is less than arr2. Zero arr1 equals
        ///  arr2. Greater than zero arr1 is greater than arr2.
        /// </returns>
        public int Compare(int[] arr1, int[] arr2, SortingOrder sortingOrder = SortingOrder.Asc)
        {
            int res = arr1.Max() - arr2.Max();
            return (sortingOrder == SortingOrder.Asc) ? res : -res;
        }
    }

    /// <summary>
    /// Comparator of two int[] arrays by the num of the elements.
    /// Implements <see cref="IComparer"/> interface.
    /// </summary>
    public class ComparatorByLength : IComparer
    {
        /// <summary>
        ///  Compares two int[] arrays by the num of the elements
        ///  and returns an integer that indicates
        ///  their relative position in the sort order.
        /// </summary>
        /// <param name="arr1"> The first array to compare. </param>
        /// <param name="arr2"> The second array to compare. </param>
        /// <param name="sortingOrder"> Ascending or descending ordering. </param>
        /// <returns>
        ///  A 32-bit signed integer that indicates relationship between the two
        ///  comparands. Value Condition Less than zero arr1 is less than arr2. Zero arr1 equals
        ///  arr2. Greater than zero arr1 is greater than arr2.
        /// </returns>
        public int Compare(int[] arr1, int[] arr2, SortingOrder sortingOrder = SortingOrder.Asc)
        {
            int res = arr1.Length - arr2.Length;
            return (sortingOrder == SortingOrder.Asc) ? res : -res;
        }
    }

    /// <summary>
    /// Comparator of two int[] arrays by the first the elements.
    /// Implements <see cref="IComparer"/> interface.
    /// </summary>
    public class ComparatorByFirstMember : IComparer
    {
        /// <summary>
        ///  Compares two int[] arrays by the first of the elements
        ///  and returns an integer that indicates
        ///  their relative position in the sort order.
        /// </summary>
        /// <param name="arr1"> The first array to compare. </param>
        /// <param name="arr2"> The second array to compare. </param>
        /// <param name="sortingOrder"> Ascending or descending ordering. </param>
        /// <returns>
        ///  A 32-bit signed integer that indicates relationship between the two
        ///  comparands. Value Condition Less than zero arr1 is less than arr2. Zero arr1 equals
        ///  arr2. Greater than zero arr1 is greater than arr2.
        /// </returns>
        public int Compare(int[] arr1, int[] arr2, SortingOrder sortingOrder = SortingOrder.Asc)
        {
            int res = arr1[0] - arr2[0];
            return (sortingOrder == SortingOrder.Asc) ? res : -res;
        }
    }

}