//Определить, является ли заданное шестизначное число счастливым.
//(Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его последних трех цифр.)

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

            bool isLucky = LuckyNumber.IsLuckyNumber(number);

            if (isLucky == true)
            {
                Console.WriteLine("число " + number + " cчастливое");
            }
            else
            {
                Console.WriteLine("число " + number + " НЕ cчастливое");
            }

        }
    }
}
