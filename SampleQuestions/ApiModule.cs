using Nancy;

namespace SampleQuestions
{
    public class ApiModule : NancyModule
    {
        public ApiModule()
        {
            Get[""] = _ => new MessageResponse { Text = "Hello World" };
        }
    }

    public class MessageResponse
    {
        public string Text { get; set; }
    }
}
