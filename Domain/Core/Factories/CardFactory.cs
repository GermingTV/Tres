namespace Domain.Core;

public static class CardFactory {
    
    //normal Number Cards
    //red
    public static BaseCard CreateRed0() => new NumberCard(0, ECardColor.RED,"imag/Red0");
    
    public static BaseCard CreateRed1() {
        return new NumberCard(1, ECardColor.RED,"imag/Red1");
    }
    public static BaseCard CreateRed2() {
        return new NumberCard(2, ECardColor.RED,"imag/Red2");
    }
    public static BaseCard CreateRed3() {
        return new NumberCard(3, ECardColor.RED,"imag/Red3");
    }
    public static BaseCard CreateRed4() {
        return new NumberCard(4, ECardColor.RED,"imag/Red4");
    }
    public static BaseCard CreateRed5() {
        return new NumberCard(5, ECardColor.RED,"imag/Red5");
    }
    public static BaseCard CreateRed6() {
        return new NumberCard(6, ECardColor.RED,"imag/Red6");
    }
    public static BaseCard CreateRed7() {
        return new NumberCard(7, ECardColor.RED,"imag/Red7");
    }
    public static BaseCard CreateRed8() {
        return new NumberCard(8, ECardColor.RED,"imag/Red8");
    }
    public static BaseCard CreateRed9() {
        return new NumberCard(9, ECardColor.RED,"imag/Red9");
    }
    
    //blue
    public static BaseCard CreateBlue0() {
        return new NumberCard(0, ECardColor.BLUE,"imag/Blue0");
    }
    public static BaseCard CreateBlue1() {
        return new NumberCard(1, ECardColor.BLUE,"imag/Blue1");
    }
    public static BaseCard CreateBlue2() {
        return new NumberCard(2, ECardColor.BLUE,"imag/Blue2");
    }
    public static BaseCard CreateBlue3() {
        return new NumberCard(3, ECardColor.BLUE,"imag/Blue3");
    }
    public static BaseCard CreateBlue4() {
        return new NumberCard(4, ECardColor.BLUE,"imag/Blue4");
    }
    public static BaseCard CreateBlue5() {
        return new NumberCard(5, ECardColor.BLUE,"imag/Blue5");
    }
    public static BaseCard CreateBlue6() {
        return new NumberCard(6, ECardColor.BLUE,"imag/Blue6");
    }
    public static BaseCard CreateBlue7() {
        return new NumberCard(7, ECardColor.BLUE,"imag/Blue7");
    }
    public static BaseCard CreateBlue8() {
        return new NumberCard(8, ECardColor.BLUE,"imag/Blue8");
    }
    public static BaseCard CreateBlue9() {
        return new NumberCard(9, ECardColor.BLUE,"imag/Blue9");
    }
    
    //yellow
    public static BaseCard CreateYellow0() {
        return new NumberCard(0, ECardColor.YELLOW, "imag/Yellow0_NoOutline.png");
    }
    public static BaseCard CreateYellow1() {
        return new NumberCard(1, ECardColor.YELLOW,"imag/Yellow1_NoOutLine.png");
    }
    public static BaseCard CreateYellow2() {
        return new NumberCard(2, ECardColor.YELLOW, "imag/Yellow2_NoOutLine.png");
    }
    public static BaseCard CreateYellow3() {
        return new NumberCard(3, ECardColor.YELLOW,  "imag/Yellow3_NoOutLine.png");
    }
    public static BaseCard CreateYellow4() {
        return new NumberCard(4, ECardColor.YELLOW, "imag/Yellow4_NoOutLine.png");
    }
    public static BaseCard CreateYellow5() {
        return new NumberCard(5, ECardColor.YELLOW, "imag/Yellow5_NoOutLine.png");
    }
    public static BaseCard CreateYellow6() {
        return new NumberCard(6, ECardColor.YELLOW, "imag/Yellow6_NoOutLine.png");
    }
    public static BaseCard CreateYellow7() {
        return new NumberCard(7, ECardColor.YELLOW ,"imag/Yellow7_NoOutLine.png");
    }
    public static BaseCard CreateYellow8() {
        return new NumberCard(8, ECardColor.YELLOW,"imag/Yellow8_NoOutLine.png");
    }
    public static BaseCard CreateYellow9() {
        return new NumberCard(9, ECardColor.YELLOW,"imag/Yellow9_NoOutLine.png");
    }
    
    //Green
    public static BaseCard CreateGreen0() {
        return new NumberCard(0, ECardColor.GREEN,"imag/Green0");
    }
    public static BaseCard CreateGreen1() {
        return new NumberCard(1, ECardColor.GREEN,"imag/Green1");
    }
    public static BaseCard CreateGreen2() {
        return new NumberCard(2, ECardColor.GREEN,"imag/Green2");
    }
    public static BaseCard CreateGreen3() {
        return new NumberCard(3, ECardColor.GREEN,"imag/Green3");
    }
    public static BaseCard CreateGreen4() {
        return new NumberCard(4, ECardColor.GREEN,"imag/Green4");
    }
    public static BaseCard CreateGreen5() {
        return new NumberCard(5, ECardColor.GREEN,"imag/Green5");
    }
    public static BaseCard CreateGreen6() {
        return new NumberCard(6, ECardColor.GREEN,"imag/Green6");
    }
    public static BaseCard CreateGreen7() {
        return new NumberCard(7, ECardColor.GREEN,"imag/Green7");
    }
    public static BaseCard CreateGreen8() {
        return new NumberCard(8, ECardColor.GREEN,"imag/Green8");
    }
    public static BaseCard CreateGreen9() {
        return new NumberCard(9, ECardColor.GREEN,"imag/Green9");
    }
    
}