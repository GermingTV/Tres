namespace Domain.Core;

public class Deck {
    public List<BaseCard> Cards { get; set; } = new List<BaseCard>();
    
    public int SelectCard() {
        Random rnd = new Random();
        return rnd.Next(0, Cards.Count);
    }
    
    public BaseCard Draw() {
        var drawnCard = this.Cards[SelectCard()];
        this.Cards.Remove(drawnCard);
        return drawnCard;
    }
}