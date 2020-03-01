using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalFirst
{
    class Node<T>
    {
        public T item { get; set; }
        public Node<T> next { get; set; }
        public Node<T> previous { get; set; }

        public Node()
        {
        }
        public Node(T in_item)
        {
            item = in_item;
            this.next = null;
            this.previous = null;
        }
    }
}
