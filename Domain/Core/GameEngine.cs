namespace Domain.Core;

public class GameEngine {

    public Player Player { get; set; }

    public int TurnCount { get; set; } = 0;
    
    public void BeginPlay(string playerName){
        DeterministicKi deterministicKi = DeterministicKi.Instance;
        
        Player = new Player(playerName,CreateFirstHand());
        
    }

    public List<BaseCard> CreateFirstHand() {
        
    }
    
    

}