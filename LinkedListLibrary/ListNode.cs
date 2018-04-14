using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListLibrary
{
    public class ListNode
    {
        // public object Data { get; private set; }    // Inaccessible Error Due to Private Set
        public object Data { get; set; }

        public ListNode Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        public ListNode(object dataValue): this(dataValue, null){}
      
         // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        public ListNode(object dataValue, ListNode nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        } // end constructor
    } // end class ListNode
}
