using Domain.Core;

namespace TresPlayTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1() {
     
        GameEngine testEngine = new GameEngine();
        
        testEngine.BeginPlay("testPlayer");

        foreach (var card in testEngine.Player.Hand) {
            Console.WriteLine(card.Color);
        }

    }
}