using System.Drawing;
using System.Runtime.InteropServices.JavaScript;

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

    public void PlayerTurn(DeterministicKi ai, BaseCard currentCard) {
        if (!CanPlay){return;}

        if (HasPossibleCard(currentCard)) {
            
        }
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
                        Console.WriteLine("------ Card found --------");
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
        
        
        Console.WriteLine("------ no Card found --------");
        return false;
    }
    
    
}