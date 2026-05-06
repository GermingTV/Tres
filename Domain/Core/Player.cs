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

    public void PlayerTurn(DeterministicKi ai, BaseCard currentCard, Deck _deck) {
        if (!CanPlay){return;}
        
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
            }else {
                PlaceCard(currentCard, action);
            }
            
            
        }else {
            Console.WriteLine("--------- 0 You can only Draw ---------");
            int action = Convert.ToInt32(Console.ReadLine());
            
            if (action == 0) {
                DrawCard(_deck);
            }
            
        }
        
        
        
    }


    public void DrawCard(Deck _deck) {
        Hand.Add(_deck.Draw());
    }
    
    public void PlaceCard(BaseCard currentCard, int input) {
        try {
            currentCard = Hand[input - 1];
            Hand.RemoveAt(input - 1);
            Console.WriteLine("--------- Geradige Card" + currentCard.Color + "---------");
        }catch (Exception e) {
            Console.WriteLine("----- Kein Richtige Karte----- Probier noch mal");
            int action = Convert.ToInt32(Console.ReadLine());
            PlaceCard(currentCard, action);
        }
    }

    
    //hier weiter -> schauen ob spieler wirklich karte spielen darf
    public void AllowedToPlace(NumberCard currentCard, int input) {
        if (currentCard.Color == Hand[input - 1].Color || currentCard.Number == Hand[input - 1].Number) {
            
        }
    }
    
    public void AllowedToPlace(BaseSpezialCard currentCard, int input) {
        
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