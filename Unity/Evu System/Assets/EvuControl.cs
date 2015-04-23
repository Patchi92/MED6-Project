using UnityEngine;
using System.Collections;
using UnityEngine.UI;


using System;


public class EvuControl : MonoBehaviour {

	string path;
	int preNumber = 0;
	int Number = 0;
	int postNumber = 0;
	int Page = 0;

	bool locked = true;

	public GameObject stopSign;


	// Change Text for first questions

	public GameObject oneText;
	public GameObject twoText;
	public GameObject threeText;
	public GameObject fourText;
	public GameObject fiveText;

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

	string introQuestionName;
	string introQuestionAge;
	string introQuestionGender;

	public GameObject Name;
	public GameObject Age;
	public GameObject Male;
	public GameObject Female;
	public GameObject Gender;

	string introQuestionOne;

	int questionOnePageOne;
	int questionOnePageTwo;
	int questionOnePageThree;
	int questionOnePageFour;
	int questionOnePageFive;
	int questionOnePageSix;

	int endQuestionOnePageOne;
	int endQuestionOnePageTwo;
	int endQuestionOnePageThree;
	int endQuestionOnePageFour;
	int endQuestionOnePageFive;
	int endQuestionOnePageSix;

	public GameObject oneCheckOne;
	public GameObject oneCheckTwo;
	public GameObject oneCheckThree;
	public GameObject oneCheckFour;
	public GameObject oneCheckFive;

	int introQuestionTwo;

	int questionTwoPageOne;
	int questionTwoPageTwo;
	int questionTwoPageThree;
	int questionTwoPageFour;
	int questionTwoPageFive;
	int questionTwoPageSix;

	int endQuestionTwoPageOne;
	int endQuestionTwoPageTwo;
	int endQuestionTwoPageThree;
	int endQuestionTwoPageFour;
	int endQuestionTwoPageFive;
	int endQuestionTwoPageSix;
	
	public GameObject twoCheckOne;
	public GameObject twoCheckTwo;
	public GameObject twoCheckThree;
	public GameObject twoCheckFour;
	public GameObject twoCheckFive;

	int introQuestionThree;

	int questionThreePageOne;
	int questionThreePageTwo;
	int questionThreePageThree;
	int questionThreePageFour;
	int questionThreePageFive;
	int questionThreePageSix;

	int endQuestionThreePageOne;
	int endQuestionThreePageTwo;
	int endQuestionThreePageThree;
	int endQuestionThreePageFour;
	int endQuestionThreePageFive;
	int endQuestionThreePageSix;
	
	public GameObject threeCheckOne;
	public GameObject threeCheckTwo;
	public GameObject threeCheckThree;
	public GameObject threeCheckFour;
	public GameObject threeCheckFive;

	int introQuestionFour;

	int questionFourPageOne;
	int questionFourPageTwo;
	int questionFourPageThree;
	int questionFourPageFour;
	int questionFourPageFive;
	int questionFourPageSix;

	int endQuestionFourPageOne;
	int endQuestionFourPageTwo;
	int endQuestionFourPageThree;
	int endQuestionFourPageFour;
	int endQuestionFourPageFive;
	int endQuestionFourPageSix;
	
	public GameObject fourCheckOne;
	public GameObject fourCheckTwo;
	public GameObject fourCheckThree;
	public GameObject fourCheckFour;
	public GameObject fourCheckFive;

	int introQuestionFive;

	int questionFivePageOne;
	int questionFivePageTwo;
	int questionFivePageThree;
	int questionFivePageFour;
	int questionFivePageFive;
	int questionFivePageSix;

	int endQuestionFivePageOne;
	int endQuestionFivePageTwo;
	int endQuestionFivePageThree;
	int endQuestionFivePageFour;
	int endQuestionFivePageFive;
	int endQuestionFivePageSix;
	
	public GameObject fiveCheckOne;
	public GameObject fiveCheckTwo;
	public GameObject fiveCheckThree;
	public GameObject fiveCheckFour;
	public GameObject fiveCheckFive;


	// Use this for initialization
	void Start () {

		path = Application.dataPath;


		stopSign.SetActive(false);







	
	}
	
