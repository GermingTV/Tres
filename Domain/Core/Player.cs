namespace Domain.Core;

public class Player {
    
    public string PlayerName { get; set; }
    
    public List<BaseCard> Hand { get; set; }

    public bool CanPlay { get; set; }

    public Player(string playerName,  List<BaseCard> hand) {
        PlayerName = playerName;
        Hand = hand;
        CanPlay = true;
    }

    public BaseCard PlayerTurn(DeterministicKi ai, BaseCard currentCard, Deck _deck, int action) {
        if (!CanPlay) {
            CanPlay = true;
            return currentCard;
        }
        
        if (action == 0) {
            DrawCard(_deck);
            return currentCard;
        }

        return PlaceCard(currentCard, action, ai);
    }


    public void DrawCard(Deck _deck) {
        Hand.Add(_deck.Draw());
    }
    
   public BaseCard PlaceCard(BaseCard currentCard, int input, DeterministicKi ai) {
            if (Hand[input -1].CanPlay(currentCard, ai)) {
                BaseCard returnCard = Hand[input - 1];
                Hand.RemoveAt(input - 1);
                Console.WriteLine("----------You Placed" + returnCard.Color);
                return returnCard;
            }
            Console.WriteLine("----- Kein Richtige Karte Probier noch mal");
            ai.CanPlay = false;
            return currentCard;
   }
   
    
}