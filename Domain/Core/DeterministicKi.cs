namespace Domain.Core;

public class DeterministicKi {

    public string AiOderKiName { get; set; } = "Andre Enne"; 

    public string PFPUrl { get; set; }

    public List<BaseCard> AIHand { get; set; }

    public bool CanPlay { get; set; }

    public static DeterministicKi Instance { get;} = new DeterministicKi();
    
    private DeterministicKi() {
        
        
    }

    

}