	// Update is called once per frame
	void Update () {

		#region Questions

		if((oneCheckOne.GetComponent<Toggle>().isOn == true || oneCheckTwo.GetComponent<Toggle>().isOn == true || oneCheckThree.GetComponent<Toggle>().isOn == true || oneCheckFour.GetComponent<Toggle>().isOn == true || oneCheckFive) && (oneCheckOne.GetComponent<Toggle>().isOn == true || oneCheckTwo.GetComponent<Toggle>().isOn == true || oneCheckThree.GetComponent<Toggle>().isOn == true || oneCheckFour.GetComponent<Toggle>().isOn == true || oneCheckFive.GetComponent<Toggle>().isOn == true) && (oneCheckOne.GetComponent<Toggle>().isOn == true || oneCheckTwo.GetComponent<Toggle>().isOn == true || oneCheckThree.GetComponent<Toggle>().isOn == true || oneCheckFour.GetComponent<Toggle>().isOn == true || oneCheckFive.GetComponent<Toggle>().isOn == true)&& (oneCheckOne.GetComponent<Toggle>().isOn == true || oneCheckTwo.GetComponent<Toggle>().isOn == true || oneCheckThree.GetComponent<Toggle>().isOn == true || oneCheckFour.GetComponent<Toggle>().isOn == true || oneCheckFive.GetComponent<Toggle>().isOn == true) && (oneCheckOne.GetComponent<Toggle>().isOn == true || oneCheckTwo.GetComponent<Toggle>().isOn == true || oneCheckThree.GetComponent<Toggle>().isOn == true || oneCheckFour.GetComponent<Toggle>().isOn == true || oneCheckFive.GetComponent<Toggle>().isOn == true)) {

			locked = false;
		
		}else{
		
			locked = true;

		}


		if(Page == 0) {
			oneQuestion.GetComponent<Text>().text = "I often spend a lot of time playing games";
			twoQuestion.GetComponent<Text>().text = "I am eager to start playing the game.";
			threeQuestion.GetComponent<Text>().text = "I tend to like games where narrative plays an important role.";
			fourQuestion.GetComponent<Text>().text = "I think narrative is essential for my game play experience.";
			fiveQuestion.GetComponent<Text>().text = "I dislike games where the narrative plays no important part of the experience.";


			oneText.GetComponent<Text>().text = "0-3 Hours";
			twoText.GetComponent<Text>().text = "4-6 Hours";
			threeText.GetComponent<Text>().text = "7-10 Hours";
			fourText.GetComponent<Text>().text = "11-14 Hours";
			fiveText.GetComponent<Text>().text = "15+ Hours";

			introQuestionName = Name.GetComponent<InputField>().text;
			introQuestionAge = Age.GetComponent<InputField>().text;

			if(Male.GetComponent<Toggle>().isOn == true) {

				Female.GetComponent<Toggle>().isOn = false;
				introQuestionGender = "Male";

			}

			if(Female.GetComponent<Toggle>().isOn == true) {

				Male.GetComponent<Toggle>().isOn = false;
				introQuestionGender = "Female";
				
			}

			Gender.SetActive(true);
			Female.SetActive(true);
			Male.SetActive(true);
			Name.SetActive(true);
			Age.SetActive(true);
			nextButton.SetActive(true);
			doneButton.SetActive(false);
		}

		if(Page == 1) {

			stopSign.SetActive(true);

			oneQuestion.GetComponent<Text>().text = "I never lost my attention from the computer screen.";
			twoQuestion.GetComponent<Text>().text = "I never lost my attention from the game.";
			threeQuestion.GetComponent<Text>().text = "I understand the main plot in the game.";
			fourQuestion.GetComponent<Text>().text = "I remember all of the information i received during the gameplay.";
			fiveQuestion.GetComponent<Text>().text = "I noticed and remember the color of the main characters’ clothes.";


			oneText.GetComponent<Text>().text = "Strongly Agree";
			twoText.GetComponent<Text>().text = "Agree";
			threeText.GetComponent<Text>().text = "Neither Agree or Disagree";
			fourText.GetComponent<Text>().text = "Disagree";
			fiveText.GetComponent<Text>().text = "Strongly Disagree";

			Gender.SetActive(false);
			Female.SetActive(false);
			Male.SetActive(false);
			Name.SetActive(false);
			Age.SetActive(false);
		}

		if(Page == 2) {

			stopSign.SetActive(false);

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



		}

		if(Page == 7) {

			stopSign.SetActive(true);

			oneQuestion.GetComponent<Text>().text = "I never lost my attention from the computer screen.";
			twoQuestion.GetComponent<Text>().text = "I never lost my attention from the game.";
			threeQuestion.GetComponent<Text>().text = "I understand the main plot in the game.";
			fourQuestion.GetComponent<Text>().text = "I remember all of the information i received during the gameplay.";
			fiveQuestion.GetComponent<Text>().text = "I noticed and remember the color of the main characters’ clothes.";
			
			

		}
		
		if(Page == 8) {

			stopSign.SetActive(false);

			oneQuestion.GetComponent<Text>().text = "I felt like I was the main character during the playthrough.";
			twoQuestion.GetComponent<Text>().text = "The choices I took during the playthrough reflected how I would have acted, if I were in the main characters’ shoes.";
			threeQuestion.GetComponent<Text>().text = "I felt like the sound were distracting me from the story.";
			fourQuestion.GetComponent<Text>().text = "I felt like the visuals of the story were a distraction from the narrative, rather than a supporting element.";
			fiveQuestion.GetComponent<Text>().text = "After playing the game, I keep thinking about the story and what happens next / reflect upon the narrative.";
			
			
		}
		
		if(Page == 9) {
			oneQuestion.GetComponent<Text>().text = "I understand the main storyline of the game.";
			twoQuestion.GetComponent<Text>().text = "I understand the motivations behind the main character(s)’ actions.";
			threeQuestion.GetComponent<Text>().text = "I understand the motivations of the other characters’ actions.";
			fourQuestion.GetComponent<Text>().text = "I understand the message the author wants to communicate with this game.";
			fiveQuestion.GetComponent<Text>().text = "This story is recognizable.";
			
			
		}
		
		if(Page == 10) {
			oneQuestion.GetComponent<Text>().text = "I felt that I had an emotional connection with the main character(s), during the playthrough.";
			twoQuestion.GetComponent<Text>().text = "I felt happy for the main character(s) when good things happened to them.";
			threeQuestion.GetComponent<Text>().text = "I felt sorry for the main character(s) after bad situations or through life choices.";
			fourQuestion.GetComponent<Text>().text = "The main character feel familiar.";
			fiveQuestion.GetComponent<Text>().text = "I can identify with the main character(s).";
			
			
		}
		
		if(Page == 11) {
			oneQuestion.GetComponent<Text>().text = "I regret some of the choices made during my playthrough.";
			twoQuestion.GetComponent<Text>().text = "I would like to play the game again but with a different story.";
			threeQuestion.GetComponent<Text>().text = "I would like to play the game again but with a different setting.";
			fourQuestion.GetComponent<Text>().text = "I would like to play the game again but with a new character.";
			fiveQuestion.GetComponent<Text>().text = "I would like to play the game again but with a different role.";
			
			
		}
		
		if(Page == 12) {
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

			if(Page == 0)
				introQuestionOne = "0-3 Hours";

			if(Page == 1)
				questionOnePageOne = 5;

			if(Page == 2)
				questionOnePageTwo = 5;
			
			if(Page == 3)
				questionOnePageThree = 5;

			if(Page == 4)
				questionOnePageFour = 5;

			if(Page == 5)
				questionOnePageFive = 1;

			if(Page == 6)
				questionOnePageSix = 5;

			if(Page == 7)
				endQuestionOnePageOne = 5;
			
			if(Page == 8)
				endQuestionOnePageTwo = 5;
			
			if(Page == 9)
				endQuestionOnePageThree = 5;
			
			if(Page == 10)
				endQuestionOnePageFour = 5;
			
			if(Page == 11)
				endQuestionOnePageFive = 1;
			
			if(Page == 12)
				endQuestionOnePageSix = 5;

			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;

		}

		if(oneCheckTwo.GetComponent<Toggle>().isOn == true) {

			if(Page == 0)
				introQuestionOne = "4-6 Hours";

			if(Page == 1)
				questionOnePageOne = 4;
			
			if(Page == 2)
				questionOnePageTwo = 4;
			
			if(Page == 3)
				questionOnePageThree = 4;
			
			if(Page == 4)
				questionOnePageFour = 4;
			
			if(Page == 5)
				questionOnePageFive = 2;
			
			if(Page == 6)
				questionOnePageSix = 4;

			if(Page == 7)
				endQuestionOnePageOne = 4;
			
			if(Page == 8)
				endQuestionOnePageTwo = 4;
			
			if(Page == 9)
				endQuestionOnePageThree = 4;
			
			if(Page == 10)
				endQuestionOnePageFour = 4;
			
			if(Page == 11)
				endQuestionOnePageFive = 2;
			
			if(Page == 12)
				endQuestionOnePageSix = 4;
			
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckOne.GetComponent<Toggle>().isOn = false;

			
		}

		if(oneCheckThree.GetComponent<Toggle>().isOn == true) {


			if(Page == 0)
				introQuestionOne = "7-10 Hours";

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

			if(Page == 7)
				endQuestionOnePageOne = 3;
			
			if(Page == 8)
				endQuestionOnePageTwo = 3;
			
			if(Page == 9)
				endQuestionOnePageThree = 3;
			
			if(Page == 10)
				endQuestionOnePageFour = 3;
			
			if(Page == 11)
				endQuestionOnePageFive = 3;
			
			if(Page == 12)
				endQuestionOnePageSix = 3;

			
			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckOne.GetComponent<Toggle>().isOn = false;

			
		}

		if(oneCheckFour.GetComponent<Toggle>().isOn == true) {

			if(Page == 0)
				introQuestionOne = "11-14 Hours";

			if(Page == 1)
				questionOnePageOne = 2;
			
			if(Page == 2)
				questionOnePageTwo = 2;
			
			if(Page == 3)
				questionOnePageThree = 2;
			
			if(Page == 4)
				questionOnePageFour = 2;
			
			if(Page == 5)
				questionOnePageFive = 4;
			
			if(Page == 6)
				questionOnePageSix = 2;

			if(Page == 7)
				endQuestionOnePageOne = 2;
			
			if(Page == 8)
				endQuestionOnePageTwo = 2;
			
			if(Page == 9)
				endQuestionOnePageThree = 2;
			
			if(Page == 10)
				endQuestionOnePageFour = 2;
			
			if(Page == 11)
				endQuestionOnePageFive = 4;
			
			if(Page == 12)
				endQuestionOnePageSix = 2;
			
			
			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			oneCheckOne.GetComponent<Toggle>().isOn = false;

		}

		if(oneCheckFive.GetComponent<Toggle>().isOn == true) {


			if(Page == 0)
				introQuestionOne = "15+ Hours";

			if(Page == 1)
				questionOnePageOne = 1;
			
			if(Page == 2)
				questionOnePageTwo = 1;
			
			if(Page == 3)
				questionOnePageThree = 1;
			
			if(Page == 4)
				questionOnePageFour = 1;
			
			if(Page == 5)
				questionOnePageFive = 5;
			
			if(Page == 6)
				questionOnePageSix = 1;

			if(Page == 7)
				endQuestionOnePageOne = 1;
			
			if(Page == 8)
				endQuestionOnePageTwo = 1;
			
			if(Page == 9)
				endQuestionOnePageThree = 1;
			
			if(Page == 10)
				endQuestionOnePageFour = 1;
			
			if(Page == 11)
				endQuestionOnePageFive = 5;
			
			if(Page == 12)
				endQuestionOnePageSix = 1;

			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckOne.GetComponent<Toggle>().isOn = false;

			
		}

		#endregion

	// Question 2

		#region Question2
		
		if(twoCheckOne.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 0)
				introQuestionTwo = 5;
			
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

			if(Page == 7)
				endQuestionTwoPageOne = 5;
			
			if(Page == 8)
				endQuestionTwoPageTwo = 5;
			
			if(Page == 9)
				endQuestionTwoPageThree = 5;
			
			if(Page == 10)
				endQuestionTwoPageFour = 5;
			
			if(Page == 11)
				endQuestionTwoPageFive = 5;
			
			if(Page == 12)
				endQuestionTwoPageSix = 5;
			
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(twoCheckTwo.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 0)
				introQuestionTwo = 4;
			
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

			if(Page == 7)
				endQuestionTwoPageOne = 4;
			
			if(Page == 8)
				endQuestionTwoPageTwo = 4;
			
			if(Page == 9)
				endQuestionTwoPageThree = 4;
			
			if(Page == 10)
				endQuestionTwoPageFour = 4;
			
			if(Page == 11)
				endQuestionTwoPageFive = 4;
			
			if(Page == 12)
				endQuestionTwoPageSix = 4;
			
			
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(twoCheckThree.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 0)
				introQuestionTwo = 3;
			
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

			if(Page == 7)
				endQuestionTwoPageOne = 3;
			
			if(Page == 8)
				endQuestionTwoPageTwo = 3;
			
			if(Page == 9)
				endQuestionTwoPageThree = 3;
			
			if(Page == 10)
				endQuestionTwoPageFour = 3;
			
			if(Page == 11)
				endQuestionTwoPageFive = 3;
			
			if(Page == 12)
				endQuestionTwoPageSix = 3;
			
			
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(twoCheckFour.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 0)
				introQuestionTwo = 2;
			
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

			if(Page == 7)
				endQuestionTwoPageOne = 2;
			
			if(Page == 8)
				endQuestionTwoPageTwo = 2;
			
			if(Page == 9)
				endQuestionTwoPageThree = 2;
			
			if(Page == 10)
				endQuestionTwoPageFour = 2;
			
			if(Page == 11)
				endQuestionTwoPageFive = 2;
			
			if(Page == 12)
				endQuestionTwoPageSix = 2;
			
			
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(twoCheckFive.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 0)
				introQuestionTwo = 1;
			
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

			if(Page == 7)
				endQuestionTwoPageOne = 1;
			
			if(Page == 8)
				endQuestionTwoPageTwo = 1;
			
			if(Page == 9)
				endQuestionTwoPageThree = 1;
			
			if(Page == 10)
				endQuestionTwoPageFour = 1;
			
			if(Page == 11)
				endQuestionTwoPageFive = 1;
			
			if(Page == 12)
				endQuestionTwoPageSix = 1;
			
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		
	

	#endregion
	
	// Question 3

		#region Question3

		if(threeCheckOne.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 0)
				introQuestionThree = 5;
			
			if(Page == 1)
				questionThreePageOne = 5;
			
			if(Page == 2)
				questionThreePageTwo = 1;
			
			if(Page == 3)
				questionThreePageThree = 5;
			
			if(Page == 4)
				questionThreePageFour = 5;
			
			if(Page == 5)
				questionThreePageFive = 5;
			
			if(Page == 6)
				questionThreePageSix = 5;

			if(Page == 7)
				endQuestionThreePageOne = 5;
			
			if(Page == 8)
				endQuestionThreePageTwo = 1;
			
			if(Page == 9)
				endQuestionThreePageThree = 5;
			
			if(Page == 10)
				endQuestionThreePageFour = 5;
			
			if(Page == 11)
				endQuestionThreePageFive = 5;
			
			if(Page == 12)
				endQuestionThreePageSix = 5;
			
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(threeCheckTwo.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 0)
				introQuestionThree = 4;
			
			if(Page == 1)
				questionThreePageOne = 4;
			
			if(Page == 2)
				questionThreePageTwo = 2;
			
			if(Page == 3)
				questionThreePageThree = 4;
			
			if(Page == 4)
				questionThreePageFour = 4;
			
			if(Page == 5)
				questionThreePageFive = 4;
			
			if(Page == 6)
				questionThreePageSix = 4;

			if(Page == 7)
				endQuestionThreePageOne = 4;
			
			if(Page == 8)
				endQuestionThreePageTwo = 2;
			
			if(Page == 9)
				endQuestionThreePageThree = 4;
			
			if(Page == 10)
				endQuestionThreePageFour = 4;
			
			if(Page == 11)
				endQuestionThreePageFive = 4;
			
			if(Page == 12)
				endQuestionThreePageSix = 4;
			
			
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(threeCheckThree.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 0)
				introQuestionThree = 3;
			
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

			if(Page == 7)
				endQuestionThreePageOne = 3;
			
			if(Page == 8)
				endQuestionThreePageTwo = 3;
			
			if(Page == 9)
				endQuestionThreePageThree = 3;
			
			if(Page == 10)
				endQuestionThreePageFour = 3;
			
			if(Page == 11)
				endQuestionThreePageFive = 3;
			
			if(Page == 12)
				endQuestionThreePageSix = 3;
			
			
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(threeCheckFour.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 0)
				introQuestionThree = 2;
			
			if(Page == 1)
				questionThreePageOne = 2;
			
			if(Page == 2)
				questionThreePageTwo = 4;
			
			if(Page == 3)
				questionThreePageThree = 2;
			
			if(Page == 4)
				questionThreePageFour = 2;
			
			if(Page == 5)
				questionThreePageFive = 2;
					
			if(Page == 6)
				questionThreePageSix = 2;

			if(Page == 7)
				endQuestionThreePageOne = 2;
			
			if(Page == 8)
				endQuestionThreePageTwo = 4;
			
			if(Page == 9)
				endQuestionThreePageThree = 2;
			
			if(Page == 10)
				endQuestionThreePageFour = 2;
			
			if(Page == 11)
				endQuestionThreePageFive = 2;
			
			if(Page == 12)
				endQuestionThreePageSix = 2;
			
			
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			threeCheckOne.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(threeCheckFive.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 0)
				introQuestionThree = 1;
			
			if(Page == 1)
				questionThreePageOne = 1;
			
			if(Page == 2)
				questionThreePageTwo = 5;
			
			if(Page == 3)
				questionThreePageThree = 1;
			
			if(Page == 4)
				questionThreePageFour = 1;
			
			if(Page == 5)
				questionThreePageFive = 1;
			
			if(Page == 6)
				questionThreePageSix = 1;

			if(Page == 7)
				endQuestionThreePageOne = 1;
			
			if(Page == 8)
				endQuestionThreePageTwo = 5;
			
			if(Page == 9)
				endQuestionThreePageThree = 1;
			
			if(Page == 10)
				endQuestionThreePageFour = 1;
			
			if(Page == 11)
				endQuestionThreePageFive = 1;
			
			if(Page == 12)
				endQuestionThreePageSix = 1;
			
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}

