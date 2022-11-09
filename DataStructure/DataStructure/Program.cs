namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Problem");

            LinkedList objList = new LinkedList(); 
            objList.Push(56);
            objList.Push(30);
            objList.Push(70);
            objList.Peek();
            objList.Pop();
            objList.Display();
            objList.Peek();
            objList.Pop();
            objList.Display();
        }
    }
}