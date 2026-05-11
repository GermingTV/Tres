namespace Domain.Core;

public class PTwoCard : BaseSpezialCard{

    public override void UseSpezial() {
        
    }
    
    public override bool CanPlay(BaseCard card) {
        return card.CanPlayAgainst(this);
    }

    public override bool CanPlayAgainst(PTwoCard card) {
        if (Color  == card.Color) {
            return true;
        }
        return false;
    }

    public override bool CanPlayAgainst(PFourCard card) {
        if (Color == card.Color) {
            return true;
        }
        return false;
    }

    public override bool CanPlayAgainst(NumberCard card) {
        if (Color == card.Color) {
            return true;
        }
        return false;
    }
    
    
    public void Add2_OnPlayer() {
        
    }

    public void Add2_OnAi() {
        
    }

    
}