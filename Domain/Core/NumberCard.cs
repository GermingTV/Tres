namespace Domain.Core;

public class NumberCard : BaseCard{
    
    public int Number { get; set; }
 
    public ECardColor Color { get; set; }
    
    public NumberCard(int number, ECardColor color) {
        Number = number;
        Color = color;
    }
}