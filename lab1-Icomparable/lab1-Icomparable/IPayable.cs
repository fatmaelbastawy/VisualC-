using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_Icomparable
{
    
    internal class company
    { }
        
    public interface IPayable
    {
        int Salary { get; set; }

        void ShowPayment();
    }

    public class Employee : IPayable
    {

        public int Salary { get; set; }

        public string Name { get; set; }



        public Employee(int salary, string name)    
        {
            Salary = salary;
            Name = name;
        }


        public void ShowPayment()
        {
            Console.WriteLine($"{Name}'s Salary is {Salary}");
        }
    }

    public class Trainee : IPayable
    {

        public int Salary { get; set; }

        public string Name2 { get; set; }


        public Trainee(int salary, string name)    
        {
            Salary = salary;
            Name2 = name;
        }



        public void ShowPayment()
        {
            Console.WriteLine($"{Name2} 's  Salary is {Salary}");
        }

        public override string ToString()
        {
            return $"{Name2} have  Salary {Salary}";
        }
    }

    public class usingComparer : IComparer<Trainee>
    {
        public int Compare(Trainee x, Trainee y)
        {
           

            if (x.Salary > y.Salary)
                return 1;
            else if (x.Salary == y.Salary)
                return 0;
            else
                return -1;
        }
    }

   
    }

