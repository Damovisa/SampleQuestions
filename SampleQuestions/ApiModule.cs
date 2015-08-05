using System.Linq;
using Nancy;
using Nancy.Responses;
using SampleQuestions.Data;

namespace SampleQuestions
{
    public class ApiModule : NancyModule
    {
        public ApiModule()
        {
            var repo = new QuestionsRepository();

            Get["/questions"] = _ => repo.GetRandomQuestions(10);
            Get["/questions/{id}"] = _ =>
            {
                var id = _.id;
                var question = repo.GetQuestion(id);
                return question ?? Negotiate.WithStatusCode(HttpStatusCode.NotFound);
            };
        }

    }

}
