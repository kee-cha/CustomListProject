using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomList
{
    public class CustomList<T>: IEnumerable
    {
        private int count;
        private int capacity;
        private T[] items;
        

        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }
        public T this[int index] 
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
                 
        }

        public int Count
        {
            get
            {
                return count;
            }

        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public void Add(T item)
        {

            if(count == capacity)
            {
                capacity *= 2;
            }
            T[] bucket = new T[count];
            for (int i = 0; i < count; i++)
            {
                bucket[i] = items[i];
            }
            items = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                items[i] = bucket[i];
            }
            items[count] = item;
            count++;
        }
    }
}
