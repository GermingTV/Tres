using System.Net.NetworkInformation;

namespace Domain.Core;

public class PFourCard : BaseSpezialCard{
    
    public override void UseSpezial(Player player) {
        
    }
    public override void UseSpezial(DeterministicKi ki) {
        
    }
    
    //nutzend der plus 4 und rückgabe der farbe zur 
    //definition der farbe nach auswahl
    public ECardColor UseP4() {
        return ECardColor.BLUE;
    }
    
    public override bool CanPlay(BaseCard card, Player player) {
        return card.CanPlayAgainst(this, player);
    }

    public override bool CanPlay(BaseCard card, DeterministicKi ki) {
        return card.CanPlayAgainst(this, ki);
    }

    public override bool CanPlayAgainst(PTwoCard card, Player player) {
        return false;
    }

    public override bool CanPlayAgainst(PFourCard card, Player player) {
        UseSpezial(player);
        return true;
    }

    public override bool CanPlayAgainst(NumberCard card, Player player) {
        UseSpezial(player);
        return true;
    }

    public override bool CanPlayAgainst(LockCard card, Player player) {
        UseSpezial(player);
        return true;
    }
    
    public override bool CanPlayAgainst(PTwoCard card, DeterministicKi ki) {
        return false;
    }

    public override bool CanPlayAgainst(PFourCard card, DeterministicKi ki) {
        UseSpezial(ki);
        return true;
    }

    public override bool CanPlayAgainst(NumberCard card, DeterministicKi ki) {
        UseSpezial(ki);
        return true;
    }

    public override bool CanPlayAgainst(LockCard card, DeterministicKi ki) {
        UseSpezial(ki);
        return true;
    }

    
}