		#endregion

	// Question 4

		#region Question4

		if(fourCheckOne.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 0)
				introQuestionFour = 5;
			
			if(Page == 1)
				questionFourPageOne = 5;
			
			if(Page == 2)
				questionFourPageTwo = 1;
			
			if(Page == 3)
				questionFourPageThree = 5;
			
			if(Page == 4)
				questionFourPageFour = 5;
			
			if(Page == 5)
				questionFourPageFive = 5;
			
			if(Page == 6)
				questionFourPageSix = 5;

			if(Page == 7)
				endQuestionFourPageOne = 5;
			
			if(Page == 8)
				endQuestionFourPageTwo = 1;
			
			if(Page == 9)
				endQuestionFourPageThree = 5;
			
			if(Page == 10)
				endQuestionFourPageFour = 5;
			
			if(Page == 11)
				endQuestionFourPageFive = 5;
			
			if(Page == 12)
				endQuestionFourPageSix = 5;
			
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(fourCheckTwo.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 0)
				introQuestionFour = 4;
			
			if(Page == 1)
				questionFourPageOne = 4;
			
			if(Page == 2)
				questionFourPageTwo = 2;
			
			if(Page == 3)
				questionFourPageThree = 4;
			
			if(Page == 4)
				questionFourPageFour = 4;
			
