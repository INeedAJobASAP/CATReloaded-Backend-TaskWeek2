using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CATReloaded_W2
{
    #region Task 1

    /*  class student
      {
          public string name { get; set; }
          public int age { get; set; }
          public string grade { get; set; }

          public student(string name, int age, string grade)
          {
              this.name = name;
              this.age = age;
              this.grade = grade;
          }
          public void print()
          {
              Console.WriteLine($"Name:{name}\nAge:{age}\nGrade::{grade}");
          }

      }

      class postgraduate : student
      {
          public string thesistopic {get; set;}
      public postgraduate(string name, int age, string grade,string thesistopic):base(name,age,grade)
          {
              this.thesistopic = thesistopic;
          }
      public new void print()
          {
              base.print();
              Console.WriteLine($"ThesisTopic:{thesistopic}");
          }   
      }
      internal class Program
      {
          static void Main(string[] args)
          {
              student stud = new student ("mohammed",17,"12th grade");
              stud.print();

              postgraduate postgrad = new postgraduate("sleem", 21, "2nd year college", "Database Development");
              postgrad.print();
          }
      }*/
    #endregion


    #region Task2
 /*   public enum securitylevel
    {
        guest,
        developer,
        secretary,
        dba
    }
    class employee
    {
        public int id { get; set; }  
        public string name { get; set; }
        public char gender;
        public double salary { get; set; }
        public string hiredate { get; set; }
        public securitylevel security { get; set; }
        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {

                if (value == 'M' || value == 'F')
                {
                    gender = value;
                }
                else
                {
                    Console.WriteLine("Please Enter either Male (M) or Female (F)");
                }
            }
        }
        public employee(int id, string name, char gender, double salary, string hireDate, securitylevel security)
        {
            this.id = id;
            this.name = name;
            this.Gender = gender;
            this.salary = salary;
            this.hiredate = hireDate;
            this.security = security;
        }
        public override string ToString()
        {
            return $" ID: {id}\n Name: {name}\n Gender: {gender}\n Salary: {salary}\n Hire Date: {hiredate}\n Security Level: {security}\n";
        }
        class Program
        {
            static void Main()
            {
                employee emp1 = new employee(1, "Mohammed Abdelaziz", 'M', 5000.50, "2024/6/15", securitylevel.developer) ;
                Console.WriteLine(emp1.ToString());

                employee emp2 = new employee(2, "Sara Soroor", 'F', 5550.50, "2025/3/10", securitylevel.secretary);
                Console.WriteLine(emp2.ToString());
            }
        }
    }*/

    #endregion
}

