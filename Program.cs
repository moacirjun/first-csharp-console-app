using System;

namespace SignCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string birthday;
            string birthdayMonth;

            do {
                Console.WriteLine("Tell me your birthday");

                birthday = Console.ReadLine();

                Console.WriteLine("Tell me your birthday month");
                birthdayMonth = Console.ReadLine();

                int birthdayInt = 0;
                int birthdayMonthInt = 0;

                try
                {
                    birthdayInt = Convert.ToInt32(birthday);
                    birthdayMonthInt = Convert.ToInt32(birthdayMonth);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    Environment.Exit(1);
                }

                Astrologer astrologer = new Astrologer();
                Sign sign = astrologer.findSign(birthdayInt, birthdayMonthInt);

                if (sign == null)
                {
                    Console.WriteLine("We can't find your sign. Try angain later!");
                }
                else
                {
                    Console.WriteLine("Your Sign is: " + sign);
                }

                Console.WriteLine();
                Console.WriteLine("Press 'N' to fish application.");
            } while (Console.ReadLine() != "N");
        }
    }
}
