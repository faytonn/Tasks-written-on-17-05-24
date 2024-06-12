
// /* Task 1 * -> FIBONACCI SEQUENCE/
////0,1,1,2,3,5,8,13,21,34,55,89,144,
//int x = 0;
//int y = 1;

//// (n-1) + (n-2)
//Console.Write(x + ",");
//Console.Write(y + ",");

//while (true)
//{
//    int z = x + y;
//    Console.Write(z);
//    x = y;
//    y = z;
//  Console.ReadLine();
//}




/* Task 2 * -> ADLARIN PRINT OLUNMASI/
//string[] names = {"Asiman", "Ismayil", "Musa"};
//int i = 0;

//while(true)
//{
//    if (i < names.Length)
//    {
//        Console.WriteLine(names[i]);
//        i++;
//    }


/* Task 3 * -> MAXIMUMUN TAPILMASI/
//int[] numbers = { 21, 31, 32, 1, 3, 213, 12, 231 };
//int max = numbers[0];
//int i = 0;
//while (i < numbers.Length)
//{
//    if (numbers[i] > max)
//    {
//       max = numbers[i];

//    }
//    i++;
//}
//Console.WriteLine(max);


/* Task 4 * -> MINIMUMUN TAPILMASI/
//int[] numbers = { 21, 31, 32, 1, 3, 213, 12, 231 };
//int min = numbers[0];
//int i = 0;

//while (i < numbers.Length)
//{
//    if (numbers[i] < min)
//    { 
//        min = numbers[i];
//    }
//    i++;
//}

//Console.WriteLine(min);


///* Task 5 * -> ????????/
//int[] numbers = { 21, 31, 32, 1, 3, 231, 12, 1 };
//int min = numbers[1];
//int max = numbers[0];
//int i = 1;

//while (i < numbers.Length)
//{
//    if (numbers[i] < min)
//    {
//        min = numbers[i];
//    }
//    else if (numbers[i] > max) 
//    { 
//        max = numbers[i];
//    }
//    i++;
//}


//Console.WriteLine(min);
//Console.WriteLine(max);


/* Task 6* - EDEDI ORTANIN TAPILMASI */
// //ededi orta -> total / numbers.length
// int[] numbers = { 1, 5, 7, 22, 41, 10, 100, 141 };
// int i = 0;
// decimal total = 0M;

// while (i < numbers.Length)
// {
//     total += numbers[i];
//     i++;
// }
//decimal meanAverage = total / numbers.Length;
// Console.WriteLine(meanAverage);


/* task 8 -> ARRAYIN TERSINE CEVRILMESI */
// i-- istifade edilecek

//int[] number = { 1, 3, 5, 10, 12, 25, 34, 47, 49 };
//int i = 0;

/* TASK 9 -> arrayin movcud olub-olmadigini ashkarlamaq*/
//int[] numbers = { 1, 2, 4, 7, 20, 15 };
//int i = 0;

////Console.WriteLine("Please write a number: " + int.Parse(Console.ReadLine())); 

//Console.WriteLine("Please write a number: ");
//int input = int.Parse(Console.ReadLine());
//bool result=false;
//while (i < numbers.Length)
//{
//    //if ((int.Parse(Console.ReadLine()) == numbers[i])
//    if (input == numbers[i])
//    {
//       result=true;
//        break;
//    }

//    i++;
//}
//Console.WriteLine(result);


/* TASK 10 -> ARRAYLERIN SIRA ILE VERILMESI */
//int[] number = { 2, 5, 4, 10, 7, 4, 1 };
//int i = 0;
//int firstNumber = number[0];

//bool isSorted = true;

//while (i < number.Length)
//{
//    if (number[i+1] < number[i])
//    {
//        isSorted = false;
//        break;
//    }
//   i++;  
//}
//Console.WriteLine(isSorted);

//     /* TASK 11 -> MAX ILE MIN-IN YERIN DEYISHMEK */
//      int[] numbers = { 4, 1, 6, 7, 8, 9 };
//      int i = 0;

//      int max = 0;
//      int min = 0;

