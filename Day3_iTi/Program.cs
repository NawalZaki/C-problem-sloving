using System;

namespace Day3_iTi
{ 
    class Program
    {
        static string GetType(Person p)
        {
            string str = p.GetType().Name;
            return str;
        }
        static void Main(string[] args)
        {
            //string type="";
            //Person p = new Person(20, "Mohammed");
            //Employee emp = new Employee(1, 4000);
            //Trainee t = new Trainee(1,41,22,"Nawal");
            //Console.WriteLine(p.ToString());
            //Console.WriteLine(emp.ToString());
            //Console.WriteLine(t.ToString());
            //Person[] person = new Person[3] {p, emp, t };
            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine($"The Data Of Person {person[i]}");
            //}
            //type = GetType(p);
            //Console.WriteLine($"The Type Of Person is {type}");
            //type = GetType(emp);
            //Console.WriteLine($"The Type Of Person is {type}");
            //type = GetType(t);
            //Console.WriteLine($"The Type Of Person is {type}");
            /////////////////////////Day6
            Employee employee1 = new Employee(1, 7000, "Nawal");
            Employee employee2 = new Employee(2, 800, "Ali");
            Employee employee3 = new Employee(3, 9000, "Mohammed");
            Company company = new Company("iTi", 20000);
            Console.WriteLine($"Salary of Employee1: {employee1.Salary} Company Budget is {company.Budget}");
            company.Add(employee1);
            company.Add(employee2);
            company.Add(employee3);
            employee1.IncreaseSalary(7000);
            foreach (Employee item in company.Filter(e=>e.Salary>5000))
            {
                Console.WriteLine(item);
            }

        }
    }
}
