namespace Domain.Core;

public static class CardFactory {
    
    //normal Number Cards
    //red
    public static BaseCard CreateRed0() => new NumberCard(0, ECardColor.RED,"imag/RotNullTres.png");
    
    public static BaseCard CreateRed1() {
        return new NumberCard(1, ECardColor.RED,"imag/RotEinsTres.png");
    }
    public static BaseCard CreateRed2() {
        return new NumberCard(2, ECardColor.RED, "imag/RotZweiTres.png");
    }
    public static BaseCard CreateRed3() {
        return new NumberCard(3, ECardColor.RED,"imag/RotDreiTres.png");
    }
    public static BaseCard CreateRed4() {
        return new NumberCard(4, ECardColor.RED,"imag/RotVierTres.png");
    }
    public static BaseCard CreateRed5() {
        return new NumberCard(5, ECardColor.RED,"imag/RotFuenfTres.png");
    }
    public static BaseCard CreateRed6() {
        return new NumberCard(6, ECardColor.RED,"imag/RotSechsTres.png");
    }
    public static BaseCard CreateRed7() {
        return new NumberCard(7, ECardColor.RED,"imag/RotSiebenTres.png");
    }
    public static BaseCard CreateRed8() {
        return new NumberCard(8, ECardColor.RED,"imag/RotAchtTres.png");
    }
    public static BaseCard CreateRed9() {
        return new NumberCard(9, ECardColor.RED,"imag/RotNeunTres.png");
    }
    
    //blue
    public static BaseCard CreateBlue0() {
        return new NumberCard(0, ECardColor.BLUE,"imag/BlueZeroTres.png");
    }
    public static BaseCard CreateBlue1() {
        return new NumberCard(1, ECardColor.BLUE, "imag/BlueOneTres.png");
    }
    public static BaseCard CreateBlue2() {
        return new NumberCard(2, ECardColor.BLUE,"imag/BlueTwoTres.png");
    }
    public static BaseCard CreateBlue3() {
        return new NumberCard(3, ECardColor.BLUE,"imag/BlueThreeTres.png");
    }
    public static BaseCard CreateBlue4() {
        return new NumberCard(4, ECardColor.BLUE,"imag/BlueFourTres.png");
    }
    public static BaseCard CreateBlue5() {
        return new NumberCard(5, ECardColor.BLUE,"imag/BlueFiveTres.png");
    }
    public static BaseCard CreateBlue6() {
        return new NumberCard(6, ECardColor.BLUE,"imag/BlueSixTres.png");
    }
    public static BaseCard CreateBlue7() {
        return new NumberCard(7, ECardColor.BLUE,"imag/BlueSevenTres.png");
    }
    public static BaseCard CreateBlue8() {
        return new NumberCard(8, ECardColor.BLUE,"imag/BlueEightTres.png");
    }
    public static BaseCard CreateBlue9() {
        return new NumberCard(9, ECardColor.BLUE,"imag/BlueNineTres.png");
    }
    
    //yellow
    public static BaseCard CreateYellow0() {
        return new NumberCard(0, ECardColor.YELLOW, "imag/Yellow0_NoOutline.png");
    }
    public static BaseCard CreateYellow1() {
        return new NumberCard(1, ECardColor.YELLOW,"imag/Yellow1_NoOutline.png");
    }
    public static BaseCard CreateYellow2() {
        return new NumberCard(2, ECardColor.YELLOW, "imag/Yellow2_NoOutline.png");
    }
    public static BaseCard CreateYellow3() {
        return new NumberCard(3, ECardColor.YELLOW,  "imag/Yellow3_NoOutline.png");
    }
    public static BaseCard CreateYellow4() {
        return new NumberCard(4, ECardColor.YELLOW, "imag/Yellow4_NoOutline.png");
    }
    public static BaseCard CreateYellow5() {
        return new NumberCard(5, ECardColor.YELLOW, "imag/Yellow5_NoOutline.png");
    }
    public static BaseCard CreateYellow6() {
        return new NumberCard(6, ECardColor.YELLOW, "imag/Yellow6_NoOutline.png");
    }
    public static BaseCard CreateYellow7() {
        return new NumberCard(7, ECardColor.YELLOW ,"imag/Yellow7_NoOutline.png");
    }
    public static BaseCard CreateYellow8() {
        return new NumberCard(8, ECardColor.YELLOW,"imag/Yellow8_NoOutline.png");
    }
    public static BaseCard CreateYellow9() {
        return new NumberCard(9, ECardColor.YELLOW,"imag/Yellow9_NoOutline.png");
    }
    
    //Green
    public static BaseCard CreateGreen0() {
        return new NumberCard(0, ECardColor.GREEN,"imag/GreenZero.png");
    }
    public static BaseCard CreateGreen1() {
        return new NumberCard(1, ECardColor.GREEN,"imag/GreenOne.png");
    }
    public static BaseCard CreateGreen2() {
        return new NumberCard(2, ECardColor.GREEN,"imag/GreenTwo.png");
    }
    public static BaseCard CreateGreen3() {
        return new NumberCard(3, ECardColor.GREEN,"imag/GreenThree.png");
    }
    public static BaseCard CreateGreen4() {
        return new NumberCard(4, ECardColor.GREEN,"imag/GreenFour.png");
    }
    public static BaseCard CreateGreen5() {
        return new NumberCard(5, ECardColor.GREEN, "imag/GreenFive.png");
    }
    public static BaseCard CreateGreen6() {
        return new NumberCard(6, ECardColor.GREEN,"imag/GreenSix.png");
    }
    public static BaseCard CreateGreen7() {
        return new NumberCard(7, ECardColor.GREEN,"imag/GreenSeven.png");
    }
    public static BaseCard CreateGreen8() {
        return new NumberCard(8, ECardColor.GREEN,"imag/GreenEight.png");
    }
    public static BaseCard CreateGreen9() {
        return new NumberCard(9, ECardColor.GREEN,"imag/GreenNine.png");
    }
    
}