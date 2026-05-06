using System.Runtime.InteropServices.JavaScript;

namespace Domain.Core;

public class GameEngine {

    public Player Player { get; set; }

    public int TurnCount { get; set; } = 0;
    
    public BaseCard CurrentCard { get; set; }
    
    public bool IsOver { get; set; } = false;
    
    public Deck _deck = HandFactory.CreateDeck();
    
    public void BeginPlay(string playerName){
        DeterministicKi deterministicKi = DeterministicKi.Instance;
        
        Player = new Player(playerName, CreateFirstHand());
        
        Console.WriteLine(Player.Hand.Count);
        
        //später schauen das keine spezial card dazukommt
        CurrentCard = _deck.Draw();
        
        //------------!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!------------
        //gekastet auf number card weil grad nur numbercards drinn sind
        //------------!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!------------
        Console.WriteLine("--------- Geradige Card" + CurrentCard.Color + "---------");
        
        while (!IsOver) {
            Player.PlayerTurn(deterministicKi, CurrentCard, _deck);
            deterministicKi.AiTurn(Player, CurrentCard, _deck);
            return;
        }
        
        
    }

    public List<BaseCard> CreateFirstHand() {
        List<BaseCard> firstHand = new List<BaseCard>();
        firstHand.AddRange(_deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw(), _deck.Draw());
        Console.WriteLine(firstHand.Count);
        return firstHand;
    }
    

}