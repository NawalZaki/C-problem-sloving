using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Employeee
    {
        int id;
        public int ID
        {
            get { return id; }
        }
        public string Phone;
        public string Name;
        public float Salary = 5000;
        public static int CurID;

        public Employeee()
        {
            id = ++CurID;
        }
        public Employeee(string name)
        {
            id = ++CurID;
            Name = name;
        }
        public Employeee(string name, string phone, float salary)
        {
            id = ++CurID;
            Name = name;
            Phone = phone;
            Salary = salary;

        }

    }
}
