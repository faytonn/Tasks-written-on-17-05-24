namespace LAB_task_27_06
{
    public abstract class Base
    {
        private static int _id;
        public int Id { get; protected set; }
        
        public string Name { get; protected set; }


        protected Base(string name)
        {
            Id = ++_id;
            Name = name;
        }
        
    }
}
