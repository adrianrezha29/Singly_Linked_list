using System;

namespace Singly_Linked_list
{
    //each node consist of the information part and link to the next mode

    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }
    class List
    {
        Node Start;

        public List()
        {
            Start = null;
        }
        public void addNote() //add node in the list
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student : ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the name of the student : ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = nim;
            newnode.name = nm;
            //if the node to be inserted is the first node
            if (Start == null || nim <= Start.rollNumber)
            {
                if ((Start != null) && (nim == Start.rollNumber))
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                    return;
                }
                newnode.next = Start;
                Start = newnode;
                return;
            }
            //locate the position of the new node in the list
            Node previous, current;
            previous = Start;
            current = Start;

            while((current != null) && (nim >= current.rollNumber))
            {
                if(nim == current.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                    return;
                }
                previous = current;
                current = current.next;
            }
            //*once the above for loop is executed, prev and current are positioned in such a manner that the position for the new node */
            newnode = current;
            previous.next = newnode;
        }
        public void traverse()
        {
            if(listEmpty())
                Console.WriteLine("\nList is empt.\n");
            else
            {
                Console.WriteLine("\nThe records in the list are : ");
                Node currentNode;
                for (currentNode = Start; currentNode != null; currentNode = currentNode.next)
                    Console.WriteLine(currentNode.rollNumber + " " + currentNode.name + "\n");
                Console.WriteLine();
            }
        }
    }
}
