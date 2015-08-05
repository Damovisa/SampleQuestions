namespace SampleQuestions.Data
{
    public class ShortAnswerQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; }
    }

    public class DecoratedShortAnswerQuestion : ShortAnswerQuestion
    {
        public DecoratedShortAnswerQuestion(ShortAnswerQuestion question)
        {
            Id = question.Id;
            Question = question.Question;
        }

        public ShortAnswerLinks Links => new ShortAnswerLinks { _self = $"/questions/{Id}" };
    }

    public class ShortAnswerLinks
    {
        public string _self { get; set; }
    }
}
