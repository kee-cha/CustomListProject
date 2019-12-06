using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
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

        public void Add()
        {
            CustomList<T> items = new CustomList<T>();
            
            count++;
        }
    }
}
