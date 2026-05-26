namespace Domain.Core;

public class NumberCard : BaseCard{
    
    public int Number { get; set; }
    
    public NumberCard(int number, ECardColor color, string img) {
        Number = number;
        Color = color;
        ImgUrl = img;
    }

    public override bool CanPlay(BaseCard card) {
        return card.CanPlayAgainst(this);
    }

    public override bool CanPlayAgainst(PTwoCard card) {
        if (Color == card.Color) {
            return true;
        }
        return false;
    }

    public override bool CanPlayAgainst(PFourCard card) {
        if (card.Color == Color) {
            return true;
        }
        return false;
    }

    public override bool CanPlayAgainst(NumberCard card) {
        if (Color == card.Color || Number == card.Number) {
            return true;
        }
        return false;
    }
    
    
    
    
}