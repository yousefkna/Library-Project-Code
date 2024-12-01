using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Books catalogue = new Books("Children of Gebelawi ", "Naguib Mahfouz");
            CatalogueLibrary.Add(catalogue);

            Console.WriteLine($"Enter : \n 1 to add a new book \n 2 search by author name \n 3 search by book name \n 4 to display all the books \n 5 to exit ");
            string choice = "";
            while (choice != "5")
            {
                Console.Write("\n" + "enter from 1 - 5 : ");
                choice = Console.ReadLine();
                Console.WriteLine("\n" + "--------------------");

                switch (choice)
                {
                    case "1":
                        catalogue.AddBook();
                        Console.WriteLine("--------------------");
                        break;

                    case "2":
                        catalogue.searchbyauthor();
                        Console.WriteLine("--------------------");
                        break;

                    case "3":
                        catalogue.searchbyTitle();
                        Console.WriteLine("--------------------");
                        break;

                    case "4":
                        if (CatalogueLibrary.Count() > 0)
                        {
                            catalogue.display();
                            Console.WriteLine("--------------------");
                        }
                        else
                        {
                            Console.WriteLine("--------------------");
                            Console.WriteLine("\n" + "The labrary has no books" + "\n");
                            Console.WriteLine("--------------------");
                        }
                        break;

                    case "5":
                        Console.WriteLine("\n" + "Exiting...");
                        break;

                    default:
                        Console.WriteLine("please enter a number from 1 - 5 ");
                        Console.WriteLine("--------------------");
                        break;
                }

            }

            Console.ReadLine();

        }
    }
}
