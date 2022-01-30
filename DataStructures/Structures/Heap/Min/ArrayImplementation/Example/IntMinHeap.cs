using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Structures.Heap.Min.ArrayImplementation.Example
{
    public class IntMinHeap : MinHeap<int>
    {
        protected IntMinHeap()
        {

        }
        public override ResultComparison CompareRespectively(int objOne, int objTwo)
        {
            if (objOne > objTwo)
                return ResultComparison.Bigger;
            if (objOne < objTwo)
                return ResultComparison.Minor;
            return ResultComparison.Equals;
        }
    }
}
