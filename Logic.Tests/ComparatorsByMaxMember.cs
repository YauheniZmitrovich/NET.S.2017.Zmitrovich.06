using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Tests
{
    /// <summary>
    /// Comparator of two int[] arrays by the maximum elements.
    /// Implements <see cref="IComparer"/> interface.
    /// </summary>
    public class AscComparatorByMaxMember : IComparer
    {
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
        public void CheckInputArray(int[][] arr)
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

        /// <summary>
        ///  Compares two int[] arrays by the minimum elements in ascending
        ///  and returns an integer that indicates
        ///  their relative position in the sort order.
        /// </summary>
        /// <param name="arr1"> The first array to compare. </param>
        /// <param name="arr2"> The second array to compare. </param>
        /// <returns>
        ///  A 32-bit signed integer that indicates relationship between the two
        ///  comparands. Value Condition Less than zero arr1 is less than arr2. Zero arr1 equals
        ///  arr2. Greater than zero arr1 is greater than arr2.
        /// </returns>
        public int Compare(int[] arr1, int[] arr2)
        {
            return arr1.Max() - arr2.Max();
        }
    }

    /// <summary>
    /// Comparator of two int[] arrays by the maximum elements.
    /// Implements <see cref="IComparer"/> interface.
    /// </summary>
    public class DescComparatorByMaxMember : IComparer
    {
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
        public void CheckInputArray(int[][] arr)
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

        /// <summary>
        ///  Compares two int[] arrays by the minimum elements in descending
        ///  and returns an integer that indicates
        ///  their relative position in the sort order.
        /// </summary>
        /// <param name="arr1"> The first array to compare. </param>
        /// <param name="arr2"> The second array to compare. </param>
        /// <returns>
        ///  A 32-bit signed integer that indicates relationship between the two
        ///  comparands. Value Condition Less than zero arr1 is less than arr2. Zero arr1 equals
        ///  arr2. Greater than zero arr1 is greater than arr2.
        /// </returns>
        public int Compare(int[] arr1, int[] arr2)
        {
            return arr2.Max() - arr1.Max();
        }
    }
}
