
public class Suit {
	public static int CLUB = 0;
	public static int DIAMOND = 1;
	public static int HEART = 2;
	public static int SPADE = 3;
	
	public static String num2suit(int suit){
		switch(suit){
		case 0: return "CLUB";
		case 1: return "DIAMOND";
		case 2: return "HEART";
		case 3: return "SPADE";
		}
		return "Error";
	}
	
	public static String num2single(int suit){
		switch(suit){
		case 0: return "C";
		case 1: return "D";
		case 2: return "H";
		case 3: return "S";
		}
		return "Error";
	}
}
