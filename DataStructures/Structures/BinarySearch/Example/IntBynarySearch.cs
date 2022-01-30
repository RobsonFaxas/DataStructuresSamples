using DataStructures.Structures.BinarySearch.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Structures.BinarySearch.Example
{
    public class IntBynarySearch : BinarySearch<int>
    {
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
