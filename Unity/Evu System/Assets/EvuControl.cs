using UnityEngine;
using System.Collections;
using UnityEngine.UI;


using System;


public class EvuControl : MonoBehaviour {

	string path;
	int Number = 0;
	int Page = 1;




	// Questions

	public GameObject oneQuestion;
	public GameObject twoQuestion;
	public GameObject threeQuestion;
	public GameObject fourQuestion;
	public GameObject fiveQuestion;
	

	// Buttons

	public GameObject nextButton;
	public GameObject doneButton;


	// Check Boxes

	int questionOnePageOne;
	int questionOnePageTwo;
	int questionOnePageThree;
	int questionOnePageFour;
	int questionOnePageFive;
	int questionOnePageSix;

	public GameObject oneCheckOne;
	public GameObject oneCheckTwo;
	public GameObject oneCheckThree;
	public GameObject oneCheckFour;
	public GameObject oneCheckFive;

	int questionTwoPageOne;
	int questionTwoPageTwo;
	int questionTwoPageThree;
	int questionTwoPageFour;
	int questionTwoPageFive;
	int questionTwoPageSix;
	
	public GameObject twoCheckOne;
	public GameObject twoCheckTwo;
	public GameObject twoCheckThree;
	public GameObject twoCheckFour;
	public GameObject twoCheckFive;

	int questionThreePageOne;
	int questionThreePageTwo;
	int questionThreePageThree;
	int questionThreePageFour;
	int questionThreePageFive;
	int questionThreePageSix;
	
	public GameObject threeCheckOne;
	public GameObject threeCheckTwo;
	public GameObject threeCheckThree;
	public GameObject threeCheckFour;
	public GameObject threeCheckFive;

	int questionFourPageOne;
	int questionFourPageTwo;
	int questionFourPageThree;
	int questionFourPageFour;
	int questionFourPageFive;
	int questionFourPageSix;
	
	public GameObject fourCheckOne;
	public GameObject fourCheckTwo;
	public GameObject fourCheckThree;
	public GameObject fourCheckFour;
	public GameObject fourCheckFive;

	int questionFivePageOne;
	int questionFivePageTwo;
	int questionFivePageThree;
	int questionFivePageFour;
	int questionFivePageFive;
	int questionFivePageSix;
	
	public GameObject fiveCheckOne;
	public GameObject fiveCheckTwo;
	public GameObject fiveCheckThree;
	public GameObject fiveCheckFour;
	public GameObject fiveCheckFive;


	// Use this for initialization
	void Start () {

		path = Application.dataPath;










	
	}
	
