import java.util.ArrayList;
import java.util.Scanner;
public class Game {
	Scanner kb = new Scanner(System.in);
	ArrayList<Player> players = new ArrayList<Player>();
	//CREATES PLAYERS
	public void playerAdd(){
	System.out.print("Enter Amount of Players (2-6): ");
	int playerNumber = kb.nextInt();
	while(playerNumber < 2 || playerNumber > 6){
		System.out.println("Invalid number of players.");
		System.out.print("Enter Amount of Players (2-6): ");
		playerNumber = kb.nextInt();
	}
	for(int i = 0; i < playerNumber; i++){
		System.out.print("Enter Player Name: ");
		String playerName = kb.next();
		int score = 0;
		String[] hand1 = {};
		Hand h = new Hand(hand1);
		int bid = 0;
		int tricks = 0;
		Card playedCard = Converter.convert(0, 0);
		Player p = new Player(playerName, score, h, bid, tricks, playedCard);
		System.out.println(playerName + " is Player " + (i+1));
		players.add(p);
	}
}
	
	//DEALS CARDS

	
	//DISPLAYS ALL PLAYERS AND HANDS
	public void displayPlayers(){
		for(int i = 0; i < players.size(); i++){
			Player p = players.get(i);
			System.out.println("Player " + (i+1) + ": " + p.name + " | Current Score: " + p.score);
			p.hand.printHand();
		}
	}
	
	public void hongGame(){
		int turn = 7;
		Card winningCard = Converter.convert(0, 0);
		System.out.println("WELCOME TO HONG-E-LONG-LONG, THE GAME OF CHAMPIONS");
		playerAdd();	
		for(int g = 0; g < turn; g++){
		Deck d = new Deck();
			d.shuffle();
			for(int j = 0; j < turn; j++){
			for(int i = 0; i < players.size(); i++){
				Player p = players.get(i);
				p.addCard(d.topCard().getAbbrev());
				d.removeTopCard();
			}
		}
		//SORT
		for(int playerSort = 0; playerSort < players.size(); playerSort++){
			Player p = players.get(playerSort);
			//SORT BY SUIT, STARTING WITH SPADE
			for (int i = 0; i < p.hand.cards.size()-1; i++){
				for (int j = i+1; j < p.hand.cards.size(); j++){
					if (p.hand.cards.get(i).suit < p.hand.cards.get(j).suit){
						Card temp1 = p.hand.cards.get(i);
						Card temp2 = p.hand.cards.get(j);
						p.hand.cards.set(i, temp2);
						p.hand.cards.set(j, temp1);
					}
				}
			}
			//SORT BY RANK
			for (int i = 0; i < p.hand.cards.size()-1; i++){
				for (int j = i+1; j < p.hand.cards.size(); j++){
					if (p.hand.cards.get(i).rank > p.hand.cards.get(j).rank && p.hand.cards.get(i).suit <= p.hand.cards.get(j).suit){
						Card temp1 = p.hand.cards.get(i);
						Card temp2 = p.hand.cards.get(j);
						p.hand.cards.set(i, temp2);
						p.hand.cards.set(j, temp1);
					}
				}
			}
		}
		Card trump = d.topCard();
		d.removeTopCard();
		displayPlayers();
		System.out.println("Trump for hand is: " + trump.getAbbrev());
			//BIDDING
			for(int i = 0; i < players.size(); i++){
				Player p = players.get(i);
				System.out.print("Enter bid for " +p.name); p.hand.hongStats(trump.getAbbrev());
				p.bid = kb.nextInt();
				System.out.print(p.name + " bids " + p.bid + ".\n");
			}
			//PLAYING CARDS
			for(int t = 0; t < turn; t++){
			for(int i = 0; i < players.size(); i++){
				Player p = players.get(i);
				p.hand.printHand();
				System.out.print("Enter number of card for " + p.name + ": ");
				int cardIndex = kb.nextInt()-1;
				p.playedCard = p.hand.cards.get(cardIndex);
				System.out.println(p.name + " plays " + p.playedCard.getAbbrev());
	
			//TRICKS
			//Whichever card has the highest trump, barring that whichever card has the highest value should win
			p.hand.removeCard(p.playedCard.getAbbrev());
			if(p.playedCard.rank > winningCard.rank && p.playedCard.suit != trump.suit && winningCard.suit != trump.suit){
				winningCard = p.playedCard;
			}
			else if(winningCard.suit == trump.suit){
				if(p.playedCard.suit == trump.suit && p.playedCard.rank > winningCard.rank){
					winningCard = p.playedCard;
				}
			}
			else if(p.playedCard.suit == trump.suit){
				winningCard = p.playedCard;
			}
			if(p.playedCard.rank == winningCard.rank && p.playedCard.suit == winningCard.suit){
				p.tricks += 1;
			}
		}
			System.out.print("Winning card is: " + winningCard.getName() + "\n");
			winningCard.rank = 0; winningCard.suit = 0;
			}
			
			//SCORING
			//This for loop is dumb but fixes the tricks issue
			for(int blagh = 1; blagh < players.size(); blagh++){
				players.get(0).tricks -= players.get(blagh).tricks;
			}
			if(players.get(0).tricks < 0){
				players.get(0).tricks = 0;
			}
			for(int i = 0; i < players.size(); i++){
			Player p = players.get(i);
			System.out.println(p.name + " bid " + p.bid + " and got " + p.tricks);
			if(p.tricks == p.bid && p.bid != 0){
				p.score += 10+p.tricks;
			}
			if(p.tricks == 0 && p.bid == 0){
				p.score += 5;
			}
			p.tricks = 0;
		}
			turn--;
		}
	}
}
