namespace Domain.Core;

public class AiOderKi {

    public string AiOderKiName { get; set; } 

    public string PFPUrl { get; set; }

    public List<BaseCard> AIHand { get; set; }

    public bool CanPlay { get; set; }
    
    private AiOderKi() {
        AiOderKiName = "Andre Enne";
        
        
    }

    public static AiOderKi _instance { get;} = new AiOderKi();
    

}