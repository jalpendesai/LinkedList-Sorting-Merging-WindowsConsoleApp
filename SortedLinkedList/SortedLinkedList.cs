using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListLibrary
{
    class SortedLinkedList
    {
        static void Main(string[] args)
        {
            //List1
            List list = new List();

            list.InsertAtFront("10");
            list.InsertAtFront("50");
            list.InsertAtFront("30");
            list.InsertAtBack("45");
            list.InsertAtFront("80");
            list.InsertAtFront("20");
            list.InsertAtBack("82");

            //List2
            List list2 = new List();

            list2.InsertAtFront("52");
            list2.InsertAtFront("58");
            list2.InsertAtFront("38");
            list2.InsertAtBack("88");
            list2.InsertAtFront("85");
            list2.InsertAtFront("21");

            //Displaying Unsorted List
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nUnsorted Lists: ");
            Console.Write("List1: ");
            list.Display();
            Console.Write("\nList2: ");
            list2.Display();

            //Sorting List
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nSorted Lists:");
            List SortedList1 = list.Sort();
            List SortedList2 = list2.Sort();
            Console.Write("List1: ");
            list.Display();
            Console.Write("\nList2: ");
            list2.Display();

            //Merging list
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nMerged List:");
            List mergedList = SortedList1.Merge(SortedList2);
            mergedList.Display();
            Console.ReadKey();
            
        }
        
        
        
    }
}
