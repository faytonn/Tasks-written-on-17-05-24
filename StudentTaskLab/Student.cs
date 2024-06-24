using System.Runtime.InteropServices;

namespace StudentTaskLab
{
    public class Student
    {
        private static int Count;
        private static int Id;
        public int StudentCount { get; }
        public int StudentId { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get; }
        public Student(string name, string surname, string codeEmail)
        {
            StudentId = ++Id;
            Count++;
            Name = name;
            Surname = surname;
            CodeEmail = GenerateEmail();
        }

        public static bool CheckFullName(string fullName)
        {
            bool validFullName = true;
            if(fullName.Length > 3 || fullName.Length < 25)
            {
                return true;
            }
            foreach(char c in fullName)
            {
                if (char.IsDigit(c))
                {
                    validFullName = false;
                    Console.WriteLine("Write a valid name (no digits and character length 3-25");
                }
            }
            

            return false;
        }
        public string GenerateEmail(string codeEmail)
        {
            string email = $"{Name}.{Surname}{StudentId}@code.edu.az";

            return email.ToLower();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {StudentId} \nName: {Name} \nSurname: {Surname} \n{CodeEmail});
        }
    }
}
