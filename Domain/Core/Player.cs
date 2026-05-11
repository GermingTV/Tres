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

    public BaseCard PlayerTurn(DeterministicKi ai, BaseCard currentCard, Deck _deck) {
        if (!CanPlay){return currentCard;}
        
        if (HasPossibleCard(currentCard)) {
            Console.WriteLine("Select a possible Card ");
            Console.WriteLine("--------- 0 Draw ---------");
            
            
            //------------!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!------------
            //-----daweil alle gecastet auf number card weil noch keine spezial drinn
            //------------!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!------------
            for (var i = 0; i < Hand.Count; i++ ) {
                var numberCard =  (NumberCard)Hand[i];
                Console.WriteLine("--------- Card " + (i + 1) + " " + numberCard.Color + " " + numberCard.Number + " ---------");
            }
            
            int action = Convert.ToInt32(Console.ReadLine());

            if (action == 0) {
                DrawCard(_deck);
                return currentCard;
            }else {
               return PlaceCard(currentCard, action);
            }
        }else {
            Console.WriteLine("--------- 0 You can only Draw ---------");
            int action = Convert.ToInt32(Console.ReadLine());
            
            if (action == 0) {
                DrawCard(_deck);
            }
            return currentCard;
        }
    }


    public void DrawCard(Deck _deck) {
        Hand.Add(_deck.Draw());
    }
    
   public BaseCard PlaceCard(BaseCard currentCard, int input) {
            if (Hand[input -1].CanPlay(currentCard)) {
                BaseCard returnCard = Hand[input - 1];
                Hand.RemoveAt(input - 1);
                Console.WriteLine("----------You Placed----------" + returnCard.Color + "---------");
                return returnCard;
            }
            Console.WriteLine("----- Kein Richtige Karte----- Probier noch mal");
            int action = Convert.ToInt32(Console.ReadLine());
            return PlaceCard(currentCard, action);
   }
    
    public bool HasPossibleCard(BaseCard currentCard)
    {
        //schaut ob es mögliche Gleiche Farben gibt
        var possibleColorCards = Hand.Where(c => c.Color == currentCard.Color).ToList();
        if (possibleColorCards.Count > 0) {
            return true;
        }

        //schaut ob es mögliche gleiche Number gibt wenn jetzige Karte auch eine Type NumberCard is
        if (currentCard.GetType() == typeof(NumberCard)) {
            var currentNumberCard = (NumberCard)currentCard;
            foreach (var card in Hand) {
                try {
                    var numberCard = (NumberCard)card;
                    if (currentNumberCard.Number == numberCard.Number) {
                        return true;
                    }
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("------ this is no Number Card --------");
                }
            }   
        }

        //schaut ob es eine Plus4 gibt
        if (Hand.Any(c => c.GetType() == typeof(PFourCard))) {
            return true;
        }
        
        
        return false;
    }
    
    
}