			if(Page == 5)
				questionFourPageFive = 4;
			
			if(Page == 6)
				questionFourPageSix = 4;

			if(Page == 7)
				endQuestionFourPageOne = 4;
			
			if(Page == 8)
				endQuestionFourPageTwo = 2;
			
			if(Page == 9)
				endQuestionFourPageThree = 4;
			
			if(Page == 10)
				endQuestionFourPageFour = 4;
			
			if(Page == 11)
				endQuestionFourPageFive = 4;
			
			if(Page == 12)
				endQuestionFourPageSix = 4;
			
			
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(fourCheckThree.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 0)
				introQuestionFour = 3;
			
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

			if(Page == 7)
				endQuestionFourPageOne = 3;
			
			if(Page == 8)
				endQuestionFourPageTwo = 3;
			
			if(Page == 9)
				endQuestionFourPageThree = 3;
			
			if(Page == 10)
				endQuestionFourPageFour = 3;
			
			if(Page == 11)
				endQuestionFourPageFive = 3;
			
			if(Page == 12)
				endQuestionFourPageSix = 3;

			
			
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(fourCheckFour.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 0)
				introQuestionFour = 2;
			
			if(Page == 1)
				questionFourPageOne = 2;
			
			if(Page == 2)
				questionFourPageTwo = 4;
			
