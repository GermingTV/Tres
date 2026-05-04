namespace Domain.Core;

public class GameEngine {

    public Player Player { get; set; }

    public int TurnCount { get; set; } = 0;
    
    public BaseCard CurrentCard { get; set; }
    
    public bool IsOver { get; set; } = false;
    
    public void BeginPlay(string playerName){
        DeterministicKi deterministicKi = DeterministicKi.Instance;
        
        //Player = new Player(playerName, CreateFirstHand());

        /*
        while (!IsOver) {
            Player.PlayerTurn(deterministicKi, CurrentCard);
        }*/
        
    }

    /*public List<BaseCard> CreateFirstHand() {
        
    }*/
    
    

}