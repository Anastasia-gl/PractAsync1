namespace PractAsync1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.State += class1.Random;

            class1.OpenAsync();

          
            Console.ReadLine();
        }
    }
}