using LAB_task_27_06;

Library[] libraries = new Library[0];
Book[] books = new Book[0];
Category[] categories = new Category[0];

Console.WriteLine("-------------");
Console.WriteLine("Menu");
Console.WriteLine("-------------");

Console.WriteLine("[1] Create a new library");
Console.WriteLine("[2] Create a new category");
Console.WriteLine("[3] Create a new book");
Console.WriteLine("[4] Enter the library");
Console.WriteLine("[0] Exit");
Console.WriteLine(">>>");

int command = int.Parse(Console.ReadLine());

switch (command)
{
    case 1:
        Console.Write("Enter the library's name: ");
        string libraryName = Console.ReadLine();

        Library library = new Library(libraryName);
        Array.Resize(ref libraries, libraries.Length + 1);
        libraries[^1] = library;
        Console.WriteLine($"The '{libraryName}' library is created");
        break;

    case 2:
        Console.Write("Enter the new category: ");
        string categoryName = Console.ReadLine();

        Category category = new Category(categoryName);
        Array.Resize(ref categories, categories.Length + 1);
        categories[^1] = category;
        Console.WriteLine($"The '{categoryName}' is created");
        break;
    case 3:
        Console.WriteLine("Enter the new book name: ");
        string bookName = Console.ReadLine();
        Console.WriteLine("Enter the author of the book: ");
        string authorName = Console.ReadLine();
        Console.WriteLine("What category does it belong to? (Enter the ID): ");
        foreach (var item in categories)
        {
            Console.WriteLine(categories);
        }
        int categoryChoice = int.Parse(Console.ReadLine());
        foreach (var item in categories)
        {
            if (item.Id == categoryChoice)
            {
                Book book = new Book(bookName, authorName, item);

                    Array.Resize(ref books, books.Length + 1);
                    books[^1] = book;
                Console.WriteLine("Book successfully added");
            }
        }



        Book book = new Book(bookName, );


}