using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Structures.Heap.Min
{
    public class MinHeapBase<T>
    {
        protected int Capacity { get; set; }
        protected int Size { get; set; }
        protected T[] Items { get; set; }


        protected MinHeapBase()
        {           
        }

        public void InitializeHeap(int capacity)
        {
            this.Capacity = capacity;
            Items = new T[capacity];
        }

        public void SetSize(int size)
        {
            this.Size = size;
        }

        protected int LeftChildIndex(int parentIndex) { return 2 * parentIndex + 1; }
        protected int RightChildIndex(int parentIndex) { return 2 * parentIndex + 2; }
        protected int ParentIndex(int childIndex) { return (childIndex - 1)/2; }

        protected bool HasLeftChild(int index) { return LeftChildIndex(index) < Size; }
        protected bool HasRightChild(int index) { return RightChildIndex(index) < Size; }
        protected bool HasParent(int index) { return ParentIndex(index) >= 0 && ParentIndex(index) < Size; }

        protected T LeftChild(int index) { return this.Items[LeftChildIndex(index)]; }
        protected T RightChild(int index) { return this.Items[RightChildIndex(index)]; }
        protected T Parent(int index) { return this.Items[ParentIndex(index)]; }

        protected void Swap(int indexOne, int indexTwo)
        {
            T temp = Items[indexOne];
            Items[indexOne] = Items[indexTwo];
            Items[indexTwo] = temp;
        }

        protected void EnsureExtraCapacity()
        {
            if (Size == Capacity)
            {
                Array.Copy(Items, Items, Capacity * 2);
                Capacity *= 2;
            }
        }


    }
}
