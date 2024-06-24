#region
//int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//Console.Write("Which index do you desire to remove? \tIndex: ");
//int index = int.Parse(Console.ReadLine());
//Console.WriteLine("");

//restart:
//if(index < 0 || index > array.Length)
//{
//    Console.WriteLine("Wrong input");
//    goto restart;
//}

//RemoveElement(array, index);
//Array.Resize(ref array, array.Length - 1);

//foreach(int i in array)
//{
//    Console.WriteLine(i);
//}

//static void RemoveElement(int[] array, int index)
//{
//    for (int i = index; i < array.Length - 1; i++)
//    {
//        array[i] = array[i + 1];
//    }
//}
#endregion

using lab_task;

Book book1 = new Book("Shade", "Q.K", 2024);
Book book2 = new Book("meow", "A.V", 2024);
Book book3 = new Book("Shade", "A.R", 2024);

Library library = new Library();

Book.AddBook(book1);

