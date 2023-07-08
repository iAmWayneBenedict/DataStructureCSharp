namespace SinglyLinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.InsertFirst(1);
            linkedList.InsertAt(2,1);
            linkedList.InsertFirst(3);
            linkedList.InsertFirst(4);
            linkedList.InsertAt(5, 2);
            linkedList.RemoveFirst();
            linkedList.RemoveLast();
            //linkedList.RemoveAt(2);
            linkedList.Print();        
        }
    }
}