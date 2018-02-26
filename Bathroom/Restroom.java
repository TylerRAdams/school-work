/********************************************************************************* 
 * Bathroom Simulation															 *
 * By Tyler Adams																 *
 * The only procedure I could fit into its own function was using facilities.    *
 ********************************************************************************/

import java.util.ArrayList;
import java.util.Scanner;
public class Restroom {

	public static void main(String[] args) {
		Scanner kb = new Scanner(System.in);
		System.out.println("Which scenario would you like to run?");
		System.out.println("Type 'A' for all people arriving at once");
		System.out.println("Type 'B'for 5 people arriving with a delay of 10 min between");
		System.out.println("Type 'C' for 10 people arriving with a delay of 10 min between");
		String choice = kb.next();
		kb.close();
		ArrayList<int[]> peopleQueue = new ArrayList<>(); //People waiting in line
		ArrayList<int[]> activeBathroom = new ArrayList<>(); //People waiting in the bathroom
		ArrayList<int[]> peopleToRemove = new ArrayList<>();
		int totalTimeCounter = 0;
		int departureCounter = 0; //Amount of people who have left the bathroom
		int genderMode = 2; //0 = F, 1 = M, 2 = Empty

		//GENERATING PEOPLE

		if(choice.equals("A")) {
		//Scenario 1, all arrive at the same time 0
		for(int i = 1; i <= 20; i++) {
			int g;
			double genderGenerate = Math.random();
			if(genderGenerate >= .6)
				g = 1; //Gender is female
			else
				g = 0; //Gender is male
			int t = 3 + (int)(Math.random() * ((7 - 3) + 1)); //Generates integer between 3 and 7
			int[] OnePerson = new int[3]; //Creates person
			OnePerson[0] = i; //Sets ID
			OnePerson[1] = g; //Sets Gender
			OnePerson[2] = t; //Sets Time
			peopleQueue.add(OnePerson);
			if(OnePerson[1] == 0)
			System.out.println("Time = " + totalTimeCounter + "; Person " + OnePerson[0] + "(F) arrives.");
			if(OnePerson[1] == 1)
				System.out.println("Time = " + totalTimeCounter + "; Person " + OnePerson[0] + "(M) arrives.");	
			}
		}
		else if(choice.equals("B")) {
		//Scenario 2, 5 Arrive, 10m Delay, 5 Arrive, etc.
		if(totalTimeCounter == 0) {
			for(int i = 1; i <= 5; i++) {
			int g;
			double genderGenerate = Math.random();
			if(genderGenerate >= .6)
				g = 1; //Gender is female
			else
				g = 0; //Gender is male
			int t = 3 + (int)(Math.random() * ((7 - 3) + 1)); //Generates integer between 3 and 7
			int[] OnePerson = new int[3]; //Creates person
			OnePerson[0] = i; //Sets ID
			OnePerson[1] = g; //Sets Gender
			OnePerson[2] = t; //Sets Time
			peopleQueue.add(OnePerson);
			if(OnePerson[1] == 0)
			System.out.println("Time = " + totalTimeCounter + "; Person " + OnePerson[0] + "(F) arrives.");
			if(OnePerson[1] == 1)
				System.out.println("Time = " + totalTimeCounter + "; Person " + OnePerson[0] + "(M) arrives.");
			}
		}
		if(totalTimeCounter == 5) {
			for(int i = 6; i <= 10; i++) {
			int g;
			double genderGenerate = Math.random();
			if(genderGenerate >= .6)
				g = 1; //Gender is female
			else
				g = 0; //Gender is male
			int t = 3 + (int)(Math.random() * ((7 - 3) + 1)); //Generates integer between 3 and 7
			int[] OnePerson = new int[3]; //Creates person
			OnePerson[0] = i; //Sets ID
			OnePerson[1] = g; //Sets Gender
			OnePerson[2] = t; //Sets Time
			peopleQueue.add(OnePerson);
			if(OnePerson[1] == 0)
			System.out.println("Time = " + totalTimeCounter + "; Person " + OnePerson[0] + "(F) arrives.");
			if(OnePerson[1] == 1)
				System.out.println("Time = " + totalTimeCounter + "; Person " + OnePerson[0] + "(M) arrives.");
			}
		}
		if(totalTimeCounter == 10) {
			for(int i = 11; i <= 15; i++) {
			int g;
			double genderGenerate = Math.random();
			if(genderGenerate >= .6)
				g = 1; //Gender is female
			else
				g = 0; //Gender is male
			int t = 3 + (int)(Math.random() * ((7 - 3) + 1)); //Generates integer between 3 and 7
			int[] OnePerson = new int[3]; //Creates person
			OnePerson[0] = i; //Sets ID
			OnePerson[1] = g; //Sets Gender
			OnePerson[2] = t; //Sets Time
			peopleQueue.add(OnePerson);
			if(OnePerson[1] == 0)
			System.out.println("Time = " + totalTimeCounter + "; Person " + OnePerson[0] + "(F) arrives.");
			if(OnePerson[1] == 1)
				System.out.println("Time = " + totalTimeCounter + "; Person " + OnePerson[0] + "(M) arrives.");
			}
		}
		if(totalTimeCounter == 15) {
			for(int i = 16; i <= 20; i++) {
			int g;
			double genderGenerate = Math.random();
			if(genderGenerate >= .6)
				g = 1; //Gender is female
			else
				g = 0; //Gender is male
			int t = 3 + (int)(Math.random() * ((7 - 3) + 1)); //Generates integer between 3 and 7
			int[] OnePerson = new int[3]; //Creates person
			OnePerson[0] = i; //Sets ID
			OnePerson[1] = g; //Sets Gender
			OnePerson[2] = t; //Sets Time
			peopleQueue.add(OnePerson);
			if(OnePerson[1] == 0)
			System.out.println("Time = " + totalTimeCounter + "; Person " + OnePerson[0] + "(F) arrives.");
			if(OnePerson[1] == 1)
				System.out.println("Time = " + totalTimeCounter + "; Person " + OnePerson[0] + "(M) arrives.");
			}
		}
		}
		else if(choice.equals("C")) {
		//Scenario 3, 10 arrive, 10m Delay
		if(totalTimeCounter == 0) {
		for(int i = 1; i <= 10; i++) {
			int g;
			double genderGenerate = Math.random();
			if(genderGenerate >= .6)
				g = 1; //Gender is female
			else
				g = 0; //Gender is male
			int t = 3 + (int)(Math.random() * ((7 - 3) + 1)); //Generates integer between 3 and 7
			int[] OnePerson = new int[3]; //Creates person
			OnePerson[0] = i; //Sets ID
			OnePerson[1] = g; //Sets Gender
			OnePerson[2] = t; //Sets Time
			peopleQueue.add(OnePerson);
			if(OnePerson[1] == 0)
			System.out.println("Time = " + totalTimeCounter + "; Person " + OnePerson[0] + "(F) arrives.");
			if(OnePerson[1] == 1)
				System.out.println("Time = " + totalTimeCounter + "; Person " + OnePerson[0] + "(M) arrives.");	
			}
		}
		if(totalTimeCounter == 10) {
			for(int i = 11; i <= 20; i++) {
				int g;
				double genderGenerate = Math.random();
				if(genderGenerate >= .6)
					g = 1; //Gender is female
				else
					g = 0; //Gender is male
				int t = 3 + (int)(Math.random() * ((7 - 3) + 1)); //Generates integer between 3 and 7
				int[] OnePerson = new int[3]; //Creates person
				OnePerson[0] = i; //Sets ID
				OnePerson[1] = g; //Sets Gender
				OnePerson[2] = t; //Sets Time
				peopleQueue.add(OnePerson);
				if(OnePerson[1] == 0)
				System.out.println("Time = " + totalTimeCounter + "; Person " + OnePerson[0] + "(F) arrives.");
				if(OnePerson[1] == 1)
					System.out.println("Time = " + totalTimeCounter + "; Person " + OnePerson[0] + "(M) arrives.");	
				}
			}
		}

		//BATHROOM OPERATION
		
		while (departureCounter < 20) { //Until 20 people leave the bathroom
			
			//FIRST DEPART
			for(int i = 0; i < activeBathroom.size(); i++) {
				int[]currentPerson = activeBathroom.get(i);
				if(currentPerson[2] == 0) { //If person is out of time, aka has finished
					peopleToRemove.add(currentPerson); //Remove them from the bathroom
					departureCounter++; //One person has departed
					if(currentPerson[1] == 0) { //If current person is female
						System.out.println("Time = " + totalTimeCounter + "; Person " + currentPerson[0] + "(F) exits");
					}
					else if(currentPerson[1] == 1) { //If current person is male
						System.out.println("Time = " + totalTimeCounter + "; Person " + currentPerson[0] + "(M) exits");
					}
					else {
						System.out.println("Whoops");
					}
				}
			}
			for(int i = 0; i < activeBathroom.size(); i++) {
				for(int j = 0; j < peopleToRemove.size(); j++) {
					if(activeBathroom.get(i) == peopleToRemove.get(j)) {
						activeBathroom.remove(i);
						peopleToRemove.remove(j);
					}
				}
			}
			
			//THEN ARRIVE
			if(peopleQueue.size() != 0) { //If there are still people in the queue
			if(activeBathroom.size() < 3) {
				if(activeBathroom.size() == 0) { //If the bathroom is empty, always take the first person in line
					genderMode = 2; //Sets the gender mode to empty
					activeBathroom.add(peopleQueue.get(0));
					int[] currentPerson = activeBathroom.get(0);
					if(currentPerson[1] == 0) {
						genderMode = 0;
						System.out.println("Time = " + totalTimeCounter + "; Person " + currentPerson[0] + "(F) enters for " + currentPerson[2] + " minutes");
					}
					if(currentPerson[1] == 1) {
						genderMode = 1;
						System.out.println("Time = " + totalTimeCounter + "; Person " + currentPerson[0] + "(M) enters for " + currentPerson[2] + " minutes");
					}
					peopleQueue.remove(0);
				}
				for(int i = 0; i < peopleQueue.size(); i++) {
					if(genderMode == 0 && activeBathroom.size() < 3) { //Female in bathroom
						int[] currentPerson = peopleQueue.get(i);
						if(currentPerson[1] == 0) { //Person is female
							activeBathroom.add(currentPerson);
							peopleQueue.remove(i);
							System.out.println("Time = " + totalTimeCounter + "; Person " + currentPerson[0] + "(F) enters for " + currentPerson[2] + " minutes");
						}
					}
					if(genderMode == 1 && activeBathroom.size() < 3) { //Male in bathroom
						int[] currentPerson = peopleQueue.get(i);
						if(currentPerson[1] == 1) { //Person is male
							activeBathroom.add(currentPerson);
							peopleQueue.remove(i);
							System.out.println("Time = " + totalTimeCounter + "; Person " + currentPerson[0] + "(M) enters for " + currentPerson[2] + " minutes");
						}
					}
				}
				}
			}
			//FINALLY USE FACILITIES
			activeBathroom = UseFacilities(activeBathroom);
			totalTimeCounter++;
		}
	}

	public static ArrayList<int[]> UseFacilities(ArrayList<int[]> bathroom) { //Decrease each person in bathroom's time by 1
		for(int i = 0; i < bathroom.size(); i++) {
			int[] currentPerson = bathroom.get(i);
			currentPerson[2]--; //Time is stored in this part of the array, so it's decreased by 1
			bathroom.set(i, currentPerson);
			//System.out.println(Arrays.toString(bathroom.get(i)));
		}
		return bathroom;
	}
}
