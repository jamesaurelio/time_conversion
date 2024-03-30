namespace time_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double seconds, minutes, hours, days, months;
            string unit;

            Console.WriteLine("1. seconds to minutes\t3. hours to days");
            Console.WriteLine("2. minutes to hours\t4. days to months\n");

            Console.Write("Type the number of the conversion you want: ");
            unit = Console.ReadLine();

            if (unit == "1")
            {
                Console.Write("How many seconds? ");
                seconds = Convert.ToDouble(Console.ReadLine());
                minutes = seconds / 60;
                
                if (minutes <= 1)
                {
                    Console.WriteLine("It is equal to " + minutes + " minute.");
                }
                
                else
                {
                    Console.WriteLine("It is equal to " + minutes + " minutes.");
                }

            }

            if (unit == "2")
            {
                Console.Write("How many minutes? ");
                minutes = Convert.ToDouble(Console.ReadLine());
                hours = minutes / 60;

                if (hours <= 1)
                {
                    Console.WriteLine("It is equal to " + hours + " hour.");
                }

                else
                {
                    Console.WriteLine("It is equal to " + hours + " hours.");
                }

            }

            if (unit == "3")
            {
                Console.Write("How many hours? ");
                hours = Convert.ToDouble(Console.ReadLine());
                days = hours / 24;

                if (days <= 1)
                {
                    Console.WriteLine("It is equal to " + days + " day.");
                }

                else
                {
                    Console.WriteLine("It is equal to " + days + " days.");
                }

            }

            if (unit == "4")
            {
                Console.Write("How many days? ");
                days = Convert.ToDouble(Console.ReadLine());
                months = days / 30.4166666666666666;

                if (months <= 1)
                {
                    Console.WriteLine("It is equal to " + months + " month.");
                }

                else
                {
                    Console.WriteLine("It is equal to " + months + " months.");
                }

            }
        }
    }
}
