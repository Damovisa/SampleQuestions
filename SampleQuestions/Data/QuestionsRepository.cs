using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace SampleQuestions.Data
{
    public class QuestionsRepository
    {
        public ShortAnswerQuestion GetQuestion(int id)
        {
            return GetQuestions().SingleOrDefault(q => q.Id == id);
        }

        public IEnumerable<ShortAnswerQuestion> GetRandomQuestions(int count)
        {
            return GetQuestions().TakeRandom(count);
        }

        private IEnumerable<ShortAnswerQuestion> GetQuestions()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SampleQuestions.Data.questions.json"))
            {
                using (var reader = new StreamReader(stream))
                {
                    var result = reader.ReadToEnd();
                    var questions = JsonConvert.DeserializeObject<List<ShortAnswerQuestion>>(result);
                    return questions;
                }
            }
        }

    }
}
