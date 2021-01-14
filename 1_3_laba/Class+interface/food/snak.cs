using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_laba.Class_interface
{
    public class snak : bludo
    {
        string snak_name; int snak_pries, snak_pries_of_food, snak_weigh, snak_time_min;
        public string name { get => snak_name; set => snak_name = value; }
        public int pries { get => snak_pries; set => snak_pries = value; }
        public int pries_of_food { get => snak_pries_of_food; set => snak_pries_of_food = value; }
        public int weight { get => snak_weigh; set => snak_weigh = value; }
        public int time_min { get => snak_time_min; set => snak_time_min = value; }
        public snak(string _snak_name, int _snak_pries, int _snak_pries_of_food, int _snak_weight, int _snak_time_min)
        {
            snak_name = _snak_name;
            snak_pries = _snak_pries;
            snak_pries_of_food = _snak_pries_of_food;
            snak_weigh = _snak_weight;
            snak_time_min = _snak_time_min;

        }
    }
}
