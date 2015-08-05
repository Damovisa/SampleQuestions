using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestions.Data
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> TakeRandom<T>(this IEnumerable<T> items, int count)
        {
            if (count <= 0 || !items.Any())
                yield break;

            var rnd = new Random();
            var itemCount = items.Count();
            for (int i = 0; i < count; i++)
            {
                var index = rnd.Next(0, itemCount - 1);
                yield return items.ElementAt(index);
            }
        }
    }
}
