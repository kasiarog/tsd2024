using System;
using System.Collections.Generic;
using GoldSavings.App.Model;

namespace GoldSavings.App.Services
{
    public class Task2
    {
        public Func<int, bool> isLeapYear = year => (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

        private List<object> _items = new List<object>();
        private Random _random = new Random();

        // a.
        public void Add<T>(T element)
        {
            if (_random.Next(2) == 0)
            {
                _items.Insert(0, element);
            }
            else
            {
                _items.Add(element);
            }
        }

        // b.
        public T Get<T>(int index)
        {
            if (IsEmpty)
                throw new InvalidOperationException("The list is empty.");

            if (index < 0 || index >= _items.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of range.");

            int randomIndex = _random.Next(index);
            return (T)_items[randomIndex];
        }

        // c.
        public bool IsEmpty => _items.Count == 0;
    }
}