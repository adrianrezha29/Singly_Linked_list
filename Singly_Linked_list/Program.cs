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
            if (Start != null || nim <= Start.rollNumber)
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
        }
    }
}
