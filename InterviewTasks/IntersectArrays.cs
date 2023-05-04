using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTasks
{
    // Task: implement method "IntersectTwoArrays" so that it returns intersection of items presented in array1 and array2.
    // Restrictions: you can use all features of .Net except for those that contains the algorithm (eg. IEnumerable.Intersect()).
	// Complexity of implemented algorithm must be less than O(n*m).

    public static class IntersectArrays
    {
        public static string[] IntersectTwoArraysBinary(string[] array1, string[] array2)
        {
           
            // sort
            array1.Distinct(); // O(n)
            array2.Distinct();
            Array.Sort(array1); // O(n logn)
            var resultList = new List<string>();

            // binary search
            foreach (var elem in array2)
            {
                if (Array.BinarySearch(array1, elem) > 0) // O(n*logn)
                {
                    resultList.Add(elem);
                }
                else
                {
                    continue;
                }
            }
            return resultList.ToArray();
        }

   
        public static string[] IntersectTwoArraysHash(string[] array1, string[] array2) // ~ O(n+m)
        {
            var resultList = new List<string>();
            HashSet<string> hashArray1 = new HashSet<string>(array1); // O(n) 
            HashSet<string> hashArray2 = new HashSet<string>(array2);
            foreach (var elem in hashArray2) 
            {
               if (hashArray1.Contains(elem)) // O(1)
                    resultList.Add(elem);
            }

            return resultList.ToArray();
        }

    }
}
