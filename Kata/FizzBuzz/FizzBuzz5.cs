﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.FizzBuzz
{
    public class FizzBuzz5
    {
        public IEnumerable<char> Play()
        {
            var rules = new Dictionary<int, string>() { {3, "Fizz"}, {5, "Buzz"} };

            var numbers = Enumerable.Range(1, 100);
            return Play(numbers, rules);
        }

        private IEnumerable<char> Play(IEnumerable<int> numbers, Dictionary<int, string> rules)
        {
            var withFizzesAndBuzzes = numbers.Select(i => ChangeIfNeeded(i, rules));
            return String.Join("\r\n", withFizzesAndBuzzes);
        }

        private string ChangeIfNeeded(int i, Dictionary<int, string> rules)
        {
            if (rules.All(k => i%k.Key != 0)) return i.ToString();
            return String.Join("", rules.Where(k => i % k.Key== 0).Select(k => k.Value));
        }
    }
}