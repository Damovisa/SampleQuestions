using System;
using System.Collections.Generic;
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

            Get["/questions"] = _ => repo.GetRandomQuestions(10).Select(q => new DecoratedShortAnswerQuestion(q));
            Get["/questions/{id}"] = _ =>
            {
                var id = _.id;
                var question = repo.GetQuestion(id);
                if (question == null)
                    return Negotiate.WithStatusCode(HttpStatusCode.NotFound);
                return new DecoratedShortAnswerQuestion(question);
            };
        }
    }
}
