using System.Collections;

namespace Lab_12_07
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private T[] arrays = new T[0];

        public CustomStack()
        {
            arrays = new T[0];
        }

        public T this[int index]
        {
            get
              => arrays[arrays.Length - 1 - index];
            set
              => arrays[arrays.Length - 1 - index] = value;
        }
        public void Push(T item)
        {
            Array.Resize(ref arrays, arrays.Length + 1);
            arrays[^1] = item;
        }

        public T Pop()
        {
            T item = arrays[arrays.Length - 1];
            Array.Resize(ref arrays, arrays.Length - 1);
            return item;
        }

        public T Peek()
        {
            return arrays[^0];
        }

        public void IsEmpty(T item)
        {
            if(item == null || arrays.Length == 0)
            {
                Console.WriteLine("There is nothing to show.");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                yield return arrays[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                yield return arrays[i];
            }
        }
    }
}
