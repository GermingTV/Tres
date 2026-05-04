namespace Domain.Core;

public class PFourCard : BaseCard{
    
    public ECardColor Color { get; set; }

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