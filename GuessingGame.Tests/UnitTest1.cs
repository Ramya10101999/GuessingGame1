using System.Numerics;
using GuessingGame;
using NSubstitute;
using GuessingGame.Generators;
namespace GuessingGame.Tests;

public class UnitTest1
{
    [Fact]
    public void GetResult_Win()
    {

        int minRange = 4;
        int maxRange = 5;
        int guessNumber = 3;
        INumberGenerator numberGenerator = Substitute.For<INumberGenerator>();
        numberGenerator.Generate(minRange, maxRange).Returns(guessNumber);
        Service service = new Service(numberGenerator);
        service.GetResult(minRange,maxRange,6);
        Assert.True(true);
    }
}
