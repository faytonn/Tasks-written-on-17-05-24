namespace LAB_task_27_06
{
    public class Category : Base
    {
        private static int _id;
        public Category(string name) : base(name)
        {
            Name = name;
            Id = ++_id;
        }



    }
}
