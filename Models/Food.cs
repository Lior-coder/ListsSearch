using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsSearch.Models
{
    internal class Food
    {
        public string Name { get; set; }
        public int Cals {  get; set; }
        public int Protein { get; set; }
        public int Fats { get; set; }
        public int Carbs { get; set; }
        public List<Vegetable> vegetablesList { get; set; }
    }
}
