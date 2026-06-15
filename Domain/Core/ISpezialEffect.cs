namespace Domain.Core;

public interface ISpezialEffect {

    void UseSpezialEffect(Player player);
    
    void UseSpezialEffect(DeterministicKi ki);
}