namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var number = random.Next(1, 11);

            Console.WriteLine("Guess a number between 1 and 10:");

            for (var i = 0; i < 5; i++)
            {
                var input = Console.ReadLine();
                var guess = Convert.ToInt32(input);

                if (guess == number)
                {
                    Console.WriteLine("You guessed it!");
                    return;
                }
                if (i < 4)
                {
                    Console.WriteLine("Wrong. Try again.");
                }
            }
            Console.WriteLine($"\nCorrect answer was {number}");
        }
    }
}