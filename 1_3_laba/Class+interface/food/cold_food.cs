using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_laba.Class_interface
{
    public class cold_food : bludo
    {
        string cold_food_name; int cold_food_pries, cold_food_pries_of_food, cold_food_weigh, cold_food_time_min;
        public string name { get => cold_food_name; set => cold_food_name = value; }
        public int pries { get => cold_food_pries; set => cold_food_pries = value; }
        public int pries_of_food { get => cold_food_pries_of_food; set => cold_food_pries_of_food = value; }
        public int weight { get => cold_food_weigh; set => cold_food_weigh = value; }
        public int time_min { get => cold_food_time_min; set => cold_food_time_min = value; }
        public cold_food(string _cold_food_name, int _cold_food_pries, int _cold_food_pries_of_food, int _cold_food_weight, int _cold_food_time_min)
        {
            cold_food_name = _cold_food_name;
            cold_food_pries = _cold_food_pries;
            cold_food_pries_of_food = _cold_food_pries_of_food;
            cold_food_weigh = _cold_food_weight;
            cold_food_time_min = _cold_food_time_min;
        }
    }
}
