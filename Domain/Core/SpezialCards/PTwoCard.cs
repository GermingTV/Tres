namespace Domain.Core;

public class PTwoCard : BaseSpezialCard{

    public override void UseSpezial() {
        
    }
    
    public override bool AllowedToPlace(NumberCard currentCard) {
        return false;
    }

    public override bool AllowedToPlace(BaseSpezialCard currentCard) {
        return false;
    }

    
    public void Add2_OnPlayer() {
        
    }

    public void Add2_OnAi() {
        
    }

    
}