using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Structures.Heap.Min
{
    public abstract class MinHeap<T> : MinHeapBase<T>
    {
        protected MinHeap() { }

        public T Peek()
        {
            if (Size == 0) throw new IndexOutOfRangeException();
            return Items[0];
        }

        public T Poll()
        {
            if (Size == 0) throw new IndexOutOfRangeException();
            T item = Items[0];
            Items[0] = Items[Size - 1];
            Size--;
            HeapifyDown();
            return item;
        }        

        public void Add(T item)
        {
            EnsureExtraCapacity();
            Items[Size] = item;
            Size++;
            HeapifyUp();
        }

        private void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                int smallerChildIndex = LeftChildIndex(index);
                if (HasRightChild(index) && CompareRespectively(RightChild(index), LeftChild(index)) == ResultComparison.Minor)
                    smallerChildIndex = RightChildIndex(index);
                if (CompareRespectively(Items[index], Items[smallerChildIndex]) == ResultComparison.Minor)
                    break;
                Swap(index, smallerChildIndex);
                index = smallerChildIndex;
            }
        }

        private void HeapifyUp()
        {
            int index = Size - 1;
            while(HasParent(index) && CompareRespectively(Parent(index), Items[index]) == ResultComparison.Bigger)
            {
                Swap(ParentIndex(index), index);
                index = ParentIndex(index);
            }
        }

        public abstract ResultComparison CompareRespectively(T objOne, T objTwo);
    }
}
