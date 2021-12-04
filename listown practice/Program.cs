using System;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList obj = new SinglyLinkedList();

            obj.AddinEmptyList(20);
            obj.AddLast(30);
            obj.AddBegining(10);
            int x;
            Console.WriteLine("Enter the postion ");
            x = int.Parse(Console.ReadLine());
            obj.AtPosition(90, 20);
            obj.AddBefore(80, 90);
            obj.DeleteFirst();
            obj.removeLast();
            Console.WriteLine("before Deletion");
            obj.Display();
            Console.WriteLine("after deletion");
            obj.RemoveAnyNode(30);
            obj.Display();

            
            
        }
    }
}