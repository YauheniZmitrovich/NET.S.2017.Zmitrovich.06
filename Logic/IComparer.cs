using static Logic.IntArrSorting;
namespace Logic
{
    /// <summary>
    /// Exposes a method that compares two int[] arrays.
    /// </summary>
    public interface IComparer
    {
        /// <summary>
        /// Compares two int[] arrays and returns a value indicating 
        /// whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="arr1"> The first array to compare. </param>
        /// <param name="arr2"> The second object to compare. </param>
        /// <param name="sortingOrder"> Ascending or descending order. </param>
        /// <returns>
        /// A signed integer that indicates the relative values of arr1 and arr2,
        /// as shown in the following table.Value Meaning Less than zero arr1 is less than arr2. 
        /// Zero arr1 equals arr2. Greater than zero arr1 is greater than arr2.
        /// </returns>
        int Compare(int[] arr1, int[] arr2, SortingOrder sortingOrder = SortingOrder.Asc);
    }
}