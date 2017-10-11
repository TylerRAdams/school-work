
public class Player {
	String name;
	int score;
	Hand hand;
	int bid;
	int tricks;
	Card playedCard;
	
	public Player(String name, int score, Hand hand, int bid, int tricks, Card playedCard){
		this.name = name;
		this.score = score;
		this.hand = hand;
		this.bid = bid;
		this.tricks = tricks;
		this.playedCard = playedCard;
	}
	
	public String name(){
		String name = this.name;
		return name;
	}
	
	public int score(){
		return score;
	}
	
	public Hand hand(){
		String[] hand = {""};
		Hand h = new Hand(hand);
		return h;
	}
	
	
	public void addCard(String card){
		hand.addCard(card);
	}
}
