using DataStructures.Structures.BinarySearch.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Structures.BinarySearch
{
    public abstract class BinarySearch<T>
    {
        public int GetIndex(T[] array, T value)
        {
            var size = array.Length;
            return GetRecursively(array, value, 0, size-1);
        }

        private int GetRecursively(T[] array, T value, int minIndex, int maxIndex)
        {            
            var middleIndex = (minIndex + maxIndex) / 2;
            var result = CompareRespectively(array[middleIndex], value);
            if (maxIndex <= minIndex && result != ResultComparison.Equals)
                return -1;
            if (result == ResultComparison.Equals)
                return middleIndex;
            if (result == ResultComparison.Bigger)
                return GetRecursively(array, value, minIndex, middleIndex - 1);
            return GetRecursively(array, value, middleIndex + 1, maxIndex);
            
        }

        public abstract ResultComparison CompareRespectively(T objOne, T objTwo);
    }
}
