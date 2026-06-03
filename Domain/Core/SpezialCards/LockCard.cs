namespace Domain.Core;

public class LockCard : BaseSpezialCard{

    public LockCard(ECardColor color, string url) {
        Color = color;
        ImgUrl = url;
    }
    
    public override bool CanPlay(BaseCard card, DeterministicKi ki) {
        return card.CanPlayAgainst(this, ki);
    }

    public override bool CanPlay(BaseCard card, Player player) {
        return card.CanPlayAgainst(this, player);
    }
    
    public override bool CanPlayAgainst(LockCard card, DeterministicKi ki) {
        card.UseSpezial(ki);
        return true;
    }

    public override bool CanPlayAgainst(PTwoCard card, DeterministicKi ki) {
        if (Color == card.Color) {
            card.UseSpezial(ki);
            return true;
        }
        return false;
    }

    public override bool CanPlayAgainst(PFourCard card, DeterministicKi ki) {
        if (Color == card.Color) {
            card.UseSpezial(ki);
            return true;
        }
        return false;
    }

    public override bool CanPlayAgainst(NumberCard card, DeterministicKi ki) {
        if (Color == card.Color) {
            return true;
        }
        return false;
    }
    
    
    //Player Part

    public override bool CanPlayAgainst(LockCard card, Player player) {
        card.UseSpezial(player);
        return true;
    }

    public override bool CanPlayAgainst(PTwoCard card, Player player) {
        if (Color == card.Color) {
            card.UseSpezial(player);
            return true;
        }
        return false;
    }

    public override bool CanPlayAgainst(PFourCard card, Player player) {
        if (Color == card.Color) {
            card.UseSpezial(player);
            return true;
        }
        return false;
    }

    public override bool CanPlayAgainst(NumberCard card,Player player) {
        if (Color == card.Color) {
            UseSpezial(player);
            return true;
        }
        return false;
    }
    
    
    public override void UseSpezial(DeterministicKi ki) {
        Console.WriteLine("CanPlay Ki False");
        ki.CanPlay = false;
    }
    
    public override void UseSpezial(Player player) {
        Console.WriteLine("CanPlay Player True");
        player.CanPlay = false;
    }
    
}