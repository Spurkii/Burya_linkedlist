using System;

namespace Burya_linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Node Head = new Node(null);
            Node Current_Node = Head;

            Linked_List List = new Linked_List();

            bool IsRunning = true;
            string User_Input;

            Console.WriteLine("Welcome to the Linked list program");

            do
            {
                string List_Input;

                Console.Write("Please choose an option" +
                    "\n1: Add Item" +
                    "\n2. Remove Item" +
                    "\n3. Search For Item" +
                    "\n4. Print" +
                    "\n5. Exit\n");
                User_Input = Console.ReadLine();

                switch (User_Input)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Please enter what you want to add to the list: ");
                        List_Input = Console.ReadLine().ToLower();
                        List.Add_Node(List_Input);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("Please enter what you want to remove from the list: ");
                        List_Input = Console.ReadLine().ToLower();
                        Console.WriteLine(List.Delete_Node(List_Input));
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        Console.Write("Please enter what you want to search from the list: ");
                        List_Input = Console.ReadLine().ToLower();
                        Console.WriteLine(List.Search_Node(List_Input));
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        Console.Clear();
                        List.Print_Node();
                        Console.Write("List printed. press space to continue. ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "5":
                        Console.Clear();
                        Console.Write("Program closed");
                        IsRunning = false;
                        break;

                    default:
                        Console.Clear();
                        Console.Write("ERROR\n");
                        break;
                }

                } while (IsRunning == true);
        }
    }
}
