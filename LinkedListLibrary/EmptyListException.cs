using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListLibrary
{
    public class EmptyListException : Exception
    {
        // parameterless constructor
        public EmptyListException() : base("The list is empty") { }
            
        // one-parameter constructor
        public EmptyListException(string name): 
            base("The " + name + " is empty")
        {
        } // end EmptyListException constructor

        // two-parameter constructor
        public EmptyListException(string exception, Exception inner): 
            base(exception, inner)
        {
            // empty constructor
        } // end EmptyListException constructor
    } // end class EmptyListException
}
