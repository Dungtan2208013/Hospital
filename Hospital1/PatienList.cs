using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital1
{
    class PatienList
    {
        public ArrayList objPatienNames = new ArrayList();
        public void AcceptDetails()
        {
            char choice = 'Y';
            try
            {
                do
                {
                    Console.WriteLine("Enter patient's name : ");
                    objPatienNames.Add(Console.ReadLine());
                    Console.Write("Do you want to add more names! [Y/N] :");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'Y' || choice == 'Y');
            }
            catch(Exception objEx) 
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n List of patient :");
            for (int i = 0;i< objPatienNames.Count;i++)
            {
                Console.WriteLine("objPatientNames[i]");
            }
            Console.WriteLine("Total number of patients :" + objPatienNames.Count);
        }
        public bool Remove()
        {
            string choice;
            Console.WriteLine("Enter the name of the patient : ");
            choice = Console.ReadLine();
            if(objPatienNames.Contains(choice))
            {
                objPatienNames.Remove(choice);
                return true;
            }
            else
                return false;
        }

        public void Search()
        {
            string choice;
            Console.WriteLine("Enter the name of the patient : ");
            choice = Console.ReadLine();
            if (choice!= "")
            {
                if (objPatienNames.Contains(choice))
                    {
                    Console.WriteLine("Record Found!");
                    Console.WriteLine(objPatienNames[objPatienNames.IndexOf(choice)]);
                    }
                else
                    Console.WriteLine("Record Not Found!");
                }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            
        }
    }
}
