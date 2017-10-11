
public class Rank {
	public static int EMPTY = 0;
	public static int LOWACE = 1;
	public static int TWO = 2;
	public static int THREE = 3;
	public static int FOUR = 4;
	public static int FIVE = 5;
	public static int SIX = 6;
	public static int SEVEN = 7;
	public static int EIGHT = 8;
	public static int NINE = 9;
	public static int TEN = 10;
	public static int JACK = 11;
	public static int QUEEN = 12;
	public static int KING = 13;
	public static int HIGHACE = 14;
	
	public static String num2rank(int rank){
		switch(rank){
		case 0: return "EMPTY";
		case 1: return "LOWACE";
		case 2: return "TWO";
		case 3: return "THREE";
		case 4: return "FOUR";
		case 5: return "FIVE";
		case 6: return "SIX";
		case 7: return "SEVEN";
		case 8: return "EIGHT";
		case 9: return "NINE";
		case 10: return "TEN";
		case 11: return "JACK";
		case 12: return "QUEEN";
		case 13: return "KING";
		case 14: return "ACE";
		}
		return "Error";
	}
	
	public static String num2single(int rank){
		switch(rank){
		case 0: return "E";
		case 1: return "L";
		case 2: return "2";
		case 3: return "3";
		case 4: return "4";
		case 5: return "5";
		case 6: return "6";
		case 7: return "7";
		case 8: return "8";
		case 9: return "9";
		case 10: return "T";
		case 11: return "J";
		case 12: return "Q";
		case 13: return "K";
		case 14: return "A";
		}
		return "Error";
	}
}
