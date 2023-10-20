using GuessingGame.Generators;
using Microsoft.VisualBasic;

namespace GuessingGame
{
    public class GuessingGameService
    {
        private readonly INumberGenerator _numberGenerator;

        public GuessingGameService(INumberGenerator numberGenerator)
        {
            _numberGenerator = numberGenerator;
        }


        public int MoneyToBet()
        {
            Console.WriteLine("Enter the amount of money to bet:");

            if (!int.TryParse(Console.ReadLine(), out int amount))
            {
                Console.WriteLine("Invalid input. Please enter a valid whole number.");
                MoneyToBet();
            }
            return amount;
        }

        public int GuessNumber()
        {
            Console.Write("Enter the number to guess: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input. Please enter a valid whole number.");
            }

            return number;
        }

        public string ChooseDifficultyLevelWhichReturnMinMaxMutipler(int amount,int guessNumber)
        {
            Console.Write(" Choose level (Easy/Medium/Hard) : ");
            string difficulty = Console.ReadLine();

            switch (difficulty.ToLower())
            {
                case "easy":
                    return GuessingGameResult(1, 5, 5,amount,guessNumber);
                case "medium":
                    return GuessingGameResult(1, 10, 10,amount,guessNumber);
                case "hard":
                    return GuessingGameResult(1, 15, 15,amount,guessNumber);
                default:
                    Console.WriteLine("enter a correct string");
                    return ChooseDifficultyLevelWhichReturnMinMaxMutipler(amount,guessNumber);
            }

        }
        public string GuessingGameResult(int minRange, int maxRange, int multiplier,int amount,int guessNumber)
        {

            int randomNumber = _numberGenerator.Generate(minRange, maxRange);

            int betAmount =  amount * multiplier;

            if (guessNumber == randomNumber)
            {
                Console.WriteLine($"You won {betAmount} dollars.");
                return "Congratulations!!";
            }
            else
            
                Console.WriteLine($"Guess number is {randomNumber}");
                return"Sorry, you lost.";
            
        }
    }
}