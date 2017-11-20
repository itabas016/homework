using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructureLab
{
    class SequenceList<T> : IListStruct<T>
    {
        private int maxsize;
        private T[] data;
        private int last;

        public T this[int index]
        {
            get
            {
                return this.GetItemAt(index);
            }
            set
            {
                if (index < 0 || index > last + 1)
                {
                    Console.WriteLine("Position is error!!!");
                    return;
                }
                data[index] = value;
            }
        }

        public int Last
        {
            get
            {
                return last;
            }
        }

        public int Maxsize
        {
            get
            {
                return this.maxsize;
            }
            set
            {
                this.maxsize = value;
            }
        }

        public SequenceList(int size)
        {
            data = new T[size];
            maxsize = size;
            last = -1;
        }

        public bool IsFull()
        {
            return last == maxsize - 1;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= last; i++)
            {
                sb.Append(data[i].ToString() + ',');
            }
            return sb.ToString().TrimEnd(',');
        }

        #region Impements Methods

        public void Append(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("List is full!!!");
                return;
            }
            data[++last] = item;
        }

        public void Clear()
        {
            last = -1;
        }

        public int Count()
        {
            return last + 1;
        }

        public T GetItemAt(int i)
        {
            if (IsEmpty() || (i < 0) || (i > last))
            {
                Console.WriteLine("List is empty or Position is error!!!");
            }
            return data[i];
        }

        public int IndexOf(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!!!");
                return -1;
            }

            int i = 0;
            for (i = 0; i <= last; i++)
            {
                if (value.Equals(data[i]))
                {
                    break;
                }
            }

            if (i > last)
            {
                return -1;
            }
            return i;
        }

        public void InsertAfter(T item, int i)
        {
            if (IsFull())
            {
                Console.WriteLine("List is full!!!");
                return;
            }

            if (i < 0 || i > last)
            {
                Console.WriteLine("Position is error!!");
                return;
            }

            if (i == last)
            {
                data[last + 1] = item;
            }
            else
            {
                for (int j = last; j > i; j--)
                {
                    data[j + 1] = data[j];
                }
                data[i + 1] = item;
            }
            ++last;
        }

        public void InsertBefore(T item, int i)
        {
            if (IsFull())
            {
                Console.WriteLine("List is full!!!");
                return;
            }

            if (i < 0 || i > last + 1)
            {
                Console.WriteLine("Position is error!!");
                return;
            }

            if (i == last + 1)
            {
                data[i] = item;
            }
            else
            {
                for (int j = last; j >= i; j--)
                {
                    data[j + 1] = data[j];
                }
                data[i] = item;
            }
            ++last;
        }

        public bool IsEmpty()
        {
            return last == -1;
        }

        public T RemoveAt(int i)
        {
            T temp = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!!!");
                return temp;
            }

            if (i < 0 || i > last)
            {
                Console.WriteLine("Position is error!!!");
                return temp;
            }

            if (i == last)
            {
                temp = data[last];
            }
            else
            {
                temp = data[i];
                //位置i以及i以后的元素前移
                for (int j = i; j < last; j++)
                {
                    data[j] = data[j + 1];
                }
            }
            --last;
            return temp;
        }

        public void Resverse()
        {
            T temp = default(T);
            for (int i = 0; i <= last / 2; i++)
            {
                temp = data[i];
                data[i] = data[last - i];
                data[last - i] = temp;
            }
        }

        #endregion
    }
}
