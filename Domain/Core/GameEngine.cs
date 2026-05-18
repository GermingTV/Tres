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
        
        //spielzüge im loop
        //while (IsRunning) {
            Console.WriteLine("-------- Current Card:  " + CurrentCard.Color +" ------------");
            
            //CurrentCard = Player.PlayerTurn(deterministicKi, CurrentCard, _deck);
            //CurrentCard = deterministicKi.AiTurn(Player, CurrentCard, _deck);
            TurnCount++;
        //}
        
    }

    public void PlayerTurn(int action, Deck _deck) {
        Console.WriteLine("-----------------playerturn: " + action + "----------------------------");
        TurnCount++;
        CurrentCard = Player.PlayerTurn(DeterministicKi, CurrentCard, _deck, action);
        CurrentCard = DeterministicKi.AiTurn(Player, CurrentCard, _deck);
    }
    
    
    
    public List<BaseCard> CreateFirstHand(Deck _deck) {
        List<BaseCard> firstHand = new List<BaseCard>();
        firstHand.AddRange(_deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw());
        Console.WriteLine(firstHand.Count);
        return firstHand;
    }
    
    
    
}