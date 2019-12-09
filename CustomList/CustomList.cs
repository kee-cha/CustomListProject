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

        //public void RemoveAll(T item)//this does remove all also
        //{
        //    T[] bucket = new T[count];
        //    int j = 0;
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (item.Equals(items[i]))
        //        { 
        //            count--;
        //        }
        //        else
        //        {
        //            bucket[j] = items[i];
        //            j++;
        //        }
        //    }

        //}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string result ="";

            for (int i = 0; i < count; i++)
            {
                result = sb.Append(items[i]) + "";
            }
            return result;
        }
    }

}
