/********************************************************************************* 
 * Bathroom Simulation															 *
 * By Tyler Adams																	 *
 * The only procedure I could fit into its own function was using facilities.    *
 ********************************************************************************/

import java.util.ArrayList;
import java.util.*;
public class Restroom {

	public static void main(String[] args) {
		ArrayList<int[]> peopleQueue = new ArrayList<>(); //People waiting in line
		ArrayList<int[]> activeBathroom = new ArrayList<>(); //People waiting in the bathroom
		
		//GENERATE PEOPLE
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
		}
		
		int totalTimeCounter = 0;
		int departureCounter = 0; //Amount of people who have left the bathroom
		int genderMode = 2; //0 = F, 1 = M, 2 = Empty
		/**for(int i = 0; i < peopleQueue.size(); i++) {
			System.out.println(Arrays.toString(peopleQueue.get(i)));
		}**/
		while (departureCounter < 19) { //Until 20 people leave the bathroom
			
			//FIRST DEPART
			for(int i = 0; i < activeBathroom.size(); i++) {
				int[]currentPerson = activeBathroom.get(i);
				if(currentPerson[2] == 0) { //If person is out of time, aka has finished
					activeBathroom.remove(i); //Remove them from the bathroom
					if(currentPerson[1] == 0) { //If current person is female
						System.out.println("Time = " + totalTimeCounter + "; Person " + currentPerson[0] + "(F) exits");
						departureCounter++; //One person has departed
					}
					else if(currentPerson[1] == 1) { //If current person is male
						System.out.println("Time = " + totalTimeCounter + "; Person " + currentPerson[0] + "(M) exits");
						departureCounter++; //One person has departed
					}
				}
			}
			
			//THEN ARRIVE
			if(activeBathroom.size() < 3) {
				if(activeBathroom.size() == 0) { //If the bathroom is empty, always take the first person in line
					genderMode = 2; //Sets the bathroom to empty
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
