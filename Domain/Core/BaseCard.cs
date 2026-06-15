namespace Domain.Core;

public abstract class BaseCard : ISpezialEffect{
    
    public ECardColor Color { get; set; }

    public string ImgUrl { get; set; } = "/CardImages/DemoBackside.webp";

    public int CardCount { get; set; }
    
    public abstract bool CanPlay(BaseCard card, Player player);
    public abstract bool CanPlayAgainst(PTwoCard card,Player player);
    public abstract  bool CanPlayAgainst(PFourCard card,Player player);
    public abstract  bool CanPlayAgainst(NumberCard card,Player player);
    public abstract bool CanPlayAgainst(LockCard card,Player player);

    public abstract bool CanPlay(BaseCard card, DeterministicKi ki);
    public abstract bool CanPlayAgainst(PTwoCard card, DeterministicKi ki);
    public abstract  bool CanPlayAgainst(PFourCard card, DeterministicKi ki);
    public abstract  bool CanPlayAgainst(NumberCard card, DeterministicKi ki);
    public abstract bool CanPlayAgainst(LockCard card, DeterministicKi ki);


    public abstract void UseSpezialEffect(Player player);

    public abstract void UseSpezialEffect(DeterministicKi ki);
}