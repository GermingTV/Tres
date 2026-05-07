namespace Domain.Core;

public abstract class BaseCard {
    
    public ECardColor Color { get; set; }
    
    public string ImgUrl { get; set; }

    //Bei der normalen Nuber Card kann man bei einer 2ten number card auf color & number prüfen
    //bei number mit spezial nur mit color
    public abstract bool AllowedToPlace(NumberCard currentCard);
    
    //Bei spezial Cards kann man nur jz nur auf die farbe prüfen 
    // !!!!!!!!!!!!!!! für die spezial cards noch schreiben !!!!!!!!!!!!!!!!!!!!!1 
    public abstract bool AllowedToPlace(BaseSpezialCard currentCard);

}