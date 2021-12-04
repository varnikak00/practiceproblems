using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLinkedList
{
    public class SinglyLinkedList
    {
        private Node Head;

        public SinglyLinkedList()
        {
            this.Head = null;
        }

        public void AddinEmptyList(int data)
        {
            Node temp = new Node(data);
            Head = temp;
            Console.WriteLine("Data is successfully Added :" + Head.Info);
        }
        public void AddLast(int data)
        {
            Node p = Head;
            Node temp = new Node(data);
            if (Head == null)
            {
                Head = temp;
                return;
            }
            while (p.link != null)
            {
                p = p.link;
            }
            p.link = temp;

        }
        public void AddBegining(int data)
        {
            Node temp = new Node(data);
            temp.link = Head;
            Head = temp;
        }
        public void Display()
        {
            Node p;
            p = Head;
            while (p != null)
            {
                Console.WriteLine(p.Info);
                p = p.link;
            }

        }
        public void AtPosition(int data, int x)
        {
            Node p = Head;
            while (p != null)
            {
                if (p.Info == x)
                    break;
                p = p.link;
            }

            if (p == null)
                Console.WriteLine("Node is Not Present");
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }

        }

        public void AddBefore(int data, int x)
        {
            Node p = Head;
            while (p != null)
            {
                if (p.link.Info == x)
                    break;
                p = p.link;
            }
            Node temp = new Node(data);
            temp.link = p.link;
            p.link = temp;
        }
        public void removeLast()
        {
            if (Head == null)
                return;
            if (Head.link == null)
            {
                Head = null;
                return;
            }
            Node p = Head;
            while (p.link.link != null)
            {
                p = p.link;
            }
            p.link = null;
        }

        public void RemoveAnyNode(int x)
        {
            if (Head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            if (Head.Info == x)
            {
                Head = Head.link;
                return;
            }

            Node p = Head;
            while (p.link != null)
            {
                if (p.link.Info == x)
                    break;
                p = p.link;
            }
            if (p.link == null)
            {
                Console.WriteLine("Node not in list");
            }
            else
            {
                p.link = p.link.link;
            }
        }

        public void DeleteFirst()
        {
            if (Head == null)
                return; ;
            Head = Head.link;
        }

    }

    public class Node
    {
        public int Info;
        public Node link;

        public Node(int data)
        {
            this.Info = data;
            link = null;

        }
    }
}