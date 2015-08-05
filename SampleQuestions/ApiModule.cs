using Nancy;

namespace SampleQuestions
{
    public class ApiModule : NancyModule
    {
        public ApiModule()
        {
            Get[""] = _ => "Hello World";
        }
    }
}