			if(Page == 3)
				questionFourPageThree = 2;
			
			if(Page == 4)
				questionFourPageFour = 2;
			
			if(Page == 5)
				questionFourPageFive = 2;
					
			if(Page == 6)
				questionFourPageSix = 2;

			if(Page == 7)
				endQuestionFourPageOne = 2;
			
			if(Page == 8)
				endQuestionFourPageTwo = 4;
			
			if(Page == 9)
				endQuestionFourPageThree = 2;
			
			if(Page == 10)
				endQuestionFourPageFour = 2;
			
			if(Page == 11)
				endQuestionFourPageFive = 2;
			
			if(Page == 12)
				endQuestionFourPageSix = 2;
			
			
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			fourCheckOne.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(fourCheckFive.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 0)
				introQuestionFour = 1;
			
			if(Page == 1)
				questionFourPageOne = 1;
			
			if(Page == 2)
				questionFourPageTwo = 5;
			
			if(Page == 3)
				questionFourPageThree = 1;
			
			if(Page == 4)
				questionFourPageFour = 1;
			
			if(Page == 5)
				questionFourPageFive = 1;
			
			if(Page == 6)
				questionFourPageSix = 1;

			if(Page == 7)
				endQuestionFourPageOne = 1;
			
			if(Page == 8)
				endQuestionFourPageTwo = 5;
			
