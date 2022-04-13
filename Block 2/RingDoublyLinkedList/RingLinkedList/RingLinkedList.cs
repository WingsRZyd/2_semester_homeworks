using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace LinkedList
{
    public class RingLinkedList<T> : IEnumerable
    {
        public Item<T> Head { get; set; }
        public Item<T> Tail { get; set; }
        public int Count { get; set; }


        public RingLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public RingLinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        public void AddAfter(Item<T> node, T data)
        {
            var item = new Item<T>(data);
            var current = Head;
            if (Count == 0)
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i < Count; i++)
            {
                if (current == node)
                {
                    item.Next = current.Next;
                    current.Next.Previous = item;
                    current.Next = item;
                    item.Previous = current;
                    Count++;
                }
                current = current.Next;
            }
        }
        
        public void AddBefore(Item<T> node, T data)
        {
            var item = new Item<T>(data);
            var current = Tail;
            if (Count == 0)
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i < Count; i++)
            {
                if (current == node)
                {
                    item.Previous = current.Previous;
                    current.Previous.Next = item;
                    current.Previous = item;
                    item.Next = current;
                    Count++;
                }
                current = current.Previous;
            }
        }

        public void Add(Item<T> item)
        {
            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }

            Tail.Next = item;
            item.Previous = Tail;
            item.Next = Head;
            Head.Previous = item;
            Tail = item;
            Count++;
        }
        
        public void AddFirst(T data)
        {
            var item = new Item<T>(data);

            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }

            Tail.Next = item;
            item.Previous = Tail;
            item.Next = Head;
            Head = item;
            Head.Next.Previous = item;
            Count++;
        }

        public void AddLast(T data)
        {
            var item = new Item<T>(data);

            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }

            Tail.Next = item;
            item.Previous = Tail;
            item.Next = Head;
            Head.Previous = item;
            Tail = item;
            Count++;
        }

        public void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Remove(T data)
        {
            if (Head.Data.Equals(data))
            {
                RemoveItem(Head);
                Head = Head.Next;
                return;
            }

            var current = Head.Next;
            for (int i = Count; i > 0; i--)
            {
                if (current != null && current.Data.Equals(data))
                {
                    RemoveItem(current);
                    return;
                }

                current = current.Next;
            }
        }

        public void RemoveFirst()
        {
            RemoveItem(Head);
            Head = Head.Next;
            return;
        }

        public void RemoveLast()
        {
            RemoveItem(Tail);
            Tail = Tail.Previous;
            return;
        }


        private void RemoveItem(Item<T> current)
        {
            current.Next.Previous = current.Previous;
            current.Previous.Next = current.Next;
            Count--;
        }


        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T data)
        {
            var item = new Item<T>(data);
            var current = Head;
            if (Head != null)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (current.Data.Equals(data))
                    {
                        return true;
                    }

                    current = current.Next;
                }

                return false;
            }
            else
            {
                return false;
            }
        }
        
        public bool Equals(Object obj)
        {
            RingLinkedList<T> list;
            list = (RingLinkedList<T>) obj;
            
            var current = list.Head;
            foreach (var item in this)
            {
                if (current.Data.Equals(item))
                {
                    return false;
                }
            }
            return true;
        }

        public Item<T> FindLast(T data)
        {
            var item = new Item<T>(data);
            var current = Tail;
            for (int i = 0; i < Count; i++)
                {
                    if (current.Data.Equals(data))
                    {
                        return current;
                    }

                    current = current.Previous;
                }
            return null;
        }
        
        public Item<T> Find(T data)
        {
            var item = new Item<T>(data);
            var current = Head;
            for (int i = 0; i < Count; i++)
            {
                if (current.Data.Equals(data))
                {
                    return current;
                }

                current = current.Next;
            }
            return null;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            for (int i = 0; i < Count; i++)
            {
                yield return current;
                current = current.Next;
            }
        }
    }
}