using System;
using System.Collections.Generic;

namespace Day2_iTi
{
    class Point :  ICloneable,IComparable<Point>
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Point():this(0,0,0)
        { }
        public Point(int X,int Y):this(X,Y,0)
        { }

        public Point (int X,int Y,int Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public int CompareTo(Point other)
        {

            if (other == null)
                return 1;
            return this.x.CompareTo(other.x);
        }
        public object Clone()
        {
            return new Point(this.x, this.y, this.z);
        }
        public void Display()
        {
            Console.WriteLine($"X={x} Y={y} Z={z}");
        }
        public void ChangeCoordinates(int x1,int y1,int z1)
        {
            x = x1;
            y = y1;
            z = z1;
        }
        //Day3
        public override string ToString()
        {
            return $"X={x} Y={y} Z={z}";
        }
        /*
        public override bool Equals(object obj)
        {
            if (obj is Point)
            {
                Point point = (Point)obj;
                return this.x == point.x && this.y == point.y && this.z == point.z;
            }
            else
                return false;
        }*/
        public static void Display(Point[] points)
        {  
            for(int i=0;i<points.Length;i++)
            {
                Console.WriteLine($"Point is:{points[i]}");
            }
        
        }
    }
    public enum Role
    {
        Admin = 1,
        Accountant = 2,
        Stock = 4,
        Reception = 8
    }
    public struct Employee
    {
        public string Name;
        public int Salary;
        Role role;
        public Employee(String name, int salary, Role role1)
        {
            Name = name;
            Salary = salary;
            role = role1;
        }
        public void AssignRole(Role role)
        {
            this.role = this.role | role;
        }
        public Boolean HasRole(Role role)
        {
            if ((this.role & role) == role)
            {
                Console.WriteLine($"Role :{role}");
                return true;

            }
            return false;
        }
        public void Display()
        {
            Console.WriteLine($"Name : {Name} Salary : {Salary} ");
            foreach (Role val in Enum.GetValues(typeof(Role)))
            {
                
                HasRole(val);
            }
        }
    }
        class Program
    {
      
        
        
        static void ChangeText(string str)
        {
            str = "nawal";
        }
        static void Main(string[] args)
        {
            ////1
            //Employee emp1 = new Employee("Nawal", 3000, Role.Accountant);
            //emp1.AssignRole(Role.Admin);
            //emp1.Display();
            //emp1.HasRole(Role.Admin);
            ////emp1.HasRole(Role.Accountant);
            ////emp1.AssignRole(Role.Stock);
            ////emp1.Display();

            //Console.WriteLine("/////////////////////////////////////////");
            ////2
            //Point p1 = new Point(1, 2, 3);
            //Point p2 = new Point(1, 2, 3);
            //Console.WriteLine($"Point 1 ----> ");
            //p1.Display();
            //Console.WriteLine($"Point 2 ----> ");
            //p2.Display();
            //if(p1==p2)
            //{ Console.WriteLine($"Point 1 Equal Point 2 "); }
            //else
            //{ Console.WriteLine($"Point 1 Not Equal Point 2 "); }
            //p1.ChangeCoordinates(4, 5, 6);
            //Console.WriteLine($"After Changing... ");
            //p1.Display();

            //Console.WriteLine("/////////////////////////////////////////");
            ////3
            //string s = "nona";
            //Console.WriteLine($"Before Change {s}");
            //ChangeText(s);
            //Console.WriteLine($"After Change {s}");

            ////Day3
            Point point = new Point() { x = 1, y = 2, z = 3 };
            Point point1 = new Point() { x = 2, y = 3, z = 4 };
            Point point2= new Point() { x = 2, y = 3, z = 4 };
            Point point3 = new Point() { x = 5, y = 10, z = 1 }; 
            Point point4 = new Point() { x = 6, y = 9, z = 2 };
            Point point5 = new Point() { x = 7, y = 8, z = 3 };
            Point point6 = new Point() { x = 8, y = 7, z = 4 };
            object obj = new Point();
            Console.WriteLine(point.ToString());
            if (point1.Equals(point2))
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("Not Equals");
            }

            if (point1==point2)
            {
                Console.WriteLine("Equals");
            }
             
            else
            {
                Console.WriteLine("Not Equals");
            }
            //Day4
            Point[] array = new Point[] { point1, point2, point3, point4, point5, point6 };
            Array.Sort(array);
            Point point7 = point2.Clone() as Point;
            Console.WriteLine($"Point clone :{point7.ToString()}");


        }
    }
}
