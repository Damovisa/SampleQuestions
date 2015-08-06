using Nancy;

namespace SampleQuestions
{
    public class QuestionsModule : NancyModule
    {
        public QuestionsModule()
        {
            Get["/"] = _ => View["Index"];
        }
    }
}
