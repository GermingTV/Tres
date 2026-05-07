namespace Domain.Core;

public class NumberCard : BaseCard{
    
    public int Number { get; set; }
    
    public NumberCard(int number, ECardColor color) {
        Number = number;
        Color = color;
    }

    public override bool AllowedToPlace(NumberCard currentCard) {
        if (currentCard.Color ==  Color || currentCard.Number == Number) {
            return true;
        }
        return false;
    }

    public override bool AllowedToPlace(BaseSpezialCard currentCard) {
        if (currentCard.Color ==  Color) {
            return true;
        }
        return false;
    }
}