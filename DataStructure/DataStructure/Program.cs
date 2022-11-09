namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Problem");

            LinkedList objList = new LinkedList(); 
            objList.Enqueue(56);
            objList.Enqueue(30);
            objList.Enqueue(70);
            objList.Display();
        }
    }
}