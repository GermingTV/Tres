namespace Domain.Core;

public class PTwoCard : BaseSpezialCard{

    public PTwoCard(ECardColor color,string url) {
        Color = color;
        ImgUrl = url;
    }

    public override void UseSpezial(DeterministicKi ki) {
        Console.WriteLine("-------------- Ki got +2");
        var deck = HandFactory.CreateDeck();
        ki.AIHand.Add(deck.Draw());
        ki.AIHand.Add(deck.Draw());
        ki.CanPlay = false;
    }
    
    public override void UseSpezial(Player player) {
        Console.WriteLine("-------------- Player got +2");
        var deck = HandFactory.CreateDeck();
        player.Hand.Add(deck.Draw());
        player.Hand.Add(deck.Draw());
        player.CanPlay = false;
    }
    
    
    public override bool CanPlay(BaseCard card, DeterministicKi ki) {
        return card.CanPlayAgainst(this, ki);
    }
    
    public override bool CanPlay(BaseCard card, Player player) {
        return card.CanPlayAgainst(this, player);
    }
    
    
    
    public override bool CanPlayAgainst(PTwoCard card, DeterministicKi ki) {
        card.UseSpezial(ki);
        return true;
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

    public override bool CanPlayAgainst(LockCard card, DeterministicKi ki) {
        if (Color == card.Color) {
            card.UseSpezial(ki);
            return true;
        }
        return false;
    }
    
    
    //Ki Site

    public override bool CanPlayAgainst(PTwoCard card, Player player) {
        card.UseSpezial(player);
        return true;
    }

    public override bool CanPlayAgainst(PFourCard card, Player player) {
        if (Color == card.Color) {
            card.UseSpezial(player);
            return true;
        }
        return false;
    }

    public override bool CanPlayAgainst(NumberCard card, Player player) {
        if (Color == card.Color) {
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