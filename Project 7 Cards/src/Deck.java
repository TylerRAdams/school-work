import java.util.ArrayList;
public class Deck {
	ArrayList<Card> deck = new ArrayList<Card>();
	public Deck(){	
			for(int i = 0; i < 4; i++){
			for(int j = 2; j < 15; j++){
			Card c = new Card(j, i);
			deck.add(c);
			}
		}
	}

	public void addCardToDeck(String abbrev){
		int rank = abbrev.charAt(0);
		int suit = abbrev.charAt(1);
		Card c = Converter.convert(rank, suit);
		System.out.print("Adding Card: " + c.getName() + " (" + c.getAbbrev() + ")\n");
		deck.add(c);
	}
	
	public void shuffle(){
		for(int k = 0; k < 1000; k++){
		
					int ran1 = (int)(Math.random()*deck.size());
					int ran2 = (int)(Math.random()*deck.size());
					Card temp1 = deck.get(ran1);
					Card temp2 = deck.get(ran2);
					deck.set(ran1, temp2);
					deck.set(ran2, temp1);
				}
			}
	
	public Card topCard(){
		Card topCard = deck.get(0);
		return topCard;
	}
	
	public void removeTopCard(){
		deck.remove(0);
	}


	public void printDeck(){
		System.out.print("Printing Deck: " + deck.size() + " cards: ");
		for(int i = 0; i < deck.size(); i++){
			deck.get(i).printCard();
		}
		for(int i = 0; i < deck.size(); i++){
			System.out.print("\n\t" + deck.get(i).getName());
		}
		System.out.print("\n");
	}
}
