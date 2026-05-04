namespace Domain.Core;

public class Player {
    
    public string PlayerName { get; set; }
    
    public List<BaseCard> Hand { get; set; }

    public bool CanPlay { get; set; }

    public Player(string playerName,  List<BaseCard> hand) {
        PlayerName = playerName;
        Hand = hand;
        CanPlay = true;
    }
    
    
}