import java.util.ArrayList;

public class Hand {
	ArrayList<Card> cards = new ArrayList<Card>();
	
	//Defines a Hand
	public Hand(String[] initialCards){
		for(int i = 0; i < initialCards.length; i++){
			int rank = initialCards[i].charAt(0);
			int suit = initialCards[i].charAt(1);
			Card c = Converter.convert(rank, suit);
			cards.add(c);
		}
	}
	
	public void addCard(String abbrev){
		int rank = abbrev.charAt(0);
		int suit = abbrev.charAt(1);
		Card c = Converter.convert(rank, suit);
		//System.out.print("Adding Card: " + c.getName() + " (" + c.getAbbrev() + ")\n");
		cards.add(c);
	}
	
	public void removeCard(String abbrev){
		for (int i = 0; i < cards.size(); i++){
			if (cards.get(i).getAbbrev().equals(abbrev)){
				//System.out.print("Removing Card: (" + abbrev + " at index " + i + ")\n");
				cards.remove(i);
			}
		}
	}
	//PRINT HAND
	public void printHand(){
		System.out.print("Printing Hand: " + cards.size() + " cards: ");
		for(int i = 0; i < cards.size(); i++){
			cards.get(i).printCard();
		}
		//for(int i = 0; i < cards.size(); i++){
			//System.out.print("\n\t" + cards.get(i).getName());
		//}
		System.out.print("\n\n");
	}
		
	public void hongStats(String trump){
									 /***************
									 * 	GET TRUMP	*
//									 ***************/
//		System.out.print("Enter Trump: (C,D,H,S): ");
//		String trump = kb.next();
//		while(!trump.equalsIgnoreCase("C") && !trump.equalsIgnoreCase("D") && !trump.equalsIgnoreCase("H") && !trump.equalsIgnoreCase("S")){
//		System.out.println("Invalid Trump.");
//		System.out.print("Enter Trump: (C,D,H,S): ");
//		trump = kb.next();
//		}
		int trumpInt = 0;
		if(trump.substring(1).equalsIgnoreCase("C"))
			trumpInt = Suit.CLUB;
		else if (trump.substring(1).equalsIgnoreCase("D"))
			trumpInt = Suit.DIAMOND;
		else if (trump.substring(1).equalsIgnoreCase("H"))
			trumpInt = Suit.HEART;
		else if (trump.substring(1).equalsIgnoreCase("S"))
			trumpInt = Suit.SPADE;
		
		//NUMBER OF TRUMPS
		int numTrumps = 0;
		for(int i = 0; i < cards.size(); i++){
			if(cards.get(i).suit == trumpInt){
				numTrumps++;
			}
		}
		
		//NUMBER OF ACES
				int numAces = 0;
				for(int i = 0; i < cards.size(); i++){
					if(cards.get(i).rank == Rank.HIGHACE){
						numAces++;
					}
				}
		
		//NUMBER OF FACE CARDS
			int faceCards = 0;
			for(int i = 0; i < cards.size(); i++){
				if(cards.get(i).rank == Rank.JACK || cards.get(i).rank == Rank.QUEEN || cards.get(i).rank == Rank.KING){
					faceCards++;
				}
			}
		//NUMBER OF CARDS 2-6
			int two2six = 0;
			for(int i = 0; i < cards.size(); i ++){
				if(cards.get(i).rank == Rank.TWO || cards.get(i).rank == Rank.THREE || cards.get(i).rank == Rank.FOUR || cards.get(i).rank == Rank.FIVE || cards.get(i).rank == Rank.SIX){
					two2six++;
				}
			}
		//SUGGESTED BID (For a Game of 6)
		int suggestedBid = 2;
		if(numTrumps >= 3){
			suggestedBid += 2;
		}
		if(numTrumps == 2){
			suggestedBid++;
		}
		if(faceCards >= 3){
			suggestedBid++;
		}
		if(numAces >= 1){
			suggestedBid++;
		}
		if(numTrumps < 1){
			suggestedBid -= 2;
		}
		if(faceCards < 1){
			suggestedBid--;
		}
		if(two2six >= 3){
			suggestedBid--;
		}
		if(suggestedBid < 0){
			suggestedBid = 0;
		}
		System.out.print("(Suggested Bid: " + suggestedBid + "): ");
	}
}

