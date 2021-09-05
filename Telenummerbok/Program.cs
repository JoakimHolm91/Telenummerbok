using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telenummerbok
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }


    }
    //Class for storing and configuring persons in a phonebook
    public class Phonebook
    {
        //ArrayList for storing persons
        ArrayList people = new ArrayList();

        public void AddNewPerson(String firstName, String lastName, String number)
        {
            //Add new person to phonebook
            people.Add(new Person(firstName, lastName, number));
            
        }
        public void RemovePerson(String firstName, String lastName)
        {
            //Loop through array to find and remove selected person
            foreach (Person p in people)
            {
                if (p.GetFirstName().Equals(firstName) && p.GetLastName().Equals(lastName))
                {
                    people.Remove(p);
                    return;
                }
            }
        }
        public ArrayList GetArrayList()
        {
            //Return people array
            return people;

        }
    }
    //Class for storing information about a person in phonebook
    public class Person
    {
        String firstName;
        String lastName;
        String number;
        public Person(String firstName, String lastName, String newNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.number = newNumber;
        }
        //Getters for information about a person
        public String GetFirstName()
        {
            return firstName;
        }
        public String GetLastName()
        {
            return lastName;
        }
        public String GetPhoneNumber()
        {
            return number;
        }
    }
}
