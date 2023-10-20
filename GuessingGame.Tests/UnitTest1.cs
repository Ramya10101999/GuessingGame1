using System.Numerics;
using GuessingGame;
using NSubstitute;
using GuessingGame.Generators;
namespace GuessingGame.Tests;

public class UnitTest1
{
    [Fact]
    public void Test_For_Winning_GuessingGameResult()
    {

        int minRange = 1;
        int maxRange = 5;
        int guessNumber = 3;
        int amount =12;
        INumberGenerator numberGenerator = Substitute.For<INumberGenerator>();
        numberGenerator.Generate(minRange, maxRange).Returns(guessNumber);
        GuessingGameService service = new GuessingGameService(numberGenerator);
        string result = service.GuessingGameResult(minRange, maxRange, 5,amount,3);
        Assert.Equal("Congratulations!!", result);
    }


    [Fact]
    public void Test_For_Loss_GuessingGameResult()
    {
        int minRange = 1;
        int maxRange = 5;
        int guessNumber = 6;
        int amount =12;
        INumberGenerator numberGenerator = Substitute.For<INumberGenerator>();
        numberGenerator.Generate(minRange, maxRange).Returns(guessNumber);
        GuessingGameService service = new GuessingGameService(numberGenerator);
        string result = service.GuessingGameResult(minRange, maxRange, 5,amount,6);
        Assert.Equal("Sorry, you lost.", result);

    }

}
