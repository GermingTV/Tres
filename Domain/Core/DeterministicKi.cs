namespace Domain.Core;

public class DeterministicKi {

    public string AiOderKiName { get; set; } = "Andre Enne"; 

    public string PFPUrl { get; set; }

    public List<BaseCard> AIHand { get; set; }

    public bool CanPlay { get; set; }

    public static DeterministicKi Instance { get;} = new DeterministicKi();
    
    private DeterministicKi() {
        CanPlay = true;
    }

    public BaseCard AiTurn(Player player, BaseCard currentCard, Deck _deck) {
        if (!CanPlay) {return currentCard;}

        // muss schauen ob er karte hat -> hat eine liste aus möglichen karten -> wählt random aus liste aus welche karte er nimmt
        var possibleCardIndexes = HasPossibleCard(currentCard);

        if (possibleCardIndexes.Count > 0) {
            var random = new Random();
            int i = random.Next(0,possibleCardIndexes.Count);
            
            //test only
            Console.WriteLine("----------- PC placed "+ AIHand[possibleCardIndexes[i]].Color + " -----------");
            
            BaseCard returnCard = AIHand[possibleCardIndexes[i]];
            AIHand.RemoveAt(possibleCardIndexes[i]);
            return returnCard;
        }else {
            DrawCard(_deck);
            
            //test only
            Console.WriteLine("------------ PC kann nicht spielen ------------");
            
            return currentCard;
        }
    }

    public List<int> HasPossibleCard(BaseCard currentCard) {
        List<int> possibleCardIndexes = new List<int>();
        for (int i = 0; i < AIHand.Count; i++) {
            if (AIHand[i].CanPlay(currentCard)) {
                possibleCardIndexes.Add(i);
            }
        }
        return possibleCardIndexes;
    }

    public void DrawCard(Deck _deck) {
        AIHand.Add(_deck.Draw());
    }


}