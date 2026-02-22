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

            Console.WriteLine(number);

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < 3; i++) {
                sum1 += int.Parse(number[i].ToString());
            }

            for (int i = 3; i < 6; i++)
            {
                sum2 += int.Parse(number[i].ToString());
            }

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);

            if (sum1 == sum2)
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
