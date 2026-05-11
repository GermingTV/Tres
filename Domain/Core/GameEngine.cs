namespace Domain.Core;

public class GameEngine {

    public Player Player { get; set; }

    public int TurnCount { get; set; } = 0;
    
    public BaseCard CurrentCard { get; set; }
    
    public bool IsRunning { get; set; }
    
    public Deck _deck = HandFactory.CreateDeck();
    
    public void BeginPlay(string playerName){
        
        //anlegen der spieler
        DeterministicKi deterministicKi = DeterministicKi.Instance;
        Player = new Player(playerName,CreateFirstHand());

        //anlegen der ersten karte
        CurrentCard = _deck.Draw();
        
        //Running auf true setzen
        IsRunning = true;
        
        //spielzüge im loop
        while (IsRunning) {
            Console.WriteLine("-------- Current Card:  " + CurrentCard.Color +" ------------");
            
            CurrentCard = Player.PlayerTurn(deterministicKi, CurrentCard, _deck);
            //determisicki.turn() lenny kot
            TurnCount++;
        }
        
    }

    public List<BaseCard> CreateFirstHand() {
        List<BaseCard> firstHand = new List<BaseCard>();
        firstHand.AddRange(_deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw());
        Console.WriteLine(firstHand.Count);
        return firstHand;
    }
    
    

}