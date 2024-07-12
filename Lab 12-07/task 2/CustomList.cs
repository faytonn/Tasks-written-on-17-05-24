using System.Collections;

namespace Lab_12_07
{
    public class CustomList<T> : IEnumerable<T>
    {
        public int Count
        {
            get
              => lists.Length;
        }
        private T[] lists;
        public CustomList()
        {
            lists = new T[0];
        }

        public T this[int index]
        {
            get
              => lists[lists.Length - 1 - index];
            set
              => lists[lists.Length - 1 - index] = value;
        }


        public void Add(T item)
        {
            Array.Resize(ref lists, lists.Length + 1);
            lists[^1] = item;
        }

        public bool Find(T item)
        {
            foreach (var t in lists)
            {
                if (t.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void Remove(T item)
        {
            for (int i = 0; i < lists.Length; i++)
            {
                if (item.Equals(lists[i]))
                {
                    for (int j = i; j < lists.Length - 1; j++)
                    {
                        lists[j] = lists[j + 1];
                    }
                }
            }
            Array.Resize(ref lists, lists.Length - 1);
        }

        public void RemoveAll()
        {
            Array.Resize(ref lists, 0);
        }



        public IEnumerator<T> GetEnumerator()
        {
            for (int i = lists.Length - 1; i >= 0; i--)
            {
                yield return lists[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = lists.Length - 1; i >= 0; i--)
            {
                yield return lists[i];
            }
        }
    }
}
