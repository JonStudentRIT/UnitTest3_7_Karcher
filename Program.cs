using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest3_7
{
    /* Class: Wizard
     * Author: Jonathan Karcher
     * Purpose: Create a wizard with an age and a name
     */
    public class Wizard : IComparable
    {
        public int age; 
        public string name;
        /* Constructor: Wizard
         * Purpose: Set the initial wizard data
         * Restrictions: None
         */
        public Wizard(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        /* Method: CompareTo
         * Purpose: Compare the ages of two wizards
         * Restrictions: None
         */
        int IComparable.CompareTo(object obj)
        {
            // cast the object to a wizard
            Wizard wizard = (Wizard)obj;
            return age.CompareTo(wizard.age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // create a new random
            Random rand = new Random();
            // create a wizard reference
            Wizard wizard;
            // an array of wizard sounding names
            string[] names = {"Jufaris","Ebus","Otrix","Dhikius","Kradius","Vaphyx","Erish","Amonora","Atarish","Omnekey","Thissaem"};
            // create a list of wizards
            List<Wizard> wizardList = new List<Wizard>();
            // initialize the wizard data
            for(int i = 0; i < names.Length; i++)
            {
                wizard = new Wizard(names[i], rand.Next(100, 1000));
                wizardList.Add(wizard);
            }
            // before the sort
            //for(int i = 0; i < wizardList.Count; i++)
            //{
            //    wizard = wizardList.ElementAt<Wizard>(i);
            //    Console.WriteLine(wizard.name + " : " + wizard.age);
            //}
            //Console.WriteLine();
            //wizardList.Sort();
            // sort the wizard list by their age
            wizardList = wizardList.OrderBy(delegate (Wizard w) { return w.age; }).ToList();
            // display the sorted list of wizards
            for (int i = 0; i < wizardList.Count; i++)
            {
                wizard = wizardList.ElementAt<Wizard>(i);
                Console.WriteLine(wizard.name + " : " + wizard.age);
            }
        }
    }
}
