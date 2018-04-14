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
            //Display items present in the list
            list.Display();
            Console.ReadKey();
            
        }
        
        
        
    }
}
