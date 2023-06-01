using System.Text;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        public int Count { get => count; }
        public int Capacity { get => capacity; }
        public T[] Items { get => items; set => items = value; }
        public T this[int index]
        {
            get
            {
                return Items[index];
            }
            set
            {
                Items[index] = value;
            }
        }

        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }


        //Member Methods (CAN DO)
        public void Add(T item)
        {
            if (capacity <= count)
            {
                capacity *= 2;
                T[] newItems = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;
            }
            items[count] = item;
            count++;

            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
        }

        public bool Remove(T item)
        {
            int index = Array.IndexOf(items, item, 0, count);
            if (index >= 0)
            {
                for (int i = index; i < count - 1; i++)
                {
                    items[i] = items[i + 1];
                }
                items[count - 1] = default(T);
                count--;
                return true;
            }
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
            return false;
        }

        public override string ToString()

        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < count; i++)
            {
                sb.Append(items[i]);
                if (i < count - 1)
                {
                    sb.Append(", ");
                }
            }
            sb.Append("]");
            return sb.ToString();
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> combinedLists = new CustomList<T>();
            for (int i = 0; i < firstList.count; i++)
            {
                combinedLists.Add((T)firstList.items[i]);
            }

            for (int i = 0; i < secondList.count; i++)
            {
                combinedLists.Add((T)secondList.items[i]);
            }
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return combinedLists;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> minusLists = firstList - secondList;
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return minusLists;
        }


    }
}
