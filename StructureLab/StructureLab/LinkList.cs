using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructureLab
{
    class LinkList<T> : IListStruct<T>
    {
        private Node<T> head;

        public Node<T> Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }

        public LinkList()
        {
            head = null;
        }

        ~LinkList()
        {
            head = null;
        }

        public T this[int index]
        {
            get
            {
                return this.GetItemAt(index);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node<T> n = this.head;
            sb.Append(n.Data.ToString() + ",");
            while (n.Next != null)
            {
                sb.Append(n.Next.Data.ToString() + ",");
                n = n.Next;
            }
            return sb.ToString().TrimEnd(',');
        }

        #region Implement Methods

        public void Append(T item)
        {
            Node<T> d = new Node<T>(item);
            Node<T> n = new Node<T>();

            if (IsEmpty())
            {
                head = d;
                return;
            }

            n = head;
            while (n.Next != null)
            {
                n = n.Next;
            }
            n.Next = d;
        }

        public void Clear()
        {
            head = null;
        }

        public int Count()
        {
            Node<T> p = head;
            int len = 0;
            while (p != null)
            {
                len++;
                p = p.Next;
            }
            return len;
        }

        public T GetItemAt(int i)
        {
            T temp = default(T);
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("List is empty or Position is error!!!");
                return temp;
            }

            Node<T> p = head;
            if (i == 0)
            {
                return p.Data;
            }

            int j = 0;

            while (p.Next != null && j < i)
            {
                p = p.Next;
                j++;
            }

            if (j == i)
            {
                return p.Data;
            }
            else
            {
                Console.WriteLine("The node is not exist!!!");
                return temp;
            }
        }

        public int IndexOf(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Link is empty!!!");
                return -1;
            }

            Node<T> p = head;
            int i = 0;

            while (!value.Equals(p.Data) && p.Next != null)
            {
                p = p.Next;
                i++;
            }

            if (value.Equals(p.Data))
            {
                return i;
            }
            else
            {
                Console.WriteLine("The value is not exist!!!");
                return -1;
            }
        }

        public void InsertAfter(T item, int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("List is empty or Position is error!!!");
                return;
            }

            if (i == 0)
            {
                Node<T> q = new Node<T>(item);
                q.Next = head.Next;
                head.Next = q;
                return;
            }

            Node<T> p = head;
            int j = 0;

            while (p.Next != null && j < i)
            {
                p = p.Next;
                j++;
            }

            if (j == i)
            {
                Node<T> q = new Node<T>(item);
                q.Next = p.Next;
                p.Next = q;
            }
            else
            {
                Console.WriteLine("Position is error!!!");
            }
        }

        public void InsertBefore(T item, int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("List is empty or Position is error!!!");
                return;
            }

            if (i == 0)
            {
                Node<T> p = new Node<T>(item);
                p.Next = head;
                head = p;
                return;
            }

            Node<T> n = head;
            Node<T> d = new Node<T>();
            int j = 0;
            while (n.Next != null && j < i)
            {
                d = n;
                n = n.Next;
                j++;
            }

            //判断是否找到i的位置
            if (j == i)
            {
                Node<T> q = new Node<T>(item);
                d.Next = q;
                q.Next = n;
            }
            else
            {
                Node<T> q = new Node<T>(item);
                n.Next = q;
                q.Next = null;
            }
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public T RemoveAt(int i)
        {
            T temp = default(T);
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("List is empty or Position is error!!!");
                return temp;
            }

            Node<T> q = new Node<T>();

            if (i == 0)
            {
                q = head;
                head = head.Next;
                return q.Data;
            }

            Node<T> p = head;
            int j = 0;

            while (p.Next != null && j < i)
            {
                q = p;
                p = p.Next;
                j++;
            }
            if (j == i)
            {
                q.Next = p.Next;
                return p.Data;
            }
            else
            {
                Console.WriteLine("The node is not exist!!!");
                return temp;
            }
        }

        public void Resverse()
        {
            LinkList<T> result = new LinkList<T>();
            Node<T> t = this.head;
            result.Head = new Node<T>(t.Data);
            t = t.Next;

            while (t != null)
            {
                result.InsertBefore(t.Data, 0);
                t = t.Next;
            }

            this.head = result.head;
            result = null;
        }

        #endregion
    }
}
