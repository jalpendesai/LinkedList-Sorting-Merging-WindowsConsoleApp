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
            List list = new List("Sorted Linked List");
            list.Display();


            list.InsertAtFront("10");
            list.InsertAtFront("50");
            list.InsertAtFront("30");
            list.InsertAtFront("80");
            list.InsertAtFront("20");



            //Displaying Unsorted List
            Console.WriteLine("Unsorted List: ");
            list.Display();

            //Sorting List
            List SortedList = list.Sort();
            list.Display();


            Console.ReadKey();
            
        }
        
        
        
    }
}
