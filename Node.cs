using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burya_linkedlist
{
    class Node
    {
        private string _data;
        private Node _next;

        public Node(string Data)
        {
            _data = Data;
        }

        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }
        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }
    }
}