			if(Page == 9)
				endQuestionFourPageThree = 1;
			
			if(Page == 10)
				endQuestionFourPageFour = 1;
			
			if(Page == 11)
				endQuestionFourPageFive = 1;
			
			if(Page == 12)
				endQuestionFourPageSix = 1;
			
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}

		#endregion

	// Question 5

		#region Question5

		if(fiveCheckOne.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 0)
				introQuestionFive = 1;
			
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

			if(Page == 7)
				endQuestionFivePageOne = 5;
			
			if(Page == 8)
				endQuestionFivePageTwo = 5;
			
			if(Page == 9)
				endQuestionFivePageThree = 5;
			
			if(Page == 10)
				endQuestionFivePageFour = 5;
			
			if(Page == 11)
				endQuestionFivePageFive = 5;
			
			if(Page == 12)
				endQuestionFivePageSix = 5;
			
			fiveCheckTwo.GetComponent<Toggle>().isOn = false;
			fiveCheckThree.GetComponent<Toggle>().isOn = false;
			fiveCheckFour.GetComponent<Toggle>().isOn = false;
			fiveCheckFive.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(fiveCheckTwo.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 0)
				introQuestionFive = 2;
			
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

			if(Page == 7)
				endQuestionFivePageOne = 4;
			
			if(Page == 8)
				endQuestionFivePageTwo = 4;
			
			if(Page == 9)
				endQuestionFivePageThree = 4;
			
			if(Page == 10)
				endQuestionFivePageFour = 4;
			
			if(Page == 11)
				endQuestionFivePageFive = 4;
			
			if(Page == 12)
				endQuestionFivePageSix = 4;
			
			
			fiveCheckFive.GetComponent<Toggle>().isOn = false;
			fiveCheckThree.GetComponent<Toggle>().isOn = false;
			fiveCheckFour.GetComponent<Toggle>().isOn = false;
			fiveCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(fiveCheckThree.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 0)
				introQuestionFive = 3;
			
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

			if(Page == 7)
				endQuestionFivePageOne = 3;
			
			if(Page == 8)
				endQuestionFivePageTwo = 3;
			
			if(Page == 9)
				endQuestionFivePageThree = 3;
			
			if(Page == 10)
				endQuestionFivePageFour = 3;
			
			if(Page == 11)
				endQuestionFivePageFive = 3;
			
			if(Page == 12)
				endQuestionFivePageSix = 3;
			
			
			fiveCheckTwo.GetComponent<Toggle>().isOn = false;
			fiveCheckFive.GetComponent<Toggle>().isOn = false;
			fiveCheckFour.GetComponent<Toggle>().isOn = false;
			fiveCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(fiveCheckFour.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 0)
				introQuestionFive = 4;
			
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

			if(Page == 7)
				endQuestionFivePageOne = 2;
			
			if(Page == 8)
				endQuestionFivePageTwo = 2;
			
			if(Page == 9)
				endQuestionFivePageThree = 2;
			
			if(Page == 10)
				endQuestionFivePageFour = 2;
			
			if(Page == 11)
				endQuestionFivePageFive = 2;
			
			if(Page == 12)
				endQuestionFivePageSix = 2;
			
			
			fiveCheckTwo.GetComponent<Toggle>().isOn = false;
			fiveCheckThree.GetComponent<Toggle>().isOn = false;
			fiveCheckFive.GetComponent<Toggle>().isOn = false;
			fiveCheckOne.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(fiveCheckFive.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 0)
				introQuestionFive = 5;
			
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

			if(Page == 7)
				endQuestionFivePageOne = 1;
			
			if(Page == 8)
				endQuestionFivePageTwo = 1;
			
			if(Page == 9)
				endQuestionFivePageThree = 1;
			
			if(Page == 10)
				endQuestionFivePageFour = 1;
			
			if(Page == 11)
				endQuestionFivePageFive = 1;
			
			if(Page == 12)
				endQuestionFivePageSix = 1;
			
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

		if(locked == false) {

			if(Page == 0) {
				
				Page = 1;
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

			}else if(Page == 1) {

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

			}else if(Page == 6) {
			
				Page = 7;
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
				
			}else if(Page == 7) {
				
				Page = 8;
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
				
			}else if(Page == 8) {
				
				Page = 9;
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
				
			}else if(Page == 9) {
				
				Page = 10;
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
				
			}else if(Page == 10) {
				
				Page = 11;
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
			
			}else if(Page == 11) {
				
				Page = 12;
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
		}
	#endregion
}


