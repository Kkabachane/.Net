﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Console.WriteLine(e.EmpNo);
            Console.WriteLine(e1.EmpNo);
            Console.WriteLine(e2.EmpNo);

            Console.WriteLine(e2.EmpNo);
            Console.WriteLine(e1.EmpNo);
            Console.WriteLine(e.EmpNo);
            Console.ReadLine();
        }
    }

    public class Employee
    {
        private string name;
        public string Name
        {
            set 
            {
                name = value;
            }
            get 
            {
                return name;
            }
        }

        static int EmployNo = 0;
        private  int empNo;
        public  int EmpNo
        {
            get 
            {
                return empNo;
            }
        }

        private decimal basic;
        public decimal Basic
        {
            set
            {
                if (value < 20000)
                    basic = value;
            }
            get 
            {
                return basic;
            }
        }

        private short deptNo;
        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptNo = value;
            }
            get
            {
                return deptNo;
            }
        }

        public decimal getNetSalary()
        {
           
            return basic;
        }
     
        public Employee(string Name = "KK", decimal Basic = 15000, short DeptNo = 2)
        {
            empNo = ++EmployNo;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
    }
}
