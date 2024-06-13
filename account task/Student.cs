namespace account_task
{
    public class Student 
    {
        private static int id;
        public int Id { get; }
        public string FullName { get; set; }


        public int Point {  get; set; }

        public Student(string fullName, int point)
        {
            Id = ++id;
            FullName = fullName;
            Point = point;
        }

        public string StudentInfo()
        {
            return $"ID: {Id} \tFull Name: {FullName} \tPoint: {Point}";
        }


    }
}
