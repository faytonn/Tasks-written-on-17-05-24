namespace mirta_task
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }
        public Quiz()
        {
            Questions = new List<Question>();
        }

        public void AddQuestion (Question question)
        {
            Questions.Add(question);
        }

    }
}
