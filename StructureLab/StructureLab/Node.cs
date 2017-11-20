using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructureLab
{
    class Node<T>
    {
        private T data;
        private Node<T> next;

        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public Node<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

        public Node(T val, Node<T> p)
        {
            data = val;
            next = p;
        }

        public Node(T val)
        {
            data = val;
        }

        public Node(Node<T> p)
        {
            next = p;
        }

        public Node()
        {
            data = default(T);
            next = null;
        }
    }
}
