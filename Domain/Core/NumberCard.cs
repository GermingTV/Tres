namespace Domain.Core;

public class NumberCard : BaseCard{
    
    public int Number { get; set; }
    
    public NumberCard(int number, ECardColor color, string img) {
        Number = number;
        Color = color;
        ImgUrl = img;
    }

    public override bool CanPlay(BaseCard card, Player player) {
        return card.CanPlayAgainst(this, player);
    }

    public override bool CanPlay(BaseCard card, DeterministicKi ki) {
        return card.CanPlayAgainst(this, ki);
    }
    
    public override bool CanPlayAgainst(PTwoCard card,  DeterministicKi ki ) {
        if (Color == card.Color) {
            card.UseSpezial(ki);
            return true;
        }
        return false;
    }

    public override bool CanPlayAgainst(PFourCard card, DeterministicKi ki) {
        if (card.Color == Color) {
            card.UseSpezial(ki);
            return true;
        }
        return false;
    }

    public override bool CanPlayAgainst(NumberCard card, DeterministicKi ki) {
        if (Color == card.Color || Number == card.Number) {
            return true;
        }
        return false;
    }

    public override bool CanPlayAgainst(LockCard card, DeterministicKi ki) {
        if (Color == card.Color) {
            card.UseSpezial(ki);
            return true;
        }
        return false;
    }
    
    
    
    public override bool CanPlayAgainst(PTwoCard card, Player player) {
        if (Color == card.Color) {
            card.UseSpezial(player);
            return true;
        }
        return false;
    }

    public override bool CanPlayAgainst(PFourCard card, Player player) {
        if (card.Color == Color) {
            card.UseSpezial(player);
            return true;
        }
        return false;
    }

    public override bool CanPlayAgainst(NumberCard card, Player player) {
        if (Color == card.Color || Number == card.Number) {
            return true;
        }
        return false;
    }

    public override bool CanPlayAgainst(LockCard card, Player player) {
        if (Color == card.Color) {
            card.UseSpezial(player);
            return true;
        }
        return false;
    }
    
}