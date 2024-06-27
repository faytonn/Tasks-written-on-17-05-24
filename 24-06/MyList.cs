using System.Collections;

namespace _24_06
{
    public class MyList : IEnumerable
    {
        private int[] Numbers;

        public MyList()
        {
            Numbers = new int[0];
        }

        public IEnumerator GetEnumerator()
        {
            foreach (int i in Numbers)
            {
                yield return i;
            }

        }

        public int this[int i]
        {
            get 
            {
                return Numbers[i];
            }
            set 
            { 
                Numbers[i] = value;
            }
        }

        public void Add(int number)
        {
            Array.Resize(ref Numbers, Numbers.Length + 1);
            Numbers[^1] = number;
        }

        public bool Contains(int number) 
        {
            foreach(int i in Numbers)
            {
                if (i == number)
                    return true;
            }
            return false;  
        }


        public void Remove(int number)
        {
            for(int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] == number)
                {
                    for (int j = 0; j < Numbers.Length - 1; j++)
                    {
                        Numbers[j] = Numbers[j + 1];
                    }
                    Array.Resize(ref Numbers, Numbers.Length - 1);
                    break;
                }
            }
        }

        public void Reverse(int number)
        {
            int[] ReversedArray = new int[Numbers.Length];

            for(int i = 0;i < Numbers.Length; i++)
            {
                ReversedArray[i] = Numbers[Numbers.Length - i - 1];
            }

            Numbers = ReversedArray;
        }
    }
    
}
