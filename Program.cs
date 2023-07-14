using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Program
    {
        static ArrayList arrayList = new ArrayList();

        static void Main(string[] args)
        {
            App app = new App();
            arrayList = new ArrayList { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
            int t = arrayList.Count;
            Console.WriteLine("Total number of elemnts in the array list are:\t" + t);
            Print();

            Console.WriteLine("Enter \n 1.Insert\t 2.Remove\t 3.Search");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("Enter element to insert");
                        string e = Console.ReadLine();
                        Console.WriteLine("Enter index to enter");
                        arrayList.Add(e);


                        Print();

                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Enter element to remove");
                        string e = Console.ReadLine();
                        int x= arrayList.IndexOf(e);
                        if (x == -1)
                        {
                            Console.WriteLine("No such item in list");

                        }
                        else
                        {
                            arrayList.Remove(arrayList[x]);
                            Console.WriteLine("Updated list");
                            Print();
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter element to search");
                        string e = Console.ReadLine();
                        int index=arrayList.IndexOf(e);
                        if(index == -1)
                        {
                            Console.WriteLine("Invalid search");
                        }
                        else
                        {
                            Console.WriteLine("Item found\t" + arrayList[index]);

                        }
                        break;
                        
                    }
                default:
                    { 
                        Console.WriteLine("Invalid option");
                        break;
                        }
                    
            }
            Console.ReadKey();
        }

            public static void Print()
            {
                foreach (var item in arrayList)
                {
                    Console.WriteLine(item);
                }
            }
        
    }
}