public void QuestionsDone () {
	
		if(locked == false) {

			if(!System.IO.Directory.Exists(path + "/TestData"))
				System.IO.Directory.CreateDirectory(path + "/TestData");

			if(!System.IO.Directory.Exists(path + "/TestData/Pre-Test"))
				System.IO.Directory.CreateDirectory(path + "/TestData/Pre-Test");

			if(!System.IO.Directory.Exists(path + "/TestData/Mid-Test"))
				System.IO.Directory.CreateDirectory(path + "/TestData/Mid-Test");

			if(!System.IO.Directory.Exists(path + "/TestData/Post-Test"))
				System.IO.Directory.CreateDirectory(path + "/TestData/Post-Test");

		



			do{
			
				preNumber++;
			
			} while (System.IO.File.Exists(path + "/TestData/Pre-Test/PersonalQuestionnaire" + preNumber + ".txt"));


			System.IO.File.WriteAllText( path + "/TestData/Pre-Test/PersonalQuestionnaire" + preNumber + ".txt", 
			                            "Name: " + introQuestionName + "   Age: " + introQuestionAge + "   Gender: " + introQuestionGender + "   I often spend a lot of time playing games: " + introQuestionOne +
			                            "   Answers to intro questions: " + introQuestionTwo + " " + introQuestionThree + " " + introQuestionFour + " " + introQuestionFive);


			do{
				
				Number++;
				
			} while (System.IO.File.Exists(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying" + Number + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Mid-Test/QuestionnaireWhilePlaying" + Number + ".txt", 
			                            questionOnePageOne + " " + questionTwoPageOne + " " + questionThreePageOne + " " + questionFourPageOne + " " + questionFivePageOne + " " +
			                            questionOnePageTwo + " " + questionTwoPageTwo + " " + questionThreePageTwo + " " + questionFourPageTwo + " " + questionFivePageTwo + " " +
			                            questionOnePageThree + " " + questionTwoPageThree + " " + questionThreePageThree + " " + questionFourPageThree + " " + questionFivePageThree + " " +
			                            questionOnePageFour + " " + questionTwoPageFour + " " + questionThreePageFour + " " + questionFourPageFour + " " + questionFivePageFour + " " +
			                            questionOnePageFive + " " + questionTwoPageFive + " " + questionThreePageFive + " " + questionFourPageFive + " " + questionFivePageFive + " " +
			                            questionOnePageSix + " " + questionTwoPageSix + " " + questionThreePageSix + " " + questionFourPageSix + " " + questionFivePageSix);


			do{
				
				postNumber++;
				
			} while (System.IO.File.Exists(path + "/TestData/Post-Test/QuestionnaireAfterPlaying" + postNumber + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Post-Test/QuestionnaireAfterPlaying" + postNumber + ".txt", 
			                            endQuestionOnePageOne + " " + endQuestionTwoPageOne + " " + endQuestionThreePageOne + " " + endQuestionFourPageOne + " " + endQuestionFivePageOne + " " +
			                            endQuestionOnePageTwo + " " + endQuestionTwoPageTwo + " " + endQuestionThreePageTwo + " " + endQuestionFourPageTwo + " " + endQuestionFivePageTwo + " " +
			                            endQuestionOnePageThree + " " + endQuestionTwoPageThree + " " + endQuestionThreePageThree + " " + endQuestionFourPageThree + " " + endQuestionFivePageThree + " " +
			                            endQuestionOnePageFour + " " + endQuestionTwoPageFour + " " + endQuestionThreePageFour + " " + endQuestionFourPageFour + " " + endQuestionFivePageFour + " " +
			                            endQuestionOnePageFive + " " + endQuestionTwoPageFive + " " + endQuestionThreePageFive + " " + endQuestionFourPageFive + " " + endQuestionFivePageFive + " " +
			                            endQuestionOnePageSix + " " + endQuestionTwoPageSix + " " + endQuestionThreePageSix + " " + endQuestionFourPageSix + " " + endQuestionFivePageSix);
			
			Application.Quit();

		
		}
	}




}
