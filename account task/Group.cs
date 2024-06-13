namespace account_task
{
    public class Group
    {
        public string GroupName { get; set; }
        public int StudentLimit { get; set; }
        public Student[] students;
        private int StudentCount;

        public Group(string groupName, int studentLimit)
        {
            if (CheckStudentLimit(studentLimit) == false)
            {
                Console.WriteLine("Student amount must be between 5 and 18");
                studentLimit = 18;
            }
            GroupName = groupName;
            StudentLimit = studentLimit;
            students = new Student[studentLimit];
            StudentCount = 0;
        }


        public bool CheckStudentLimit(int studentLimit)
        {
            bool rightAmount = true;

            if (studentLimit < 5 && studentLimit > 18)
            {
                rightAmount = false;
            }
            return rightAmount;
        }


        public bool CheckGroupName(string groupName)
        {
            bool firstTwoCapital = false;
            bool lastThreeDigits = false;

            if (GroupName.Length == 5)
            {

                if (char.IsUpper(groupName[0]) && char.IsUpper(groupName[1]) && char.IsDigit(groupName[2]) && char.IsDigit(groupName[3]) && char.IsDigit(groupName[4]))
                {
                    firstTwoCapital = true;
                    lastThreeDigits = true;
                    return firstTwoCapital && lastThreeDigits;
                }

            }
            return false;
        }

        public void AddStudent(Student student)
        {
            if (StudentCount < StudentLimit)
            {
                Array.Resize(ref students, StudentCount + 1);
                students[StudentCount - 1] = student;
            }
        }

        public Student GetStudent(int id)
        {
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    return student; 
                }
            }
            return null;

        }

        public void GetAllStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.StudentInfo);
            }
        }



    }
}
