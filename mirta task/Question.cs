namespace mirta_task
{
    public class Question
    {
        public string Text { get; set; }
        public List<Variant> Variants { get; set; }

        public Question(string text)
        {
            Text = text;
            Variants = new List<Variant>();
        }

        public void AddVariant (Variant variant)
        {
            Variants.Add(variant);
        }
    }
}
