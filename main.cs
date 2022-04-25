using System;

class Program {
  
  public static void Main (string[] args) {
    BlueRayDisk brd;
    BlueRayCollection BRC = new BlueRayCollection();
    while (true){
    Console.WriteLine("Menu:");
    Console.WriteLine("0. Quit");
    Console.WriteLine("1. Add BlueRay to collection");
    Console.WriteLine("2. See collection");
    string choice = Console.ReadLine();
    if (choice == "0"){
       System.Environment.Exit(0);
    }
    if (choice == "1"){
      Console.WriteLine("What is the title?");
      string title = Console.ReadLine();
      Console.WriteLine("Who is the director?");
      string director = Console.ReadLine();
      Console.WriteLine("What is the year of release?");
      int yor = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("What is the cost?");
      double cost = Convert.ToDouble(Console.ReadLine());
      brd = new BlueRayDisk(title, director, yor, cost);
      BRC.addNode(brd);
      
      
    } 
    if (choice == "2"){
      BRC.printList();
      }
    }
  }
  public class BlueRayDisk {
    public string title;
    public string director;
    public int yearOfRelease;
    public double cost;
    public BlueRayDisk (string t, string d, int yor, double c){
      this.title = t;
      this.director = d;
      this.yearOfRelease = yor;
      this.cost = c; 
    }
  } 
  
  public class BlueRayCollection
        {
            private Node Head = null;

            public void addNode(BlueRayDisk newBRD)
            {
                Node new_disk = new Node(newBRD);
                if(Head == null)
                {
                    Head = new_disk;
                    return;
                }
    
                new_disk.next = null;
                Node current = Head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new_disk;
                return;
            }
            public void printList()
            {
                Node updatedNode = Head;
                while (updatedNode != null)
                {
                    Console.WriteLine(ToString(updatedNode));
                    updatedNode = updatedNode.next;
                }
            }
      public string ToString(Node updatedNode)
            {
            return "$" + updatedNode.data.cost + " " + updatedNode.data.yearOfRelease + " " + updatedNode.data.title + "," + updatedNode.data.director;
            }
        }
  
  public class Node
        {
            public BlueRayDisk data;
            public Node next;
            public Node (BlueRayDisk bd)
            {
                data = bd;
                next = null;
            }
        }
}