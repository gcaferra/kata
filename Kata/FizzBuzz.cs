using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace Kata
{
    public class FizzBuzz
    {
        private readonly Dictionary<int, string> _rules;

        public FizzBuzz()
        {
            _rules = new Dictionary<int, string>()
            {
                { 3, "Fizz"},
                { 5, "Buzz"}
            };
        }

        public string Play()
        {
            return string.Join("\r\n", Play(100));
        }

        private IEnumerable<string> Play(int count)
        {
            return Enumerable.Range(1, count).Select(Next);
        }

        private string Next(int i)
        {
            var matching = _rules.Where(w => IsMultipleOf(i, w.Key));
            if (!matching.Any())
                return i.ToString();

            return string.Join("", matching.Select(k => k.Value));
        }

        private static bool IsMultipleOf(int i, int n)
        {
            return i % n == 0;
        }
    }
}