using System;

namespace Program
{
    class Queue
    {
        private int[] items;
        private int front;
        private int rear;
        private int max;

        public Queue(int size)
        {
            items = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void insert(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                items[++rear] = item;
            }
        }

        public int delete()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("deleted element is: " + items[front]);
                return items[front++];
            }
        }

        public void printQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + items[i]);
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Queue queue = new Queue(5);

            queue.insert(10);
            queue.insert(20);
            queue.insert(30);
            queue.insert(40);
            queue.insert(50);

            Console.WriteLine("Items are : ");
            queue.printQueue();

            queue.delete();
            queue.delete();

            Console.WriteLine("Items are : ");
            queue.printQueue();
        }
    }
}