using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class SuppliersTest
    {
        static void Main(string[] args)
        {
            try
            {
                Suppliers objSuppliers = new Suppliers();
                objSuppliers.AcceptDetails();
                objSuppliers.DisplayDetails();
                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of the following options:");
                    Console.WriteLine("1.Modify\n 2.Remove\n 3.Remove All\n 4.Search\n 5.Exit");
                    Console.Write("Enter your Choice:");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            if (objSuppliers.Modify())
                            {
                                Console.WriteLine("\n----After Modifying----");
                                objSuppliers.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Suppliers with this name does not exist");
                            break;
                        case 2:
                            if (objSuppliers.Remove())
                            {
                                Console.WriteLine("\n---After Removing---");
                                objSuppliers.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Suppliers with this name does not exist");
                            break;
                        case 3:
                            objSuppliers.objSupplierDetails.Clear();
                            Console.WriteLine("\n---After removing all the suppliers---");
                            Console.WriteLine("Total number of suppliers :" + objSuppliers.objSupplierDetails.Count);
                            return;
                        case 4:
                            objSuppliers.Search();
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Invalid Data Entry!");
                            break;
                    }
                } while (input == 'Y' || input == 'Y');
            }
            catch (Exception objEx)
            { Console.WriteLine("Error : {0}", objEx.Message); }
        }
    }
}
