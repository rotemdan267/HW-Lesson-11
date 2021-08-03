using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_11
{
    public class ClientsManagement
    {
        private string[] names = new string[10];
        private int[] ages = new int[10];
        private bool[] isVegan = new bool[10];
        private int numOfClients;

        public ClientsManagement()
        {

        }
        public ClientsManagement(string[] names, int[] ages, bool[] isVegan)
        {
            this.names = names;
            this.ages = ages;
            this.isVegan = isVegan;
            numOfClients = 0;
        }
        public void AddNewClient(string newName, int newAge, bool isVegan)
        {
            AddNewNameToList(newName);
            AddNewAgeToList(newAge);
            GoingVegan(isVegan);
            numOfClients++;
        }
        private void AddNewNameToList(string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                Console.WriteLine("You cannot enter an empty space for name");
            }
            else names[numOfClients] = newName;
        }
        private void AddNewAgeToList(int newAge)
        {
            if (newAge > 18)
            {
                ages[numOfClients] = newAge;
            }
            else Console.WriteLine("Too young");
        }
        private void GoingVegan(bool vegan)
        {
            isVegan[numOfClients] = vegan;
        }
        public string GetName(int i)
        {
            return names[i];
        }
        public int GetAge(int i)
        {
            return ages[i];
        }
        public bool GetIfVegan(int i)
        {
            return isVegan[i];
        }
    }
}
