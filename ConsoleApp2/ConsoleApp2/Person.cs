using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Person
    {
        public string Name;
        public string Surname;
        public string Phonenumber;
        public string Category;
        public string Note;

        public Person()
        {

        }
        public Person(string name, string surname, string phonenumber, string category, string note)
        {
            Name = name;
            Surname = surname;
            Phonenumber = phonenumber;
            Category = category;
            Note = note;
        }
        public string FullInfo()
        {
            return $"{Name} {Surname} {Phonenumber} {Category} {Note}";
        }
            
            
            

    }
}
