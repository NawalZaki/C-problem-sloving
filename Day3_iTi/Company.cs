using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_iTi
{
    class Company
    {
        public string Name { get; set; }
        public float Budget { get; set; }
        List<Employee> Employees =new List<Employee>();

        public Company() { }
        public Company(string Name,float Budget) 
        {
            this.Name = Name;
            this.Budget = Budget;
        }
        public override string ToString()
        {
            return $"Name is {Name}  Budget is {Budget}";
        }
        public void DecreaseBudget(float salary)
        {
            Budget -= salary;
        }
        public void Add(Employee employee)
        {
            Employees.Add(employee);
            employee.notifiy += DecreaseBudget;
        }
        public List<Employee> Filter(Predicate<Employee>filter)
        {
            List<Employee> emp = new List<Employee>();
            foreach (Employee item in Employees)
            {
                if (filter(item))
                {
                    emp.Add(item);
                }
            }
            return emp;
        }
    }
}