//      while (i < numbers.Length)
//      {
//          if (max < numbers.Length)
//          {
//              max = numbers[i];
//          }
//          if (min > numbers[i])
//          {
//              min = numbers[i];
//          }
//          i++;
//}
//      i = 0;
//      while( i < numbers.Length)
//      {
//          if (numbers[i] == max)
//          {
//              numbers[i] = min;
//          }
//         else if (numbers[i] == min)
//          {
//              numbers[i] = max;
//          }
//      }

//      i = 0;

//      while (i < numbers.Length)
//      {
//          Console.Write(numbers[i] + ",");
//          i++;
//      }

//int[] nums = new int[5] { 10, 15, 16, 8, 6 };

//nums.Max(); // returns 16
//nums.Min(); // returns 6
//nums.Sum(); // returns 55
//nums.Average(); // returns 55

//Console.WriteLine(nums.Max());


//int[] numbers = { 2, 3, 6, 12, 5, 23, 5, 3, 43, 213 };
//Console.WriteLine("Please write the intervals of two indices to be added");

//int input1 = int.Parse(Console.ReadLine());
//int input2 = int.Parse(Console.ReadLine());
//int total = 0;

//for (int i = input1 - 1; i < input2 - 1; i++)
//{
//    total += numbers[i];
//    if(input1 < 0 || input 2 < 0)
//    {
//        Console.WriteLine("Index out of boundaries")
//    }

//}
//Console.WriteLine(total);



//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//if (true)
//{
//    int[] modifiedNumbers = new int[numbers.Length];
//    for (int i = numbers.Length - 1; i >= 0; i--)
//    {

//        modifiedNumbers[numbers.Length - 1 - i] = numbers[i];

//        Console.WriteLine(numbers[i]);
//    }
//}

/*  BUTUN MATRIKSLERI YAZMAQ*/
//int[,] nums = { { 10, 20, 30, }, { 15, 30, 45 }, { 40, 60, 80 } };

//for (int i = 0; i < nums.GetLength(0); i++)
//{
//    for (int j = 0; j < nums.GetLength(1); j++)
//    {

//        Console.Write(nums[i, j] + ",");
//    }
//    Console.WriteLine();
//}


/* 3 dene ic-ice */
//int[,,] numbers2 = { { {1, 2, 3 }, {4, 5, 6 } }, { {7, 8 , 9 }, {10, 11, 12 } }, { {13, 14, 15 }, {16, 17, 18 } } };

//for (int i = 0; i < numbers2.GetLength(0); i++)
//{
//    for (int j = 0; j < numbers2.GetLength(1); j++)
//    {
//        for(int k = 0; k < numbers2.GetLength(2); k++)
//        {
//            Console.Write(numbers2[i,j,k] + ",");
//        }
//    }
//    Console.WriteLine();

//}

//string name = "Salam, menim adim Asimandir";
////Salam
////menim
////adim
////Asimandir
//string[,] names = { { "Salam," }, { "menim" }, { "adim" }, { "Asimandir" } };

//for (int i = 0; i < names.GetLength(0); i++)
//{
//    for (int j = 0; j < names.GetLength(1); j++)
//    { 
//    Console.WriteLine(names[i,j]);
//    }

//}




/* Sozleri bir-bir alt-alta qoymaq*/
//string sentence = "Salam, menim adim Asimandir";
//string word = " ";



//    for (int i = 0; i <= sentence.Length; i++)
//    {
//        if (sentence[i] == ' ' || i == sentence.Length+1)
//        {
//            Console.WriteLine(word);
//            word = " ";
//        }
//        else
//        {
//            word += sentence[i];
//        }

//         if (i == sentence.Length - 1)
//         {
//        Console.WriteLine(word);
//         }
//    }



/* Tersine (console ile) */
//string name = "Fatima";


//for (int i = name.Length - 1; i >= 0; i--) 
//{
//    Console.Write(name[i]);
//}




/* Tersine (bashqa yol ile) */
//string name = "Fatima";
//string reverseName = " ";

//for (int i = name.Length - 1; i >= 0; i--)
//{
//    reverseName += name[i];
//}
//Console.WriteLine(reverseName);\\




