using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_iTi
{
    class Employee //:Preson
    {
        public string Name { get; set; }
        public int NID { get; set; }
        //public int Salary { get; set; }
        public float Salary { get; private set; }
        public event Action<float> notifiy;
        //public Employee(int NID, int Salary) : base(1, "Ahmed")
        //{
        //    this.NID = NID;
        //    this.Salary = Salary;
        //}
        public void IncreaseSalary(float salary)
        {
            Salary += salary;
            if (notifiy != null)
            {
                notifiy(salary);
            }
            
        }
        public Employee(int NID, float Salary,string Name)
        {
            this.Name = Name;
            this.NID = NID;
            this.Salary = Salary;
        }
        public override string ToString()
        {
            return $"Name is {Name}  NID is {NID}    Salary is {Salary}";
        }
    }
}
