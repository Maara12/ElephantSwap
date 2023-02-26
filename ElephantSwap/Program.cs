using System;

namespace ElephantSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", earSize = 20 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", earSize = 30 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");

            while(true)
            {
                var option = Console.ReadKey(true).Key;
                if (option == ConsoleKey.D1)
                {
                    Console.Write("You Pressed 1."+'\n' + "Calling Lloyd.WhoAmI()" + '\n');
                    lloyd.WhoAmI();
                    
                }
                if (option == ConsoleKey.D2)
                {
                    Console.Write("You Pressed 2." + '\n' + "Calling Lucinda.WhoAmI()" + '\n');
                    lucinda.WhoAmI();

                }
                if (option == ConsoleKey.D3)
                {
                    Elephant temp = lloyd;
                    lloyd = lucinda;
                    lucinda = temp;
                    Console.WriteLine("You pressed 3, " +
                        "References have swapped");

                }
                if(option == ConsoleKey.D4)
                {
                    lloyd = lucinda;
                    lloyd.earSize = 33;
                    lloyd.WhoAmI();
                }
                if(option == ConsoleKey.Q)
                {
                    return;
                }
            }
        }

       
    }

    class Elephant
    {
        public string Name;
        public int earSize;

        public void WhoAmI()
        {
            Console.WriteLine("My Name is " + Name);
            Console.WriteLine( "My ears are " + earSize + " inches tall" +'\n');
        }

    }
}
