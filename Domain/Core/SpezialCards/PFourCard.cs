namespace Domain.Core;

public class PFourCard : BaseSpezialCard{
    
    public override void UseSpezial() {
        
    }
    
    public override bool AllowedToPlace(NumberCard currentCard) {
        return false;
    }

    public override bool AllowedToPlace(BaseSpezialCard currentCard) {
        return false;
    }


    public ECardColor UseP4() {
        return ECardColor.BLUE;
    }
    
    public void Add4_OnAi() {
        
    }
    
    public void Add4_OnPlayer() {
        
    }

    public bool CanCounter() {
        return false;
    }

    
}