using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_04_2023_С_Sharp_2_lesson
{
    internal class Program
    { 
        static List<myPerson> Ask_N_Time(int n)
        {
            //List<myPerson> ans = new List<myPerson>();
            var ans = new List<myPerson>();
            for (int i = 0; i < n; i++)
            {
                ans.Add(CreatePerson());
            }
            return ans;
        } 
        string name;
        static myPerson CreatePerson()
        {
            string name;
            int age  = 0;
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            do
                try
                {
                    Console.WriteLine("Enter Age");
                    age = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Entering Age incorrect");
                } while (age <= 0 && age > 120);   
            var person = new myPerson(name);
            person.Age = age;
            return person;  
        }
        static void Main(string[] args)
        {
            var PersonList = Ask_N_Time(3); 
            foreach (var person in PersonList)
            {
                Console.WriteLine($"{person.Name}, " + $"age {person.Age}");
            }
         
            /* myPerson person = new myPerson("Bilbo BAggins");
            person.Age = 21;
            person.Print();*/
            /* person.Name = "Rick free";
            person.Age = 121;
            person.Print();
            person.Name = "All P";
            person.Age = 221;
            person.Print();*/
            
            /*person.MyProperty = 1;
            Console.WriteLine(person.MyProperty);*/            
            
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);   
            }   
            int a = 0;  
            while(a < 10)
            {
                Console.WriteLine(a+=1);
                //a++; или так
            }*/
        }
    }
}
