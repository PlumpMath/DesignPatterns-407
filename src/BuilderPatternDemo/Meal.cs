using System;
using System.Collections.Generic;

namespace BuilderPatternDemo
{
    public class Meal
    {
        private readonly List<MealItem> _items = new List<MealItem>();

        public void AddItem(MealItem mealItem)
        {
            _items.Add(mealItem);
        }

        public decimal GetCost()
        {
            decimal cost = 0;
            foreach (var item in _items)
                cost += item.Price;

            return cost;
        }

        public void ShowItems()
        {
            foreach (var item in _items)
            {
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Packer: " + item.Packer.Packer);
                Console.WriteLine("Price: " + item.Price);
            }
        }
    }
}