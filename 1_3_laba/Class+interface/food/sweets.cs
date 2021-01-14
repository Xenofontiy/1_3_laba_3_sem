using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_laba.Class_interface
{
    public class sweets : bludo
    {
        public string sweets_name; public int sweets_pries, sweets_pries_of_food, sweets_weigh, sweets_time_min;

        public string name { get => sweets_name; set => sweets_name = value; }
        public int pries { get => sweets_pries; set => sweets_pries = value; }
        public int pries_of_food { get => sweets_pries_of_food; set => sweets_pries_of_food = value; }
        public int weight { get => sweets_weigh; set => sweets_weigh = value; }
        public int time_min { get => sweets_time_min; set => sweets_time_min = value; }

        public sweets(string _sweets_name, int _sweets_pries, int _sweets_pries_of_food, int _sweets_weight, int _sweets_time_min)
        {
            sweets_name = _sweets_name;
            sweets_pries = _sweets_pries;
            sweets_pries_of_food = _sweets_pries_of_food;
            sweets_weigh = _sweets_weight;
            sweets_time_min = _sweets_time_min;
        }
    }
}
