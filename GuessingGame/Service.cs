using GuessingGame.Generators;
using Microsoft.VisualBasic;

namespace GuessingGame
{
public class Service
{
     private readonly INumberGenerator _numberGenerator;

        public Service(INumberGenerator numberGenerator)
        {
            _numberGenerator = numberGenerator;
        }


    public int GetAmount()
    {
    Console.WriteLine("Enter the amount of money to bet:");
     if(!int.TryParse(Console.ReadLine(),out int amount)){
        Console.WriteLine("Invalid input. Please enter a valid whole number.");
        GetAmount();
     }
     return amount;
     }

    public int GetNumber()
    {
        Console.Write("Enter the number to guess: ");
    if(!int.TryParse(Console.ReadLine(),out int number)){
        Console.WriteLine("Invalid input. Please enter a valid whole number.");
    }

    return number;
    }

    public string GetLevel(){
        Console.Write(" Choose level (Easy/Medium/Hard) : ");
        string difficulty = Console.ReadLine();
        
            switch (difficulty.ToLower())
            {
            case "easy":
            return GetResult(1,5,5);
            case "medium":
            return GetResult(1,10,10);  
            case "hard":
            return GetResult(1,15,15);
            default:
            Console.WriteLine("enter a correct string");
                return GetLevel();
                
            }

    }
    public string GetResult(int minRange,int maxRange,int multiplier){
        Random random = new Random();
        int randomNumber = random.Next(minRange, maxRange);

        int game = GetAmount() * multiplier;

            if (GetNumber() == randomNumber)
            {
                Console.WriteLine($"Congratulations! You won {game} dollars.");
            }
            else
            {
                Console.WriteLine($"Sorry, you lost. The correct number is {randomNumber}.");
            }
        Console.WriteLine($"Let's Start Once More");
        return GetLevel();
    }
}
}