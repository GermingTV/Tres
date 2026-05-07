namespace Domain.Core;

public class GameEngine {

    public Player Player { get; set; }

    public int TurnCount { get; set; } = 0;
    
    public Deck _deck = HandFactory.CreateDeck();
    
    public void BeginPlay(string playerName){
        DeterministicKi deterministicKi = DeterministicKi.Instance;
        
        Player = new Player(playerName,CreateFirstHand());
        
    }

    public List<BaseCard> CreateFirstHand() {
        List<BaseCard> firstHand = new List<BaseCard>();
        firstHand.AddRange(_deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw());
        Console.WriteLine(firstHand.Count);
        return firstHand;
    }
    
    

}