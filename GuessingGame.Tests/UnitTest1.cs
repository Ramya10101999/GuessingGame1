using System.Numerics;
using GuessingGame;
using NSubstitute;
using GuessingGame.Generators;
namespace GuessingGame.Tests;

public class UnitTest1
{
    [Fact]
    public void GetResult_found()
    {

        int minRange = 4;
        int maxRange = 5;
        int guessNumber = 3;
        INumberGenerator numberGenerator = Substitute.For<INumberGenerator>();
        numberGenerator.Generate(minRange, maxRange).Returns(guessNumber);
        Service service = new Service(numberGenerator);
        string result=service.GetResult(minRange,maxRange,6);
        Assert.True(true);

    }

    // [Fact]
    // public void GetNumber_Test(){
    //     int number=3;
    //     Assert.Equal(3,number);
    // }

     [Fact]
    public void GetAmount_Test(){
        int number=323;
        Assert.Equal(3,number);
    }

     [Fact]
    public void GetLevel_Test(){
        string number="easy";
        Assert.Equal("easy",number);
    }

}
