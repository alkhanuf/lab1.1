namespace lab11
{
    public class LuckyNumber
    {
        public static bool IsLuckyNumber(string number)
        {
            if (number.Length != 6)
            {
                return false;
            }

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < 3; i++)
            {
                sum1 += int.Parse(number[i].ToString());
            }

            for (int i = 3; i < 6; i++)
            {
                sum2 += int.Parse(number[i].ToString());
            }

            if (sum1 == sum2)
            {
                return true; 
            }
            else
            {
                return false; 
            }
            
        }
    }
}