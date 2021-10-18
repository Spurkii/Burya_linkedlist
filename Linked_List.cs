using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burya_linkedlist
{
    class Linked_List
    {
        private Node _head;
        private Node _current;

        public void Add_Node(string _add)
        { 
            Node New_Node = new Node(_add);
            New_Node.Data = _add;
            New_Node.Next = _head;
            _head = New_Node;
            Console.WriteLine( _add + " Was Added to the List, press space to continue");
        }

        public string Delete_Node(string _delete)
        {
            // quick return if you try to delete something without anything in the list
            if (_head == null)
            {
                return _delete + " was not found, because there is no items in the list. press space to continue";
            }
            // quick delete if it was at the top
            if (_head.Data == _delete)
            {
                _head = _head.Next;
                return _delete + " was deleted. press space to continue";
            }
            _current = _head;

            // Delete_node was the most difficult part of the assignment
            // while loop to properly go through the list and delete only the first occurance of it
            while (_current.Next != null)
            {
                if (_current.Next.Data == _delete)
                {
                    _current.Next = _current.Next.Next;
                    return _delete + " was deleted. press space to continue";
                }

                _current = _current.Next;
            }
            // end result if the choice wasn't in the list
            return _delete + " was not found. press space to continue"; ;
        }

        public string Search_Node(string _search)
        {
            _current = _head;

            // very basic version of delete without the heartache
            while (_current != null)
            {
                if (_current.Data == _search)
                {
                    return _current.Data + " was found, press space to continue";
                }
                else
                {
                    _current = _current.Next;
                }
                
            }
            return _search + " was not found, press space to continue";
        }

        public void Print_Node()
        {
            // print is pretty easy while loop
            Node current = _head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
