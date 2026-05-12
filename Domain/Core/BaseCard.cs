namespace Domain.Core;

public abstract class BaseCard {
    
    public ECardColor Color { get; set; }
    
    public string ImgUrl { get; set; }

    public abstract bool CanPlay(BaseCard card);
    public abstract bool CanPlayAgainst(PTwoCard card);
    public abstract  bool CanPlayAgainst(PFourCard card);
    public abstract  bool CanPlayAgainst(NumberCard card);
    
    
}