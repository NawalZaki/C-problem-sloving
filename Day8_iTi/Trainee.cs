using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_iTi
{
    class Trainee
    {
        public static List<trainer> all_trainees = new List<trainer>() {
            new trainer() {id=1,name="Ahmed" },
            new trainer() {id=2,name="Mohamed" },
            new trainer() {id=3,name="Mahmood" },
            new trainer() {id=4,name="Abd All" },
            new trainer() {id=5,name="Ebraheam" },
            new trainer() {id=6,name="Mostafa" },
            new trainer() {id=7,name="Ali"},
            new trainer() {id=8,name="Hossam" }
        };
        public static List<labs> lab_trainees = new List<labs>() {
            new labs() {num=1 },
            new labs() {num=2 },
            new labs() {num=3 },
            new labs() {num=4 },
        };
    }
    class trainer
    {
        public int id { get; set; }
        public string name { get; set; }
        public int labnum { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
    class labs
    {
        public int num { get; set; }
        public List<trainer> lab_member = new List<trainer>();
        public override string ToString()
        {
            return num.ToString();
        }
    }
}
