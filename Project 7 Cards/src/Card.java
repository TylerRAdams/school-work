 /***********************************
 * Card				    *
 * Coded By: Tyler Adams	    *
 * 10/10/16			    *
 ***********************************/
public class Card {
	int rank; int suit;
	
	public Card(int r, int s){
		this.rank = r;
		this.suit = s;
	}
	
	public String getRank(){
		return Rank.num2single(this.rank); 
	}
	
	public String getSuit(){
		return Suit.num2single(this.suit);
	}
	
	public String getName(){
		return Rank.num2rank(this.rank) + " OF " + Suit.num2suit(this.suit) + "S";
	}
	
	public String getAbbrev(){
		return Rank.num2single(this.rank) + Suit.num2single(this.suit);	
	}
	
	public void printCard(){
		System.out.print(getAbbrev() + " ");
	}
}
