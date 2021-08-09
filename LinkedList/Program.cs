using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList LList = new SinglyLinkedList();
            LList.insertFirst(100);
            LList.insertFirst(50);
            LList.insertFirst(99);
            LList.insertFirst(88);
            LList.insertLast(999000);
            LList.displayList();

            LList.deleteFirst();
            LList.displayList();
        }
    }
    public class SinglyLinkedList
    {
        private Node first;
        public bool isEmpty()
        {
            return (first == null);
        }
        //insert at begining of LList
        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }
        //Deleting First Node
        public Node deleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }
        //Displaying LinkedList
        public void displayList()
        {
            Console.WriteLine("Displaying Liked List ");
            Node current = first;
            while (current != null)
            {
                current.displayNode();
                current = current.next;
            }
            Console.WriteLine();
        }


        //Inserting At End of Linked List
        public void insertLast(int data)
        {
            Node current = first;
            while (current.next != null)
            {
                current = current.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public void displayNode()
        {
            Console.WriteLine("<" + data + ">");
        }
    }
}