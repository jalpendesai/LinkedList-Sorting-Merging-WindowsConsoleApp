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
            List list = new List();


            list.InsertAtFront("10");
            list.InsertAtFront("50");
            list.InsertAtFront("30");
            list.InsertAtFront("80");
            list.InsertAtFront("20");

            List list2 = new List();

            list2.InsertAtFront("52");
            list2.InsertAtFront("58");
            list2.InsertAtFront("38");
            list2.InsertAtFront("85");
            list2.InsertAtFront("21");

            //Displaying Unsorted List
            Console.WriteLine("\nUnsorted Lists: ");
            Console.Write("List1: ");
            list.Display();
            Console.Write("\nList2: ");
            list2.Display();

            //Sorting List
            Console.WriteLine("\n\nSorted Lists:");
            List SortedList1 = list.Sort();
            List SortedList2 = list2.Sort();
            Console.Write("List1: ");
            list.Display();
            Console.Write("\nList2: ");
            list2.Display();

            //Merging list
            Console.WriteLine("\n\nMerged List:");
            List mergedList = SortedList1.Merge(SortedList2);
            mergedList.Display();
            Console.ReadKey();
            
        }
        
        
        
    }
}
