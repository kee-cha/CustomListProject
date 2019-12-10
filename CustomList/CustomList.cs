using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }

        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (index < count && index >= 0)
                {
                    items[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
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

            if (count == capacity)
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

        public void Remove(T item)
        {
            T[] bucket = new T[count];
            int j = 0;
            int counter = 0;
            int countHolder = count; //countholder holds original count without changing it
            for (int i = 0; i < countHolder; i++)
            {

                if (items[i].Equals(item) && counter == 0)
                {
                    counter++;
                    count--;
                }
                else
                {
                    bucket[j] = items[i];
                    j++;
                }
            }

            items = new T[count];
            for (int k = 0; k < count; k++)
            {
                items[k] = bucket[k];
            }
        }

        public static CustomList<T> operator -(CustomList<T> items1, CustomList<T> items2)
        {
            CustomList<T> items = new CustomList<T>();
            for (int i = 0; i < items2.count; i++)
            {
                items1.Remove(items2[i]);

            }
            for (int i = 0; i < items1.count; i++)
            {
                items.Add(items1[i]);
            }
            return items;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string result = "";

            for (int i = 0; i < count; i++)
            {
                result = sb.Append(items[i]) + "";
            }
            return result;
        }

        public static CustomList<T> operator +(CustomList<T> items1, CustomList<T> items2)
        {
            CustomList<T> items = new CustomList<T>();
            for (int i = 0; i < items1.count; i++)
            {
                items.Add(items1[i]);
            }
            for (int i = 0; i < items2.count; i++)
            {
                items.Add(items2[i]);
            }
            return items;
        }
    }

}
