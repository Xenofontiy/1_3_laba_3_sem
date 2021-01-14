using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_laba.Class_interface
{
    public class hot_food : bludo
    {
        string hot_name; int hot_pries, hot_pries_of_food, hot_weigh, hot_time_min;
        public string name { get => hot_name; set => hot_name = value; }
        public int pries { get => hot_pries; set => hot_pries = value; }
        public int pries_of_food { get => hot_pries_of_food; set => hot_pries_of_food = value; }
        public int weight { get => hot_weigh; set => hot_weigh = value; }
        public int time_min { get => hot_time_min; set => hot_time_min = value; }
        public hot_food(string _hot_name, int _hot_pries, int _hot_pries_of_food, int _hot_weight, int _hot_time_min)
        {
            hot_name = _hot_name;
            hot_pries = _hot_pries;
            hot_pries_of_food = _hot_pries_of_food;
            hot_weigh = _hot_weight;
            hot_time_min = _hot_time_min;

        }
    }
}
