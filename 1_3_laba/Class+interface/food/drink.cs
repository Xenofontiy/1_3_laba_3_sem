using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_laba.Class_interface
{
    public class drink : bludo
    {
        string drink_name; int drink_pries, drink_pries_of_food, drink_weigh, drink_time_min;
        public string name { get => drink_name; set => drink_name = value; }
        public int pries { get => drink_pries; set => drink_pries = value; }
        public int pries_of_food { get => drink_pries_of_food; set => drink_pries_of_food = value; }
        public int weight { get => drink_weigh; set => drink_weigh = value; }
        public int time_min { get => drink_time_min; set => drink_time_min = value; }
        public drink(string _drink_name, int _drink_pries, int _drink_pries_of_food, int _drink_weight, int _drink_time_min)
        {
            drink_name = _drink_name;
            drink_pries = _drink_pries;
            drink_pries_of_food = _drink_pries_of_food;
            drink_weigh = _drink_weight;
            drink_time_min = _drink_time_min;
        }

    }
}
