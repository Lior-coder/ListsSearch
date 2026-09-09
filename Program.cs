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

            foods.Add(new Food() { Name = "falafel", Cals = 200, Protein = 13});
            foods.Add(new Food() { Name = "pizza", Cals = 400, Protein = 10 });
            foods.Add(new Food() { Name = "shawarma", Cals = 1000, Protein = 26,});

            Dictionary<string, Vegetable> vegetables = new Dictionary<string, Vegetable>();
            vegetables["cucumber"] = new Vegetable() { Color = "Green", Cals = 20 };
            vegetables["tomato"] = new Vegetable() { Color = "Red", Cals = 30 };
            vegetables["pepper"] = new Vegetable() { Color = "Red", Cals = 40 };
            vegetables["onion"] = new Vegetable() { Color = "White", Cals = 15 };

            foods[0].vegetablesList = new List<Vegetable>() { vegetables["tomato"], vegetables["cucumber"] };
            foods[1].vegetablesList = new List<Vegetable>() { vegetables["onion"], vegetables["tomato"] };
            foods[2].vegetablesList = new List<Vegetable>() { vegetables["cucumber"] };
            search = foods.FindAll(x => x.Cals <= 600 && x.Protein > 10 && x.vegetablesList.Contains(vegetables["cucumber"]));
            PrintLst(search);


        }
        public static void PrintLst(List<Food> foods)
        {
            foreach (Food food in foods)
                Console.WriteLine(food.Name);
        }
    }
}
