namespace lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = "";

            while (number.Length != 6)
            {
                Console.WriteLine("введите шестизначное число: ");
                number = Console.ReadLine();

                
            }

            Console.WriteLine(number);
        }
    }
}