	// Update is called once per frame
	void Update () {

		#region Questions

		if(Page == 1) {
			oneQuestion.GetComponent<Text>().text = "I never lost my attention from the computer screen.";
			twoQuestion.GetComponent<Text>().text = "I never lost my attention from the game.";
			threeQuestion.GetComponent<Text>().text = "I understand the main plot in the game.";
			fourQuestion.GetComponent<Text>().text = "I remember all of the information i received during the gameplay.";
			fiveQuestion.GetComponent<Text>().text = "I noticed and remember the color of the main characters’ clothes.";


			nextButton.SetActive(true);
			doneButton.SetActive(false);
		}

		if(Page == 2) {
			oneQuestion.GetComponent<Text>().text = "I felt like I was the main character during the playthrough.";
			twoQuestion.GetComponent<Text>().text = "The choices I took during the playthrough reflected how I would have acted, if I were in the main characters’ shoes.";
			threeQuestion.GetComponent<Text>().text = "I felt like the sound were distracting me from the story.";
			fourQuestion.GetComponent<Text>().text = "I felt like the visuals of the story were a distraction from the narrative, rather than a supporting element.";
			fiveQuestion.GetComponent<Text>().text = "After playing the game, I keep thinking about the story and what happens next / reflect upon the narrative.";


		}

		if(Page == 3) {
			oneQuestion.GetComponent<Text>().text = "I understand the main storyline of the game.";
			twoQuestion.GetComponent<Text>().text = "I understand the motivations behind the main character(s)’ actions.";
			threeQuestion.GetComponent<Text>().text = "I understand the motivations of the other characters’ actions.";
			fourQuestion.GetComponent<Text>().text = "I understand the message the author wants to communicate with this game.";
			fiveQuestion.GetComponent<Text>().text = "This story is recognizable.";


		}

		if(Page == 4) {
			oneQuestion.GetComponent<Text>().text = "I felt that I had an emotional connection with the main character(s), during the playthrough.";
			twoQuestion.GetComponent<Text>().text = "I felt happy for the main character(s) when good things happened to them.";
			threeQuestion.GetComponent<Text>().text = "I felt sorry for the main character(s) after bad situations or through life choices.";
			fourQuestion.GetComponent<Text>().text = "The main character feel familiar.";
			fiveQuestion.GetComponent<Text>().text = "I can identify with the main character(s).";


		}

		if(Page == 5) {
			oneQuestion.GetComponent<Text>().text = "I regret some of the choices made during my playthrough.";
			twoQuestion.GetComponent<Text>().text = "I would like to play the game again but with a different story.";
			threeQuestion.GetComponent<Text>().text = "I would like to play the game again but with a different setting.";
			fourQuestion.GetComponent<Text>().text = "I would like to play the game again but with a new character.";
			fiveQuestion.GetComponent<Text>().text = "I would like to play the game again but with a different role.";


		}

		if(Page == 6) {
			oneQuestion.GetComponent<Text>().text = "I enjoyed the story.";
			twoQuestion.GetComponent<Text>().text = "I enjoyed the setting.";
			threeQuestion.GetComponent<Text>().text = "I enjoyed the characters.";
			fourQuestion.GetComponent<Text>().text = "I enjoyed the gameplay.";
			fiveQuestion.GetComponent<Text>().text = "I would play similar games again another time.";



			nextButton.SetActive(false);
			doneButton.SetActive(true);
		}

		#endregion


	// Question 1

		#region Question1

		if(oneCheckOne.GetComponent<Toggle>().isOn == true) {


			if(Page == 1)
				questionOnePageOne = 1;

			if(Page == 2)
				questionOnePageTwo = 1;
			
			if(Page == 3)
				questionOnePageThree = 1;

			if(Page == 4)
				questionOnePageFour = 1;

			if(Page == 5)
				questionOnePageFive = 1;

			if(Page == 6)
				questionOnePageSix = 1;

			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;

		}

		if(oneCheckTwo.GetComponent<Toggle>().isOn == true) {



			if(Page == 1)
				questionOnePageOne = 2;
			
			if(Page == 2)
				questionOnePageTwo = 2;
			
			if(Page == 3)
				questionOnePageThree = 2;
			
			if(Page == 4)
				questionOnePageFour = 2;
			
			if(Page == 5)
				questionOnePageFive = 2;
			
			if(Page == 6)
				questionOnePageSix = 2;
			
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckOne.GetComponent<Toggle>().isOn = false;

			
		}

		if(oneCheckThree.GetComponent<Toggle>().isOn == true) {




			if(Page == 1)
				questionOnePageOne = 3;
			
			if(Page == 2)
				questionOnePageTwo = 3;
			
			if(Page == 3)
				questionOnePageThree = 3;
			
			if(Page == 4)
				questionOnePageFour = 3;
			
			if(Page == 5)
				questionOnePageFive = 3;
			
			if(Page == 6)
				questionOnePageSix = 3;

			
			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckOne.GetComponent<Toggle>().isOn = false;

			
		}

		if(oneCheckFour.GetComponent<Toggle>().isOn == true) {



			if(Page == 1)
				questionOnePageOne = 4;
			
			if(Page == 2)
				questionOnePageTwo = 4;
			
			if(Page == 3)
				questionOnePageThree = 4;
			
			if(Page == 4)
				questionOnePageFour = 4;
			
			if(Page == 5)
				questionOnePageFive = 4;
			
			if(Page == 6)
				questionOnePageSix = 4;

			
			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			oneCheckOne.GetComponent<Toggle>().isOn = false;

		}

		if(oneCheckFive.GetComponent<Toggle>().isOn == true) {




			if(Page == 1)
				questionOnePageOne = 5;
			
			if(Page == 2)
				questionOnePageTwo = 5;
			
			if(Page == 3)
				questionOnePageThree = 5;
			
			if(Page == 4)
				questionOnePageFour = 5;
			
			if(Page == 5)
				questionOnePageFive = 5;
			
			if(Page == 6)
				questionOnePageSix = 5;

			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckOne.GetComponent<Toggle>().isOn = false;

			
		}

		#endregion

	// Question 2

		#region Question2
		
		if(twoCheckOne.GetComponent<Toggle>().isOn == true) {
			
			
			
			if(Page == 1)
				questionTwoPageOne = 1;
			
			if(Page == 2)
				questionTwoPageTwo = 1;
			
			if(Page == 3)
				questionTwoPageThree = 1;
			
			if(Page == 4)
				questionTwoPageFour = 1;
			
			if(Page == 5)
				questionTwoPageFive = 1;
			
			if(Page == 6)
				questionTwoPageSix = 1;
			
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(twoCheckTwo.GetComponent<Toggle>().isOn == true) {
			
			
			
			if(Page == 1)
				questionTwoPageOne = 2;
			
			if(Page == 2)
				questionTwoPageTwo = 2;
			
			if(Page == 3)
				questionTwoPageThree = 2;
			
			if(Page == 4)
				questionTwoPageFour = 2;
			
			if(Page == 5)
				questionTwoPageFive = 2;
			
			if(Page == 6)
				questionTwoPageSix = 2;
			
			
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(twoCheckThree.GetComponent<Toggle>().isOn == true) {
			
			
			
			
			if(Page == 1)
				questionTwoPageOne = 3;
			
			if(Page == 2)
				questionTwoPageTwo = 3;
			
			if(Page == 3)
				questionTwoPageThree = 3;
			
			if(Page == 4)
				questionTwoPageFour = 3;
			
			if(Page == 5)
				questionTwoPageFive = 3;
			
			if(Page == 6)
				questionTwoPageSix = 3;
			
			
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(twoCheckFour.GetComponent<Toggle>().isOn == true) {
			
			
			
			if(Page == 1)
				questionTwoPageOne = 4;
			
			if(Page == 2)
				questionTwoPageTwo = 4;
			
			if(Page == 3)
				questionTwoPageThree = 4;
			
			if(Page == 4)
				questionTwoPageFour = 4;
			
			if(Page == 5)
				questionTwoPageFive = 4;
			
			if(Page == 6)
				questionTwoPageSix = 4;
			
			
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(twoCheckFive.GetComponent<Toggle>().isOn == true) {
			
			
			
			
			if(Page == 1)
				questionTwoPageOne = 5;
			
			if(Page == 2)
				questionTwoPageTwo = 5;
			
			if(Page == 3)
				questionTwoPageThree = 5;
			
			if(Page == 4)
				questionTwoPageFour = 5;
			
			if(Page == 5)
				questionTwoPageFive = 5;
			
			if(Page == 6)
				questionTwoPageSix = 5;
			
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		
	

	#endregion
	
	// Question 3

		#region Question3

		if(threeCheckOne.GetComponent<Toggle>().isOn == true) {
			
			
			
			if(Page == 1)
				questionThreePageOne = 1;
			
			if(Page == 2)
				questionThreePageTwo = 1;
			
			if(Page == 3)
				questionThreePageThree = 1;
			
			if(Page == 4)
				questionThreePageFour = 1;
			
			if(Page == 5)
				questionThreePageFive = 1;
			
			if(Page == 6)
				questionThreePageSix = 1;
			
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(threeCheckTwo.GetComponent<Toggle>().isOn == true) {
			
			
			
			if(Page == 1)
				questionThreePageOne = 2;
			
			if(Page == 2)
				questionThreePageTwo = 2;
			
			if(Page == 3)
				questionThreePageThree = 2;
			
			if(Page == 4)
				questionThreePageFour = 2;
			
			if(Page == 5)
				questionThreePageFive = 2;
			
			if(Page == 6)
				questionThreePageSix = 2;
			
			
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(threeCheckThree.GetComponent<Toggle>().isOn == true) {
			
			
			
			
			if(Page == 1)
				questionThreePageOne = 3;
			
			if(Page == 2)
				questionThreePageTwo = 3;
			
			if(Page == 3)
				questionThreePageThree = 3;
			
			if(Page == 4)
				questionThreePageFour = 3;
			
			if(Page == 5)
				questionThreePageFive = 3;
			
			if(Page == 6)
				questionThreePageSix = 3;
			
			
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(threeCheckFour.GetComponent<Toggle>().isOn == true) {
			
			
			
			if(Page == 1)
				questionThreePageOne = 4;
			
			if(Page == 2)
				questionThreePageTwo = 4;
			
			if(Page == 3)
				questionThreePageThree = 4;
			
			if(Page == 4)
				questionThreePageFour = 4;
			
			if(Page == 5)
				questionThreePageFive = 4;
					
			if(Page == 6)
				questionThreePageSix = 4;
			
			
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			threeCheckOne.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(threeCheckFive.GetComponent<Toggle>().isOn == true) {
			
			
			
			
			if(Page == 1)
				questionThreePageOne = 5;
			
			if(Page == 2)
				questionThreePageTwo = 5;
			
			if(Page == 3)
				questionThreePageThree = 5;
			
			if(Page == 4)
				questionThreePageFour = 5;
			
			if(Page == 5)
				questionThreePageFive = 5;
			
			if(Page == 6)
				questionThreePageSix = 5;
			
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}

		#endregion

	// Question 4

		#region Question4

		if(fourCheckOne.GetComponent<Toggle>().isOn == true) {
			
			
			
			if(Page == 1)
				questionFourPageOne = 1;
			
			if(Page == 2)
				questionFourPageTwo = 1;
			
			if(Page == 3)
				questionFourPageThree = 1;
			
			if(Page == 4)
				questionFourPageFour = 1;
			
			if(Page == 5)
				questionFourPageFive = 1;
			
			if(Page == 6)
				questionFourPageSix = 1;
			
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(fourCheckTwo.GetComponent<Toggle>().isOn == true) {
			
			
			
			if(Page == 1)
				questionFourPageOne = 2;
			
			if(Page == 2)
				questionFourPageTwo = 2;
			
			if(Page == 3)
				questionFourPageThree = 2;
			
			if(Page == 4)
				questionFourPageFour = 2;
			
			if(Page == 5)
				questionFourPageFive = 2;
			
			if(Page == 6)
				questionFourPageSix = 2;
			
			
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(fourCheckThree.GetComponent<Toggle>().isOn == true) {
			
			
			
			
			if(Page == 1)
				questionFourPageOne = 3;
			
			if(Page == 2)
				questionFourPageTwo = 3;
			
			if(Page == 3)
				questionFourPageThree = 3;
			
			if(Page == 4)
				questionFourPageFour = 3;
			
			if(Page == 5)
				questionFourPageFive = 3;
			
			if(Page == 6)
				questionFourPageSix = 3;
			
			
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(fourCheckFour.GetComponent<Toggle>().isOn == true) {
			
			
			
			if(Page == 1)
				questionFourPageOne = 4;
			
			if(Page == 2)
				questionFourPageTwo = 4;
			
			if(Page == 3)
				questionFourPageThree = 4;
			
			if(Page == 4)
				questionFourPageFour = 4;
			
			if(Page == 5)
				questionFourPageFive = 4;
					
			if(Page == 6)
				questionFourPageSix = 4;
			
			
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			fourCheckOne.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(fourCheckFive.GetComponent<Toggle>().isOn == true) {
			
			
			
			
			if(Page == 1)
				questionFourPageOne = 5;
			
			if(Page == 2)
				questionFourPageTwo = 5;
			
			if(Page == 3)
				questionFourPageThree = 5;
			
			if(Page == 4)
				questionFourPageFour = 5;
			
			if(Page == 5)
				questionFourPageFive = 5;
			
			if(Page == 6)
				questionFourPageSix = 5;
			
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}

		#endregion

	// Question 5

		#region Question5

		if(fiveCheckOne.GetComponent<Toggle>().isOn == true) {
			
			
			
			if(Page == 1)
				questionFivePageOne = 1;
			
			if(Page == 2)
				questionFivePageTwo = 1;
			
			if(Page == 3)
				questionFivePageThree = 1;
			
			if(Page == 4)
				questionFivePageFour = 1;
			
			if(Page == 5)
				questionFivePageFive = 1;
			
			if(Page == 6)
				questionFivePageSix = 1;
			
			fiveCheckTwo.GetComponent<Toggle>().isOn = false;
			fiveCheckThree.GetComponent<Toggle>().isOn = false;
			fiveCheckFour.GetComponent<Toggle>().isOn = false;
			fiveCheckFive.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(fiveCheckTwo.GetComponent<Toggle>().isOn == true) {
			
			
			
			if(Page == 1)
				questionFivePageOne = 2;
			
			if(Page == 2)
				questionFivePageTwo = 2;
			
			if(Page == 3)
				questionFivePageThree = 2;
			
			if(Page == 4)
				questionFivePageFour = 2;
			
			if(Page == 5)
				questionFivePageFive = 2;
			
			if(Page == 6)
				questionFivePageSix = 2;
			
			
			fiveCheckFive.GetComponent<Toggle>().isOn = false;
			fiveCheckThree.GetComponent<Toggle>().isOn = false;
			fiveCheckFour.GetComponent<Toggle>().isOn = false;
			fiveCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(fiveCheckThree.GetComponent<Toggle>().isOn == true) {
			
			
			
			
			if(Page == 1)
				questionFivePageOne = 3;
			
			if(Page == 2)
				questionFivePageTwo = 3;
			
			if(Page == 3)
				questionFivePageThree = 3;
			
			if(Page == 4)
				questionFivePageFour = 3;
			
			if(Page == 5)
				questionFivePageFive = 3;
			
			if(Page == 6)
				questionFivePageSix = 3;
			
			
			fiveCheckTwo.GetComponent<Toggle>().isOn = false;
			fiveCheckFive.GetComponent<Toggle>().isOn = false;
			fiveCheckFour.GetComponent<Toggle>().isOn = false;
			fiveCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(fiveCheckFour.GetComponent<Toggle>().isOn == true) {
			
			
			
			if(Page == 1)
				questionFivePageOne = 4;
			
			if(Page == 2)
				questionFivePageTwo = 4;
			
			if(Page == 3)
				questionFivePageThree = 4;
			
			if(Page == 4)
				questionFivePageFour = 4;
			
			if(Page == 5)
				questionFivePageFive = 4;
					
			if(Page == 6)
				questionFivePageSix = 4;
			
			
			fiveCheckTwo.GetComponent<Toggle>().isOn = false;
			fiveCheckThree.GetComponent<Toggle>().isOn = false;
			fiveCheckFive.GetComponent<Toggle>().isOn = false;
			fiveCheckOne.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(fiveCheckFive.GetComponent<Toggle>().isOn == true) {
			
			
			
			
			if(Page == 1)
				questionFivePageOne = 5;
			
			if(Page == 2)
				questionFivePageTwo = 5;
			
			if(Page == 3)
				questionFivePageThree = 5;
			
			if(Page == 4)
				questionFivePageFour = 5;
			
			if(Page == 5)
				questionFivePageFive = 5;
			
			if(Page == 6)
				questionFivePageSix = 5;
			
			fiveCheckTwo.GetComponent<Toggle>().isOn = false;
			fiveCheckThree.GetComponent<Toggle>().isOn = false;
			fiveCheckFour.GetComponent<Toggle>().isOn = false;
			fiveCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}

		#endregion




}

	public void NextPage () {

		// Next Page and Toggle False

		#region Page and Toggle

		if(Page == 1) {

			Page = 2;
			oneCheckOne.GetComponent<Toggle>().isOn = false;
			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;

			twoCheckOne.GetComponent<Toggle>().isOn = false;
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;

			threeCheckOne.GetComponent<Toggle>().isOn = false;
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckFive.GetComponent<Toggle>().isOn = false;

			fourCheckOne.GetComponent<Toggle>().isOn = false;
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckFive.GetComponent<Toggle>().isOn = false;

			fiveCheckOne.GetComponent<Toggle>().isOn = false;
			fiveCheckTwo.GetComponent<Toggle>().isOn = false;
			fiveCheckThree.GetComponent<Toggle>().isOn = false;
			fiveCheckFour.GetComponent<Toggle>().isOn = false;
			fiveCheckFive.GetComponent<Toggle>().isOn = false;

		}else if(Page == 2) {

			Page = 3;
			oneCheckOne.GetComponent<Toggle>().isOn = false;
			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			
			threeCheckOne.GetComponent<Toggle>().isOn = false;
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			
			fourCheckOne.GetComponent<Toggle>().isOn = false;
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			
			fiveCheckOne.GetComponent<Toggle>().isOn = false;
			fiveCheckTwo.GetComponent<Toggle>().isOn = false;
			fiveCheckThree.GetComponent<Toggle>().isOn = false;
			fiveCheckFour.GetComponent<Toggle>().isOn = false;
			fiveCheckFive.GetComponent<Toggle>().isOn = false;

		}else if(Page == 3) {

			Page = 4;
			oneCheckOne.GetComponent<Toggle>().isOn = false;
			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			
			threeCheckOne.GetComponent<Toggle>().isOn = false;
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			
			fourCheckOne.GetComponent<Toggle>().isOn = false;
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			
			fiveCheckOne.GetComponent<Toggle>().isOn = false;
			fiveCheckTwo.GetComponent<Toggle>().isOn = false;
			fiveCheckThree.GetComponent<Toggle>().isOn = false;
			fiveCheckFour.GetComponent<Toggle>().isOn = false;
			fiveCheckFive.GetComponent<Toggle>().isOn = false;

		}else if(Page == 4) {

			Page = 5;
			oneCheckOne.GetComponent<Toggle>().isOn = false;
			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			
			threeCheckOne.GetComponent<Toggle>().isOn = false;
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			
			fourCheckOne.GetComponent<Toggle>().isOn = false;
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			
			fiveCheckOne.GetComponent<Toggle>().isOn = false;
			fiveCheckTwo.GetComponent<Toggle>().isOn = false;
			fiveCheckThree.GetComponent<Toggle>().isOn = false;
			fiveCheckFour.GetComponent<Toggle>().isOn = false;
			fiveCheckFive.GetComponent<Toggle>().isOn = false;

		}else if(Page == 5) {

			Page = 6;
			oneCheckOne.GetComponent<Toggle>().isOn = false;
			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			
			threeCheckOne.GetComponent<Toggle>().isOn = false;
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			
			fourCheckOne.GetComponent<Toggle>().isOn = false;
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			
			fiveCheckOne.GetComponent<Toggle>().isOn = false;
			fiveCheckTwo.GetComponent<Toggle>().isOn = false;
			fiveCheckThree.GetComponent<Toggle>().isOn = false;
			fiveCheckFour.GetComponent<Toggle>().isOn = false;
			fiveCheckFive.GetComponent<Toggle>().isOn = false;

		}
		#endregion
	}


	public void QuestionsDone () {


		do{
				
			Number++;

		} while (System.IO.File.Exists(path + "/Questionnaire" + Number + ".txt"));


		System.IO.File.WriteAllText( path + "/Questionnaire" + Number + ".txt", 
		                            questionOnePageOne + " " + questionTwoPageOne + " " + questionThreePageOne + " " + questionFourPageOne + " " + questionFivePageOne + " " +
		                            questionOnePageTwo + " " + questionTwoPageTwo + " " + questionThreePageTwo + " " + questionFourPageTwo + " " + questionFivePageTwo + " " +
		                            questionOnePageThree + " " + questionTwoPageThree + " " + questionThreePageThree + " " + questionFourPageThree + " " + questionFivePageThree + " " +
		                            questionOnePageFour + " " + questionTwoPageFour + " " + questionThreePageFour + " " + questionFourPageFour + " " + questionFivePageFour + " " +
		                            questionOnePageFive + " " + questionTwoPageFive + " " + questionThreePageFive + " " + questionFourPageFive + " " + questionFivePageFive + " " +
		                            questionOnePageSix + " " + questionTwoPageSix + " " + questionThreePageSix + " " + questionFourPageSix + " " + questionFivePageSix);


		
		Application.Quit();

	
		}




}