#region nece herf var verilen soz/cumlede 
//while (true)
//{
//Console.WriteLine("Please write a sentence: ");
//string sentence = Console.ReadLine().ToLower();
//Console.WriteLine("Write a character you want to know the count of: ");
//char element = char.Parse(Console.ReadLine().ToLower());
//int count = 0;
//    for (int i = 0; i < sentence.Length; i++)
//    {
//        if (sentence[i] == element)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//    continue;
//}
#endregion

#region is there a digit in the given sentence? 
//while (true)
//{

//    string sentence = (Console.ReadLine().ToLower());
//    bool isADigit = false;


//    for (int i = 0; i < sentence.Length; i++)
//    {
//        if (char.IsDigit(sentence[i]))
//        {
//            isADigit = true;
//            break;
//        }

//    }

//    if (isADigit)
//    {
//        Console.WriteLine("There is a digit in the given sentence");

//    }
//    else

//    {
//        Console.WriteLine("no.");
//    }


//}
#endregion

#region is a letter included or not
//string inputGiven = Console.ReadLine();
//bool letterIncluded = false;


//for (int i = 0; i < inputGiven.Length; i++)
//{
//    int asciiValue = (int)inputGiven[i];
//    if ((int)inputGiven[i] >= 65 && (int)inputGiven[i] <= 90)
//    {
//        letterIncluded = true;


//    }
//    else
//    {
//        letterIncluded = false;
//        break;
//    }

//    if (asciiValue >= 97 && asciiValue <= 122)
//    {
//        letterIncluded = true;

//    }
//    else
//    {
//        letterIncluded = false;
//    }
//}
//      if (!letterIncluded)
//      {
//         Console.WriteLine("stringin daxilinde herf var");
//      }
//     else
//     {
//    Console.WriteLine("yoxdur");
//     }

#endregion

#region Her hansi bir herfin string daxilinde olan tekrarlarin sayi 

//string inputGiven = Console.ReadLine();
//bool isRepeated = false;

//for (int i = 0; i < inputGiven.Length; i++)
//{
//    int asciiValue = inputGiven[i];
//    if (asciiValue >= 65 && asciiValue <= 90)
//    {

//    }
//}
//}

#endregion

#region prime number
//static void Main(string[] args)
//{
//    int number = int.Parse(Console.ReadLine());
//    Console.WriteLine(checkPrimeNumber(number));
//}

//private static bool checkPrimeNumber(int number)
//{
//    bool isPrimeNumber = false;

//    int primeNumber = int.Parse(Console.ReadLine());
//    Console.WriteLine("Write a number");

//    while (primeNumber > 1)
//    {
//        for (int i = 2;  i < primeNumber; i++)
//        {
//           if (primeNumber % 1 == 0 && primeNumber % primeNumber == 0)
//           {
//               isPrimeNumber = true;
//            Console.WriteLine("true");
//           }
//           else if (primeNumber % 2 == 0)
//           {
//            isPrimeNumber = false;
//            Console.WriteLine("false");
//           }
//           else
//           {
//            isPrimeNumber = false;
//           }

//        }

//    }

//    return primeNumber;
//}
#endregion

#region perfect number
//private static void Main(string[] args)
//{
//    Console.WriteLine("eded daxil edin");
//    int number = int.Parse(Console.ReadLine());

//    if (isperfect(number))
//    {
//        Console.WriteLine("True");
//    }
//    else
//    {
//        Console.WriteLine("False");
//    }

//}

//private static bool isperfect(int number)
//{


//        int total = 0;

//        for (int i = 1; i < number; i++)
//        {
//            if (number % i == 0)
//            {
//                total += i;
//            }


//        }

//    return total == number;
//}
#endregion

#region stars length increasing/decreasing pattern
//private static void Main(string[] args)
//{
//    Console.WriteLine("Write the desired length");
//    int number = int.Parse(Console.ReadLine());
//    starsLength(number);
//}

//private static bool starsLength(int number)
//{

//    for (int i = 0; i < number; i++)
//    {
//        for (int j = 0; j <= i; j++)
//        {
//            Console.Write("+");

//        }
//        Console.WriteLine(" ");
//    }

//    for (int i = number - 1; i > 0; i--)
//    {
//        for (int j = 0;j < i; j++)
//        {
//            Console.Write("+");
//        }
//        Console.WriteLine();
//    }


//    return true;
//}
#endregion

