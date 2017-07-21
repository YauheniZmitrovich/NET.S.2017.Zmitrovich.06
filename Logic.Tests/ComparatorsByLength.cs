using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Tests
{
    /// <summary>
    /// Comparator of two int[] arrays by the num of the elements.
    /// Implements <see cref="IComparer"/> interface.
    /// </summary>
    public class AscComparatorByLength : IComparer<int[]>
    {
        /// <summary>
        /// Determines restrictions on input array,
        /// null references and empty rows management.
        /// </summary>
        /// <param name="arr1"> The first input array. </param>
        /// <param name="arr2"> The second input array. </param>
        /// <exception cref="ArgumentNullException">
        /// Throws exceptions when <see cref="arr1"/> or <see cref="arr2"/> is null reference.
        /// </exception>
        /// /// <exception cref="ArgumentException">
        /// Throws exceptions when length of <see cref="arr1"/> or <see cref="arr2"/> is equals to zero.
        /// </exception>
        public void CheckInputArray(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr2 == null)
                throw new ArgumentNullException();
            if (arr1.Length == 0 || arr2.Length == 0)
                throw new ArgumentException();
        }

        /// <summary>
        ///  Compares two int[] arrays by the num of the elements in ascending order
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
            CheckInputArray(arr1,arr2);
            return arr1.Length - arr2.Length;
        }
    }

    /// <summary>
    /// Comparator of two int[] arrays by the num of the elements.
    /// Implements <see cref="IComparer"/> interface.
    /// </summary>
    public class DescComparatorByLength : IComparer<int[]>
    {
        /// <summary>
        /// Determines restrictions on input array,
        /// null references and empty rows management.
        /// </summary>
        /// <param name="arr1"> The first input array. </param>
        /// <param name="arr2"> The second input array. </param>
        /// <exception cref="ArgumentNullException">
        /// Throws exceptions when <see cref="arr1"/> or <see cref="arr2"/> is null reference.
        /// </exception>
        /// /// <exception cref="ArgumentException">
        /// Throws exceptions when length of <see cref="arr1"/> or <see cref="arr2"/> is equals to zero.
        /// </exception>
        public void CheckInputArray(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr2 == null)
                throw new ArgumentNullException();
            if (arr1.Length == 0 || arr2.Length == 0)
                throw new ArgumentException();
        }

        /// <summary>
        ///  Compares two int[] arrays by the num of the elements in descending order
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
            CheckInputArray(arr1,arr2);
            return arr2.Length - arr1.Length;
        }
    }
}
