using System;

namespace Zahlenraten
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = new Random().Next(1, 100);
            int attempts = 0;
            int guess = 0;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("██████╗ ███████╗██╗███╗   ██╗    ███████╗ ██████╗██╗  ██╗ █████╗ ████████╗███████╗");
            Console.WriteLine("██╔══██╗██╔════╝██║████╗  ██║    ██╔════╝██╔════╝██║  ██║██╔══██╗╚══██╔══╝╚══███╔╝");
            Console.WriteLine("██║  ██║█████╗  ██║██╔██╗ ██║    ███████╗██║     ███████║███████║   ██║     ███╔╝ ");
            Console.WriteLine("██║  ██║██╔══╝  ██║██║╚██╗██║    ╚════██║██║     ██╔══██║██╔══██║   ██║    ███╔╝  ");
            Console.WriteLine("██████╔╝███████╗██║██║ ╚████║    ███████║╚██████╗██║  ██║██║  ██║   ██║   ███████╗");
            Console.WriteLine("╚═════╝ ╚══════╝╚═╝╚═╝  ╚═══╝    ╚══════╝ ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚══════╝\n");
            Console.WriteLine("Ich bin im Besitz dessen, was du am meisten liebst. Willst du es zurück, musst du meine Lieblingszahl erraten.");
            Console.WriteLine("Kleiner Tipp: Es ist eine ganze Zahl zwischen 1 und 100.");

            while (guess != secret)
            {
                Int32.TryParse(Console.ReadLine(), out guess);
                attempts = ++attempts;
                if (!(guess > 0 && guess < 101))
                {
                    Console.WriteLine("Wie es aussieht, ist deine Liebe nicht wirklich stark... Aber du darfst es trotzdem nochmal probieren.");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Das ist zu gross.");
                }
                else if (guess < secret)
                {
                    Console.WriteLine("Das ist zu klein.");
                }
            }
            if (attempts == 1)
            {
                Console.WriteLine("In einem Versuch ist das unmöglich, du hast bestimmt betrogen.");
            }
            else
            {
                Console.WriteLine("Du hast es ja doch noch geschafft. Mit ganzen " + attempts + " Versuchen. Das wäre doch besser gegangen.");
            }
            Console.WriteLine("Aber meintwegen nimm, was du am meisten liebst und sorge dafür, dass es dir nicht nochmals weggenommen wird.");
        }
    }
}
