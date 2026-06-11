using System.Diagnostics.Contracts;

namespace Domain.Core;

public class GameEngine {

    public Player Player { get; set; }

    public DeterministicKi DeterministicKi { get; set; }
    
    public int TurnCount { get; set; } = 0;
    
    public BaseCard CurrentCard { get; set; }
    
    public bool IsRunning { get; set; }
    
    //public Deck _deck = HandFactory.CreateDeck();
    
    public void BeginPlay(string playerName, Deck _deck) {
        //anlegen der spieler
        Player = new Player(playerName,CreateFirstHand(_deck));
        DeterministicKi = DeterministicKi.Instance;
        DeterministicKi.AIHand = CreateFirstHand(_deck);
        
        //anlegen der ersten karte
        CurrentCard = _deck.Draw();
        
        //Running auf true setzen
        IsRunning = true;
        
        Console.WriteLine("-------- Current Card:  " + CurrentCard.Color +" ------------");
        TurnCount = 0;
    }

    public void PlayerTurn(int action, Deck _deck) {
        if (IsRunning) {
            Console.WriteLine("---------------------------------------------");
            TurnCount++;
            CurrentCard = Player.PlayerTurn(DeterministicKi, CurrentCard, _deck, action);
            CurrentCard = DeterministicKi.AiTurn(Player, CurrentCard, _deck);
        }
        
    }

    public EGameState hasWon() {
        if (Player.Hand.Count == 0) {
            return EGameState.PLAYER_WON;
        }
        if (DeterministicKi.AIHand.Count == 0) {
            return EGameState.AI_WON;
        }
        return EGameState.RUNNING;
    }
    
    
    public List<BaseCard> CreateFirstHand(Deck _deck) {
        List<BaseCard> firstHand = new List<BaseCard>();
        firstHand.AddRange(_deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw());
        Console.WriteLine(firstHand.Count);
        return firstHand;
    }
    
    
    
}