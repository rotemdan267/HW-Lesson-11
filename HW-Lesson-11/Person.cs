using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_11
{
    class Person
    {
        private string name;
        private int phone;
        private readonly int id;
        private static int numOfPersons = 0;

        public Person(string name, int phone)
        {
            this.name = name;
            this.phone = phone;
            numOfPersons++;
            this.id = numOfPersons;
        }

        public static void ChangeName(Person p, string name)
        {
            p.name = name;
        }
        public static void ChangePhone(Person p, int phone)
        {
            p.phone = phone;
        }
    }
}
