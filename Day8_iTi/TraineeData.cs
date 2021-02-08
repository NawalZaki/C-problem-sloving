using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_iTi
{
    class TraineeData
    {
        public static List<personal_data> trainees_data_list = new List<personal_data>();
    }
    class personal_data
    {
        public int phone { get; set; }
        public string name { get; set; }
        public DateTime birthdate { get; set; }


    }
}
