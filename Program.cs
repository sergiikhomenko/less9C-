namespace Lessons9Task6;

/*
 * Використовуючи Visual Studio, створіть проєкт за шаблоном ConsoleApplication.
 * Створіть масив розмірністю 10 елементів, виведіть на екран усі елементи масиву
 * у зворотному порядку.
 */
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Введіть розмір масиву");
            Int32.TryParse(Console.ReadLine(), out int size);
            int[] arrey = new int[size];

            AddValeuInArrey(arrey);
            Console.WriteLine("Початковий масив");
            for (int i = 0; i < arrey.Length; i++)
            {
                Console.Write($"{arrey[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine("Масив в зворотньому порядку");
            for (int i = arrey.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arrey[i]} ");
            }

            Console.WriteLine();
        }
    }
    static int[] AddValeuInArrey(int[] arrey)
    {
        Random rand = new Random();
        for (int i = 0; i < arrey.Length; i++)
        {
            arrey[i] = rand.Next(0, 100);
        }

        return arrey;
    }
}