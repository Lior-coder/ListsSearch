using ListsSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Food> foods = new List<Food>();
            List<Food> search = new List<Food>();
            foods.Add(new Food() { Name="falafel", Cals=200});
            foods.Add(new Food() { Name = "pizza", Cals = 400 });
            foods.Add(new Food() { Name = "shawarma", Cals = 1000
            });
            search = foods.FindAll(x => x.Cals <= 600);
            PrintLst(search);
        }
        public static void PrintLst(List<Food> foods)
        {
            foreach (Food food in foods)
            {
                Console.WriteLine(food.Name);
            }
        }
    }
}
