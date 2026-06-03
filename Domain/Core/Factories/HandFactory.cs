namespace Domain.Core;

public static class HandFactory {
    public static Deck CreateDeck() {
        return new Deck() {
            Cards = new List<BaseCard>() {
                CardFactory.CreateBlue0(),
                CardFactory.CreateBlue1(),
                CardFactory.CreateBlue2(),
                CardFactory.CreateBlue3(),
                CardFactory.CreateBlue4(),
                CardFactory.CreateBlue5(),
                CardFactory.CreateBlue6(),
                CardFactory.CreateBlue7(),
                CardFactory.CreateBlue8(),
                CardFactory.CreateBlue9(),
                CardFactory.CreateGreen0(),
                CardFactory.CreateGreen1(),
                CardFactory.CreateGreen2(),
                CardFactory.CreateGreen3(),
                CardFactory.CreateGreen4(),
                CardFactory.CreateGreen5(),
                CardFactory.CreateGreen6(),
                CardFactory.CreateGreen7(),
                CardFactory.CreateGreen8(),
                CardFactory.CreateGreen9(),
                CardFactory.CreateRed0(),
                CardFactory.CreateRed1(),
                CardFactory.CreateRed2(),
                CardFactory.CreateRed3(),
                CardFactory.CreateRed4(),
                CardFactory.CreateRed5(),
                CardFactory.CreateRed6(),
                CardFactory.CreateRed7(),
                CardFactory.CreateRed8(),
                CardFactory.CreateRed9(),
                CardFactory.CreateYellow0(),
                CardFactory.CreateYellow1(),
                CardFactory.CreateYellow2(),
                CardFactory.CreateYellow3(),
                CardFactory.CreateYellow4(),
                CardFactory.CreateYellow5(),
                CardFactory.CreateYellow6(),
                CardFactory.CreateYellow7(),
                CardFactory.CreateYellow8(),
                CardFactory.CreateYellow9(),
                //Spezial Cards
                CardFactory.CreateBlueLock(),
                CardFactory.CreateBluePlus2(),
                
                CardFactory.CreateYellowLock(),
                CardFactory.CreateYellowPlus2(),
                
                CardFactory.CreateRedLock(),
                CardFactory.CreateRedPlus2(),
                
                CardFactory.CreateGreenLock(),
                CardFactory.CreateGreenPlus2(),
            }
        };
    }
}