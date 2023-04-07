using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_04_2023_С_Sharp_2_lesson
{
    internal class myPerson
    {
         string name;
        //int age;
        public string Name { /* set;*/ get { return name; } }
        public int Age { get; set; }
       
        public void Print()
        {
            Console.WriteLine($"Name:\t{Name}\t||\tAge:\t{Age}");
            //Console.WriteLine("Name: {0} Age: {1}",Name,Age); 2й вариант
        }
        public myPerson(string _name)
        {
            name = _name;
        }
        
        /*private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set
            {
                if (value % 2 == 0)
                {
                    myVar = value;//то значение которое мы априсвоем будет передано
                }
                else
                {
                    myVar = 0;
                }
            }
        }*/
       

    }
}
