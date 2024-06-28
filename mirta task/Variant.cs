namespace mirta_task
{
    public class Variant
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        public Variant(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }
    }
}
