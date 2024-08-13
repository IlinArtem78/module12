

using System.Runtime.Serialization.Formatters;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Сколько элементов будет в массиве?");
        int count = int.Parse(Console.ReadLine());
        string[] array = new string[count];
        for (int i = 0; i < count; i++) {
            array[i] = Console.ReadLine();
        }
        Console.WriteLine("Все элементы записаны"); 
    }
}