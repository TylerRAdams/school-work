
public class Converter {
	public static Card convert(int rank, int suit){
		if(rank == 'E'){
			rank = Rank.EMPTY;
		}
		if(rank == 'L'){
			rank = Rank.LOWACE;
		}
		if(rank == '2'){
			rank = Rank.TWO;
		}
		if(rank == '3'){
			rank = Rank.THREE;
		}
		if(rank == '4'){
			rank = Rank.FOUR;
		}
		if(rank == '5'){
			rank = Rank.FIVE;
		}
		if(rank == '6'){
			rank = Rank.SIX;
		}
		if(rank == '7'){
			rank = Rank.SEVEN;
		}
		if(rank == '8'){
			rank = Rank.EIGHT;
		}
		if(rank == '9'){
			rank = Rank.NINE;
		}
		if(rank == 'T'){
			rank = Rank.TEN;
		}
		if(rank == 'J' || rank == 'j'){
			rank = Rank.JACK;
		}
		if(rank == 'Q' || rank == 'q'){
			rank = Rank.QUEEN;
		}
		if(rank == 'K' || rank == 'k'){
			rank = Rank.KING;
		}
		if(rank == 'A' || rank == 'a'){
			rank = Rank.HIGHACE;
		}
		if(suit == 'C' || suit == 'c'){
			suit = Suit.CLUB;
		}
		if(suit == 'D' || suit == 'd'){
			suit = Suit.DIAMOND;
		}
		if(suit == 'H'){
			suit = Suit.HEART;
		}
		if(suit == 'S'){
			suit = Suit.SPADE;
		}
		Card c = new Card(rank, suit);
		return c;
	}
}
