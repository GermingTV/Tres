namespace Domain.Core;

public class PFourCard : BaseSpezialCard{
    
    public override void UseSpezial() {
        
    }
    
    //nutzend der plus 4 und rückgabe der farbe zur 
    //definition der farbe nach auswahl
    public ECardColor UseP4() {
        return ECardColor.BLUE;
    }
    
    public override bool CanPlay(BaseCard card) {
        return card.CanPlayAgainst(this);
    }

    public override bool CanPlayAgainst(PTwoCard card) {
        return false;
    }

    public override bool CanPlayAgainst(PFourCard card) {
        return true;
    }

    public override bool CanPlayAgainst(NumberCard card) {
        return true;
    }
    

    
    
    public void Add4_OnAi() {
        
    }
    
    public void Add4_OnPlayer() {
        
    }

    public bool CanCounter() {
        return false;
    }

    
}