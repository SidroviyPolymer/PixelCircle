using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List 
{

    class List<T> 
    {
        private class Elem 
        {
            public T data;
            public Elem next;
            public Elem prev;

            public Elem(T data) 
            {
                this.data = data;
                next = null;
                prev = null;
            }
        }

        private Elem begin;
        private Elem end;
        private UInt32 size;
        
        public List()
        {
            size = 0;
            begin = null;
            end = null;
        }

        public List(UInt32 size, T[] data)
        {
            this.size = 0;
            begin = null;
            end = null;


        }

        ~List()
        {
            Clear();
        }

        public void Clear()
        {
            Elem current = end;
            while (current != begin)
            {
                current = current.prev;
                current.next = null;
            }
            begin = null;
            end = null;
            size = 0;
        }

        public void Push(T data)
        {
            Elem tmp = begin;
            begin = new Elem(data);
            begin.next = tmp;
            if (tmp != null)
                tmp.prev = begin;
            ++size;
        }

        public T Pop()
        {
            if (begin == null)
                throw new ArgumentOutOfRangeException("Error:\t Try to remove from empty list.");

            T data = begin.data;

            if (begin == end)
                end = null;  

            begin = begin.next;
            begin.prev = null;

            --size;
            return data;
        }

        public void PushBack(T data)
        {
            if (end == null)
            {
                end = new Elem(data);
                begin = end;
                ++size;
                return;
            }

            Elem tmp = end;
            end.next = new Elem(data);
            end = end.next;
            end.prev = tmp;
            ++size;
        }

        public T PopBack()
        {
            if (end == null)
                throw new ArgumentOutOfRangeException("Error:\t Try to remove from empty list.");

            T data = end.data;

            if (begin == end)
                begin = null;

            end = end.prev;
            end.next = null;

            --size;
            return data;
        }

        public void Insert(UInt32 idx, T data)
        {
            if (idx > size)
                throw new ArgumentOutOfRangeException("Error:\t Out of list range.");

            if (idx == 0)
            {
                Push(data);
                return;
            }

            if (idx == size) 
            {
                PushBack(data);
                return;
            }

            Elem prev = begin;
            for (UInt32 iter = 0; iter < idx - 1; ++iter)
                prev = prev.next;

            Elem elem = new Elem(data);
            Elem tmp = prev.next;

            prev.next = elem;
            elem.next = tmp;

            tmp.prev = elem;
            elem.prev = prev;

            ++size;
        }

        public T Remove(UInt32 idx)
        {
            if (idx >= size)
                throw new ArgumentOutOfRangeException("Error:\t Out of list range.");

            if (idx == 0)
                return Pop();

            if (idx == size - 1)
                return PopBack();

            Elem prev = begin;
            for (UInt32 iter = 0; iter < idx - 1; ++iter)
                prev = prev.next;

            Elem current = prev.next;

            prev.next = current.next;
            current.next.prev = prev;

            T data = current.data;
            current = null;

            --size;
            return data;
        }

        public T At(UInt32 idx)
        {
            Elem current = begin;
            for (UInt32 iter = 0; iter < idx; ++iter)
                current = current.next;
            return current.data;
        }

        public void Print()
        {
            if (begin == null)
                return;

            UInt32 idx = 0;
            Elem current = begin;
            while (current != end)
            {
                System.Console.Write(idx.ToString() + ":\t" + current.data.ToString());                
                System.Console.WriteLine();

                current = current.next;
                ++idx;
            }

            System.Console.Write(idx.ToString() + ":\t" + current.data.ToString());
            System.Console.WriteLine();
        }

        public void PrintBackwards()
        {
            if (end == null)
                return;

            UInt32 idx = size - 1;
            Elem current = end;
            while (current != begin)
            {
                System.Console.Write(idx.ToString() + ":\t" + current.data.ToString());
                System.Console.WriteLine();

                current = current.prev;
                --idx;                    
            }

            System.Console.Write(idx.ToString() + ":\t" + current.data.ToString());
            System.Console.WriteLine();
        }
    }
}