#region months to years
//private static void Main(string[] args)
//{
//    Console.WriteLine("Enter the months you want to convert to year/s");
//    int months = int.Parse(Console.ReadLine());
//    monthsToYear_s(months);
//}


//private static void monthsToYear_s(int count)
//{
//    int years = count / 12;
//    int months = count % 12;

//    if (years == 0)
//        Console.WriteLine($"month: {months}");
//    else if (months == 0)
//        Console.WriteLine($"Year: {years}");
//    else
//    {
//        Console.WriteLine($"year: {years} and month: {months}");
//    }

//}
#endregion

#region product of the maximum and minimum digit
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Please enter an input:");
//        int number = int.Parse(Console.ReadLine());

//        int product = ProductOfMinAndMax(number);
//        Console.WriteLine("The product of the minimum and maximum digits is: " + product);
//    }

//    private static int ProductOfMinAndMax(int number)
//    {
//        int max = number % 10;
//        int min = number % 10;
//        number /= 10;

//        while (number > 0)
//        {
//            int digit = number % 10;

//            if (digit > max)
//                max = digit;
//            if (digit < min)
//                min = digit;

//            number /= 10;
//        }

//        return max * min;
//    }
//}
#endregion

#region Palindrome
//private static void Main(string[] args)
//{
//    int number = int.Parse(Console.ReadLine());
//    if(Palindrome(number))
//    {
//    Console.WriteLine("true");
//    }
//    else
//    {
//        Console.WriteLine("false");
//    }

//}
//private static bool Palindrome(int number)
//{
//    bool isPalindrome = false;
//    int reverseNumber = 0;
//    int cloneNumber = number;

//    while (cloneNumber > 0)
//    {
//        int result = cloneNumber % 10;
//        reverseNumber = reverseNumber * 10 + result;
//        cloneNumber /= 10;
//    }


//    return reverseNumber == number;

//}
#endregion

#region fahrenheit to celsius
//private static void Main(string[] args)
//{
//    int celsius = int.Parse(Console.ReadLine());
//    int fahrenheit = (celsius * 9) / 5 + 32;
//    Console.WriteLine($"{fahrenheit}");

//}
#endregion

#region classes working
//using working;

//Student student = new Student()
//{
//    Name = "Fatima",
//    Surname = "Valiyeva",
//    AvgPoint = 10
//};

//group_class group = new group_class()
//{
//    GroupName = "PB303",
//    StudentLimit = 18
//};

//group_class.AddStudent(student);
#endregion


#region 1-10 array olsun ekrana cixartsin
//int[] numbers = new int[0];
//Console.Write(numbers);
//for (int i = 1; i < 11; i++)
//{
//    Array.Resize(ref numbers, numbers.Length + 1);
//    numbers[^1] = i;
//}

//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}



#endregion

#region sdbahsbda

//using working;

//Person2 person = new Person2
//{
//    Name = "Fatima",
//    Age = 17
//};
//person.Introduce();




#endregion

#region Person task
//using working;

//static void Main(string[] args)
//{
//    Student student1 = new("Gunel", "Qehremani", 20, false);
//    Student student2 = new("Fatima", "Valiyeva", 17, false);
//    Student student3 = new("Aysun", "Eminli", 18, true);
//    Student student4 = new("Musa", "Abbasov", 20, true);

//    Group group1 = new("PB303");
//}



#endregion

#region  message sender

using working;

string command;
bool systemProcess = true;
EmailSender emailSender = new EmailSender();
SmsSender smsSender = new SmsSender();

while (systemProcess)
{
    Console.Clear();

    Console.WriteLine("Menu:");
    Console.WriteLine("1. Send message by email");
    Console.WriteLine("2. Send message by SMS");
    Console.WriteLine("0.Quit");

    command = Console.ReadLine();

    if (command == "1")
    {
        emailSender.SendMessage("asjdasdasdjkaj");
    }
    else if (command == "2")
    {
        smsSender.SendMessage("ASDBJASDBJ");
    }
    else if (command == "0")
    {
        break;
    }
    else
    {
        Console.WriteLine("gicbeser duz yaz da bir dene command istedik onu da yazammirsan");
        systemProcess = false;
        break;
    }
    Console.ReadLine();
}


#endregion