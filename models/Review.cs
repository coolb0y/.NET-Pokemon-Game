namespace webapi.models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public decimal Rating { get; internal set; }
        public virtual Reviewer Reviewer { get; set; }
        public virtual Pokemon Pokemon { get; set; }
        
    }
}
