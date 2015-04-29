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

	public GameObject infoQuestion;
	public GameObject infoText;

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


	// CD Questions

	int cdQuestionOne;
	int cdQuestionTwo;
	int cdQuestionThree;


	// Use this for initialization
	void Start () {

		path = Application.dataPath;


		stopSign.SetActive(false);







	
	}
	
	// Update is called once per frame
	void Update () {

		#region Questions

		/*
		if((oneCheckOne.GetComponent<Toggle>().isOn == true || oneCheckTwo.GetComponent<Toggle>().isOn == true || oneCheckThree.GetComponent<Toggle>().isOn == true || oneCheckFour.GetComponent<Toggle>().isOn == true || oneCheckFive) && (oneCheckOne.GetComponent<Toggle>().isOn == true || oneCheckTwo.GetComponent<Toggle>().isOn == true || oneCheckThree.GetComponent<Toggle>().isOn == true || oneCheckFour.GetComponent<Toggle>().isOn == true || oneCheckFive.GetComponent<Toggle>().isOn == true) && (oneCheckOne.GetComponent<Toggle>().isOn == true || oneCheckTwo.GetComponent<Toggle>().isOn == true || oneCheckThree.GetComponent<Toggle>().isOn == true || oneCheckFour.GetComponent<Toggle>().isOn == true || oneCheckFive.GetComponent<Toggle>().isOn == true)&& (oneCheckOne.GetComponent<Toggle>().isOn == true || oneCheckTwo.GetComponent<Toggle>().isOn == true || oneCheckThree.GetComponent<Toggle>().isOn == true || oneCheckFour.GetComponent<Toggle>().isOn == true || oneCheckFive.GetComponent<Toggle>().isOn == true) && (oneCheckOne.GetComponent<Toggle>().isOn == true || oneCheckTwo.GetComponent<Toggle>().isOn == true || oneCheckThree.GetComponent<Toggle>().isOn == true || oneCheckFour.GetComponent<Toggle>().isOn == true || oneCheckFive.GetComponent<Toggle>().isOn == true)) {

			locked = false;
		
		}else{
		
			locked = true;

		}
		*/

		locked = false;

		if(Page == 0) {


			infoQuestion.GetComponent<Text>().text = "Narrative Engagement Questionnaire";

			infoText.GetComponent<Text>().text = "This questionnaire will be used for academic research purposes only, and no personal information (besides age and gender) will be asked.By pressing “next” you agree to help us by participating in this test, and allow us to use the information provided for our research. Your answers will be completely anonymous.\n" +
				"\n" +
				"We would kindly like to ask you to answer each question as honestly as possible - We want your honest opinion!\n" +
				"\n" +
				"The questions will be represented in the following way:\n" +
				"\n" +
				"“I have read the terms and agreements”\n" +
				"\n" +
				"Strongly Agree - Agree - Neither Agree nor Disagree - Disagree - Strongly Disagree\n" +
				"\n" +
				"Depending on how much you agree to the statement, you mark the appropriate field. If you want to change your answer, you must first unmark your previous answer.\n" +
				"\n" +
				"Thank you so much for helping us, by participating in this test!";


			infoQuestion.SetActive(true);
			infoText.SetActive(true);


			oneQuestion.SetActive(false);
			twoQuestion.SetActive(false);
			threeQuestion.SetActive(false);
			fourQuestion.SetActive(false);
			fiveQuestion.SetActive(false);

			nextButton.SetActive(true);
			doneButton.SetActive(false);
			Gender.SetActive(false);
			Female.SetActive(false);
			Male.SetActive(false);
			Name.SetActive(false);
			Age.SetActive(false);

			oneCheckOne.SetActive(false);
			oneCheckTwo.SetActive(false);
			oneCheckThree.SetActive(false);
			oneCheckFour.SetActive(false);
			oneCheckFive.SetActive(false);
			
			twoCheckOne.SetActive(false);
			twoCheckTwo.SetActive(false);
			twoCheckThree.SetActive(false);
			twoCheckFour.SetActive(false);
			twoCheckFive.SetActive(false);
			
			threeCheckOne.SetActive(false);
			threeCheckTwo.SetActive(false);
			threeCheckThree.SetActive(false);
			threeCheckFour.SetActive(false);
			threeCheckFive.SetActive(false);
			
			fourCheckOne.SetActive(false);
			fourCheckTwo.SetActive(false);
			fourCheckThree.SetActive(false);
			fourCheckFour.SetActive(false);
			fourCheckFive.SetActive(false);;
			
			fiveCheckOne.SetActive(false);
			fiveCheckTwo.SetActive(false);
			fiveCheckThree.SetActive(false);
			fiveCheckFour.SetActive(false);
			fiveCheckFive.SetActive(false);
		}



		if(Page == 1) {
			oneQuestion.GetComponent<Text>().text = "On average, how many hours do spend playing video games each week?";
			twoQuestion.GetComponent<Text>().text = "I really want to start playing the game!";
			threeQuestion.GetComponent<Text>().text = "I tend to like games where narrative plays an important role.";
			fourQuestion.GetComponent<Text>().text = "I think narrative is essential for my game play experience.";
			fiveQuestion.GetComponent<Text>().text = "I don't like games that mainly focuses on telling a story.";


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

			infoQuestion.SetActive(false);
			infoText.SetActive(false);

			Gender.SetActive(true);
			Female.SetActive(true);
			Male.SetActive(true);
			Name.SetActive(true);
			Age.SetActive(true);

			oneQuestion.SetActive(true);
			twoQuestion.SetActive(true);
			threeQuestion.SetActive(true);
			fourQuestion.SetActive(true);
			fiveQuestion.SetActive(true);

			oneCheckOne.SetActive(true);
			oneCheckTwo.SetActive(true);
			oneCheckThree.SetActive(true);
			oneCheckFour.SetActive(true);
			oneCheckFive.SetActive(true);
			
			twoCheckOne.SetActive(true);
			twoCheckTwo.SetActive(true);
			twoCheckThree.SetActive(true);
			twoCheckFour.SetActive(true);
			twoCheckFive.SetActive(true);
			
			threeCheckOne.SetActive(true);
			threeCheckTwo.SetActive(true);
			threeCheckThree.SetActive(true);
			threeCheckFour.SetActive(true);
			threeCheckFive.SetActive(true);
			
			fourCheckOne.SetActive(true);
			fourCheckTwo.SetActive(true);
			fourCheckThree.SetActive(true);
			fourCheckFour.SetActive(true);
			fourCheckFive.SetActive(true);;
			
			fiveCheckOne.SetActive(true);
			fiveCheckTwo.SetActive(true);
			fiveCheckThree.SetActive(true);
			fiveCheckFour.SetActive(true);
			fiveCheckFive.SetActive(true);
		}

		if(Page == 2) {

			stopSign.SetActive(true);

			threeQuestion.GetComponent<Text>().text = "I really want to continue playing the game!";


			oneText.GetComponent<Text>().text = "Strongly Agree";
			twoText.GetComponent<Text>().text = "Agree";
			threeText.GetComponent<Text>().text = "Neither Agree nor Disagree";
			fourText.GetComponent<Text>().text = "Disagree";
			fiveText.GetComponent<Text>().text = "Strongly Disagree";

			Gender.SetActive(false);
			Female.SetActive(false);
			Male.SetActive(false);
			Name.SetActive(false);
			Age.SetActive(false);

			oneQuestion.SetActive(false);
			twoQuestion.SetActive(false);
			threeQuestion.SetActive(true);
			fourQuestion.SetActive(false);
			fiveQuestion.SetActive(false);
			
			oneCheckOne.SetActive(false);
			oneCheckTwo.SetActive(false);
			oneCheckThree.SetActive(false);
			oneCheckFour.SetActive(false);
			oneCheckFive.SetActive(false);
			
			twoCheckOne.SetActive(false);
			twoCheckTwo.SetActive(false);
			twoCheckThree.SetActive(false);
			twoCheckFour.SetActive(false);
			twoCheckFive.SetActive(false);
			
			threeCheckOne.SetActive(true);
			threeCheckTwo.SetActive(true);
			threeCheckThree.SetActive(true);
			threeCheckFour.SetActive(true);
			threeCheckFive.SetActive(true);
			
			fourCheckOne.SetActive(false);
			fourCheckTwo.SetActive(false);
			fourCheckThree.SetActive(false);
			fourCheckFour.SetActive(false);
			fourCheckFive.SetActive(false);;
			
			fiveCheckOne.SetActive(false);
			fiveCheckTwo.SetActive(false);
			fiveCheckThree.SetActive(false);
			fiveCheckFour.SetActive(false);
			fiveCheckFive.SetActive(false);
		}

		if(Page == 3) {

			stopSign.SetActive(false);

			oneQuestion.GetComponent<Text>().text = "While playing, I lost track of time.";
			twoQuestion.GetComponent<Text>().text = "I find myself unable to concentrate on the game.";
			threeQuestion.GetComponent<Text>().text = "While playing, I often find myself thinking about things unrelated to the game.";
			fourQuestion.GetComponent<Text>().text = "I forgot about my own issues, while I was playing the game.";
			fiveQuestion.GetComponent<Text>().text = "During the game, I noticed a lot of small details, such as the color of the main character's clothes, for example.";


			oneQuestion.SetActive(true);
			twoQuestion.SetActive(true);
			threeQuestion.SetActive(true);
			fourQuestion.SetActive(true);
			fiveQuestion.SetActive(true);
			
			oneCheckOne.SetActive(true);
			oneCheckTwo.SetActive(true);
			oneCheckThree.SetActive(true);
			oneCheckFour.SetActive(true);
			oneCheckFive.SetActive(true);
			
			twoCheckOne.SetActive(true);
			twoCheckTwo.SetActive(true);
			twoCheckThree.SetActive(true);
			twoCheckFour.SetActive(true);
			twoCheckFive.SetActive(true);
			
			threeCheckOne.SetActive(true);
			threeCheckTwo.SetActive(true);
			threeCheckThree.SetActive(true);
			threeCheckFour.SetActive(true);
			threeCheckFive.SetActive(true);
			
			fourCheckOne.SetActive(true);
			fourCheckTwo.SetActive(true);
			fourCheckThree.SetActive(true);
			fourCheckFour.SetActive(true);
			fourCheckFive.SetActive(true);;
			
			fiveCheckOne.SetActive(true);
			fiveCheckTwo.SetActive(true);
			fiveCheckThree.SetActive(true);
			fiveCheckFour.SetActive(true);
			fiveCheckFive.SetActive(true);

		}

		if(Page == 4) {


			oneQuestion.GetComponent<Text>().text = "During the game, I found myself paying more attention to my surroundings, than to the game.";
			twoQuestion.GetComponent<Text>().text = "I feel like I am a part of the story.";
			threeQuestion.GetComponent<Text>().text = "I am eager to find out what happens next in the game.";
			fourQuestion.GetComponent<Text>().text = "I feel like the narrative have created a new world, that (while playing) seems closer than the real world.";
			fiveQuestion.GetComponent<Text>().text = "I want to know how the story ends!";


		}

		if(Page == 5) {
			oneQuestion.GetComponent<Text>().text = "I think the story is very logical and convincing.";
			twoQuestion.GetComponent<Text>().text = "I understand why the characters are acting the way they are.";
			threeQuestion.GetComponent<Text>().text = "I feel like I have an idea of what might happen next.";
			fourQuestion.GetComponent<Text>().text = "I feel the plot is very predictable and uninspiring.";
			fiveQuestion.GetComponent<Text>().text = "I am not sure that I understand the characters.";


		}

		if(Page == 6) {
			oneQuestion.GetComponent<Text>().text = "I was able to understand the events of the story in a way similar to how the characters understood them.";
			twoQuestion.GetComponent<Text>().text = "I could easily imagine myself in the situation of some of the characters.";
			threeQuestion.GetComponent<Text>().text = "I felt sorry for some of the characters in the story.";
			fourQuestion.GetComponent<Text>().text = "At some points, I felt like I shared the emotions of the characters.";
			fiveQuestion.GetComponent<Text>().text = "The story have no emotional affect on me.";


		}

		if(Page == 7) {
			oneQuestion.GetComponent<Text>().text = "I try to explore the world as much as possible.";
			twoQuestion.GetComponent<Text>().text = "If I had the chance, I would change some of the choices I made.";
			threeQuestion.GetComponent<Text>().text = "I don't feel like the choices really have an effect on the story.";
			fourQuestion.GetComponent<Text>().text = "I try to find alternative ways to complete the game.";
			fiveQuestion.GetComponent<Text>().text = "I feel the game is very static, leaving little to no room for exploration and experimentation.";


		}



		if(Page == 8) {
			oneQuestion.GetComponent<Text>().text = "I feel like my choices doesn't matter to the outcome of the story.";
			twoQuestion.GetComponent<Text>().text = "I don't understand the goal(s) of the characters.";
			threeQuestion.GetComponent<Text>().text = "I feel that the game world is rich and interesting.";
			fourQuestion.GetComponent<Text>().text = "I am bored by the story.";
			fiveQuestion.GetComponent<Text>().text = "I am a bit too stressed to really enjoy the game.";



		}

		if(Page == 9) {
			
			stopSign.SetActive(true);
			
			threeQuestion.GetComponent<Text>().text = "I am eager to continue playing the game!";
			

			
			Gender.SetActive(false);
			Female.SetActive(false);
			Male.SetActive(false);
			Name.SetActive(false);
			Age.SetActive(false);
			
			oneQuestion.SetActive(false);
			twoQuestion.SetActive(false);
			threeQuestion.SetActive(true);
			fourQuestion.SetActive(false);
			fiveQuestion.SetActive(false);
			
			oneCheckOne.SetActive(false);
			oneCheckTwo.SetActive(false);
			oneCheckThree.SetActive(false);
			oneCheckFour.SetActive(false);
			oneCheckFive.SetActive(false);
			
			twoCheckOne.SetActive(false);
			twoCheckTwo.SetActive(false);
			twoCheckThree.SetActive(false);
			twoCheckFour.SetActive(false);
			twoCheckFive.SetActive(false);
			
			threeCheckOne.SetActive(true);
			threeCheckTwo.SetActive(true);
			threeCheckThree.SetActive(true);
			threeCheckFour.SetActive(true);
			threeCheckFive.SetActive(true);
			
			fourCheckOne.SetActive(false);
			fourCheckTwo.SetActive(false);
			fourCheckThree.SetActive(false);
			fourCheckFour.SetActive(false);
			fourCheckFive.SetActive(false);;
			
			fiveCheckOne.SetActive(false);
			fiveCheckTwo.SetActive(false);
			fiveCheckThree.SetActive(false);
			fiveCheckFour.SetActive(false);
			fiveCheckFive.SetActive(false);
		}


		if(Page == 10) {

			stopSign.SetActive(false);

			oneQuestion.GetComponent<Text>().text = "While playing, I lost track of time.";
			twoQuestion.GetComponent<Text>().text = "I find myself unable to concentrate on the game.";
			threeQuestion.GetComponent<Text>().text = "While playing, I often find myself thinking about things unrelated to the game.";
			fourQuestion.GetComponent<Text>().text = "I forgot about my own issues, while I was playing the game.";
			fiveQuestion.GetComponent<Text>().text = "During the game, I noticed a lot of small details, such as the color of the main character's clothes, for example.";

			oneQuestion.SetActive(true);
			twoQuestion.SetActive(true);
			threeQuestion.SetActive(true);
			fourQuestion.SetActive(true);
			fiveQuestion.SetActive(true);
			
			oneCheckOne.SetActive(true);
			oneCheckTwo.SetActive(true);
			oneCheckThree.SetActive(true);
			oneCheckFour.SetActive(true);
			oneCheckFive.SetActive(true);
			
			twoCheckOne.SetActive(true);
			twoCheckTwo.SetActive(true);
			twoCheckThree.SetActive(true);
			twoCheckFour.SetActive(true);
			twoCheckFive.SetActive(true);
			
			threeCheckOne.SetActive(true);
			threeCheckTwo.SetActive(true);
			threeCheckThree.SetActive(true);
			threeCheckFour.SetActive(true);
			threeCheckFive.SetActive(true);
			
			fourCheckOne.SetActive(true);
			fourCheckTwo.SetActive(true);
			fourCheckThree.SetActive(true);
			fourCheckFour.SetActive(true);
			fourCheckFive.SetActive(true);;
			
			fiveCheckOne.SetActive(true);
			fiveCheckTwo.SetActive(true);
			fiveCheckThree.SetActive(true);
			fiveCheckFour.SetActive(true);
			fiveCheckFive.SetActive(true);
			

		}
		
		if(Page == 11) {

			oneQuestion.GetComponent<Text>().text = "During the game, I found myself paying more attention to my surroundings, than to the game.";
			twoQuestion.GetComponent<Text>().text = "I feel like I am a part of the story.";
			threeQuestion.GetComponent<Text>().text = "I am eager to find out what happens next in the game.";
			fourQuestion.GetComponent<Text>().text = "I feel like the narrative have created a new world, that (while playing) seems closer than the real world.";
			fiveQuestion.GetComponent<Text>().text = "I want to know how the story ends!";
			
			
		}
		
		if(Page == 12) {
			oneQuestion.GetComponent<Text>().text = "I think the story is very logical and convincing.";
			twoQuestion.GetComponent<Text>().text = "I understand why the characters are acting the way they are.";
			threeQuestion.GetComponent<Text>().text = "I feel like I have an idea of what might happen next.";
			fourQuestion.GetComponent<Text>().text = "I feel the plot is very predictable and uninspiring.";
			fiveQuestion.GetComponent<Text>().text = "I am not sure that I understand the characters.";
			
			
		}
		
		if(Page == 13) {
			oneQuestion.GetComponent<Text>().text = "I was able to understand the events of the story in a way similar to how the characters understood them.";
			twoQuestion.GetComponent<Text>().text = "I could easily imagine myself in the situation of some of the characters.";
			threeQuestion.GetComponent<Text>().text = "I felt sorry for some of the characters in the story.";
			fourQuestion.GetComponent<Text>().text = "At some points, I felt like I shared the emotions of the characters.";
			fiveQuestion.GetComponent<Text>().text = "The story have no emotional affect on me.";
			
			
		}
		
		if(Page == 14) {
			oneQuestion.GetComponent<Text>().text = "I try to explore the world as much as possible.";
			twoQuestion.GetComponent<Text>().text = "If I had the chance, I would change some of the choices I made.";
			threeQuestion.GetComponent<Text>().text = "I don't feel like the choices really have an effect on the story.";
			fourQuestion.GetComponent<Text>().text = "I try to find alternative ways to complete the game.";
			fiveQuestion.GetComponent<Text>().text = "I feel the game is very static, leaving little to no room for exploration and experimentation.";
			
			
		}
		
		
		
		if(Page == 15) {
			oneQuestion.GetComponent<Text>().text = "I feel like my choices doesn't matter to the outcome of the story.";
			twoQuestion.GetComponent<Text>().text = "I don't understand the goal(s) of the characters.";
			threeQuestion.GetComponent<Text>().text = "I feel that the game world is rich and interesting.";
			fourQuestion.GetComponent<Text>().text = "I am bored by the story.";
			fiveQuestion.GetComponent<Text>().text = "I am a bit too stressed to really enjoy the game.";

			nextButton.SetActive(false);
			doneButton.SetActive(true);
		}


		#endregion


	// Question 1

		#region Question1

		if(oneCheckOne.GetComponent<Toggle>().isOn == true) {

			if(Page == 1)
				introQuestionOne = "0-3 Hours";

			if(Page == 3)
				questionOnePageOne = 5;

			if(Page == 4)
				questionOnePageTwo = 1;
			
			if(Page == 5)
				questionOnePageThree = 5;

			if(Page == 6)
				questionOnePageFour = 5;

			if(Page == 7)
				questionOnePageFive = 5;

			if(Page == 8)
				questionOnePageSix = 1;

			if(Page == 10)
				endQuestionOnePageOne = 5;
			
			if(Page == 11)
				endQuestionOnePageTwo = 1;
			
			if(Page == 12)
				endQuestionOnePageThree = 5;
			
			if(Page == 13)
				endQuestionOnePageFour = 5;
			
			if(Page == 14)
				endQuestionOnePageFive = 5;
			
			if(Page == 15)
				endQuestionOnePageSix = 1;

			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;

		}

		if(oneCheckTwo.GetComponent<Toggle>().isOn == true) {

			if(Page == 1)
				introQuestionOne = "4-6 Hours";

			if(Page == 3)
				questionOnePageOne = 4;
			
			if(Page == 4)
				questionOnePageTwo = 2;
			
			if(Page == 5)
				questionOnePageThree = 4;
			
			if(Page == 6)
				questionOnePageFour = 4;
			
			if(Page == 7)
				questionOnePageFive = 4;
			
			if(Page == 8)
				questionOnePageSix = 2;

			if(Page == 10)
				endQuestionOnePageOne = 4;
			
			if(Page == 11)
				endQuestionOnePageTwo = 2;
			
			if(Page == 12)
				endQuestionOnePageThree = 4;
			
			if(Page == 13)
				endQuestionOnePageFour = 4;
			
			if(Page == 14)
				endQuestionOnePageFive = 4;
			
			if(Page == 15)
				endQuestionOnePageSix = 2;
			
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckOne.GetComponent<Toggle>().isOn = false;

			
		}

		if(oneCheckThree.GetComponent<Toggle>().isOn == true) {


			if(Page == 1)
				introQuestionOne = "7-10 Hours";

			if(Page == 3)
				questionOnePageOne = 3;
			
			if(Page == 4)
				questionOnePageTwo = 3;
			
			if(Page == 5)
				questionOnePageThree = 3;
			
			if(Page == 6)
				questionOnePageFour = 3;
			
			if(Page == 7)
				questionOnePageFive = 3;
			
			if(Page == 8)
				questionOnePageSix = 3;

			if(Page == 10)
				endQuestionOnePageOne = 3;
			
			if(Page == 11)
				endQuestionOnePageTwo = 3;
			
			if(Page == 12)
				endQuestionOnePageThree = 3;
			
			if(Page == 13)
				endQuestionOnePageFour = 3;
			
			if(Page == 14)
				endQuestionOnePageFive = 3;
			
			if(Page == 15)
				endQuestionOnePageSix = 3;

			
			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckOne.GetComponent<Toggle>().isOn = false;

			
		}

		if(oneCheckFour.GetComponent<Toggle>().isOn == true) {

			if(Page == 1)
				introQuestionOne = "11-14 Hours";

			if(Page == 3)
				questionOnePageOne = 2;
			
			if(Page == 4)
				questionOnePageTwo = 4;
			
			if(Page == 5)
				questionOnePageThree = 2;
			
			if(Page == 6)
				questionOnePageFour = 2;
			
			if(Page == 7)
				questionOnePageFive = 2;
			
			if(Page == 8)
				questionOnePageSix = 4;

			if(Page == 10)
				endQuestionOnePageOne = 2;
			
			if(Page == 11)
				endQuestionOnePageTwo = 4;
			
			if(Page == 12)
				endQuestionOnePageThree = 2;
			
			if(Page == 13)
				endQuestionOnePageFour = 2;
			
			if(Page == 14)
				endQuestionOnePageFive = 2;
			
			if(Page == 15)
				endQuestionOnePageSix = 4;
			
			
			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			oneCheckOne.GetComponent<Toggle>().isOn = false;

		}

		if(oneCheckFive.GetComponent<Toggle>().isOn == true) {


			if(Page == 1)
				introQuestionOne = "15+ Hours";

			if(Page == 3)
				questionOnePageOne = 1;
			
			if(Page == 4)
				questionOnePageTwo = 5;
			
			if(Page == 5)
				questionOnePageThree = 1;
			
			if(Page == 6)
				questionOnePageFour = 1;
			
			if(Page == 7)
				questionOnePageFive = 1;
			
			if(Page == 8)
				questionOnePageSix = 5;

			if(Page == 10)
				endQuestionOnePageOne = 1;
			
			if(Page == 11)
				endQuestionOnePageTwo = 5;
			
			if(Page == 12)
				endQuestionOnePageThree = 1;
			
			if(Page == 13)
				endQuestionOnePageFour = 1;
			
			if(Page == 14)
				endQuestionOnePageFive = 1;
			
			if(Page == 15)
				endQuestionOnePageSix = 5;

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
				cdQuestionOne = 5;
			
			if(Page == 3)
				questionTwoPageOne = 1;
			
			if(Page == 4)
				questionTwoPageTwo = 5;
			
			if(Page == 5)
				questionTwoPageThree = 5;
			
			if(Page == 6)
				questionTwoPageFour = 5;
			
			if(Page == 7)
				questionTwoPageFive = 5;
			
			if(Page == 8)
				questionTwoPageSix = 1;

			if(Page == 10)
				endQuestionTwoPageOne = 1;
			
			if(Page == 11)
				endQuestionTwoPageTwo = 5;
			
			if(Page == 12)
				endQuestionTwoPageThree = 5;
			
			if(Page == 13)
				endQuestionTwoPageFour = 5;
			
			if(Page == 14)
				endQuestionTwoPageFive = 5;
			
			if(Page == 15)
				endQuestionTwoPageSix = 1;
			
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(twoCheckTwo.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 1)
				cdQuestionOne = 4;
			
			if(Page == 3)
				questionTwoPageOne = 2;
			
			if(Page == 4)
				questionTwoPageTwo = 4;
			
			if(Page == 5)
				questionTwoPageThree = 4;
			
			if(Page == 6)
				questionTwoPageFour = 4;
			
			if(Page == 7)
				questionTwoPageFive = 4;
			
			if(Page == 8)
				questionTwoPageSix = 2;

			if(Page == 10)
				endQuestionTwoPageOne = 2;
			
			if(Page == 11)
				endQuestionTwoPageTwo = 4;
			
			if(Page == 12)
				endQuestionTwoPageThree = 4;
			
			if(Page == 13)
				endQuestionTwoPageFour = 4;
			
			if(Page == 14)
				endQuestionTwoPageFive = 4;
			
			if(Page == 15)
				endQuestionTwoPageSix = 2;
			
			
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(twoCheckThree.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 1)
				cdQuestionOne = 3;
			
			if(Page == 3)
				questionTwoPageOne = 3;
			
			if(Page == 4)
				questionTwoPageTwo = 3;
			
			if(Page == 5)
				questionTwoPageThree = 3;
			
			if(Page == 6)
				questionTwoPageFour = 3;
			
			if(Page == 7)
				questionTwoPageFive = 3;
			
			if(Page == 8)
				questionTwoPageSix = 3;

			if(Page == 10)
				endQuestionTwoPageOne = 3;
			
			if(Page == 11)
				endQuestionTwoPageTwo = 3;
			
			if(Page == 12)
				endQuestionTwoPageThree = 3;
			
			if(Page == 13)
				endQuestionTwoPageFour = 3;
			
			if(Page == 14)
				endQuestionTwoPageFive = 3;
			
			if(Page == 15)
				endQuestionTwoPageSix = 3;
			
			
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(twoCheckFour.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 1)
				cdQuestionOne = 2;
			
			if(Page == 3)
				questionTwoPageOne = 4;
			
			if(Page == 4)
				questionTwoPageTwo = 2;
			
			if(Page == 5)
				questionTwoPageThree = 2;
			
			if(Page == 6)
				questionTwoPageFour = 2;
			
			if(Page == 7)
				questionTwoPageFive = 2;
			
			if(Page == 8)
				questionTwoPageSix = 4;

			if(Page == 10)
				endQuestionTwoPageOne = 4;
			
			if(Page == 11)
				endQuestionTwoPageTwo = 2;
			
			if(Page == 12)
				endQuestionTwoPageThree = 2;
			
			if(Page == 13)
				endQuestionTwoPageFour = 2;
			
			if(Page == 14)
				endQuestionTwoPageFive = 2;
			
			if(Page == 15)
				endQuestionTwoPageSix = 4;
			
			
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(twoCheckFive.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 1)
				cdQuestionOne = 1;

			if(Page == 3)
				questionTwoPageOne = 5;
			
			if(Page == 4)
				questionTwoPageTwo = 1;
			
			if(Page == 5)
				questionTwoPageThree = 1;
			
			if(Page == 6)
				questionTwoPageFour = 1;
			
			if(Page == 7)
				questionTwoPageFive = 1;
			
			if(Page == 8)
				questionTwoPageSix = 5;

			if(Page == 10)
				endQuestionTwoPageOne = 5;
			
			if(Page == 11)
				endQuestionTwoPageTwo = 1;
			
			if(Page == 12)
				endQuestionTwoPageThree = 1;
			
			if(Page == 13)
				endQuestionTwoPageFour = 1;
			
			if(Page == 14)
				endQuestionTwoPageFive = 1;
			
			if(Page == 15)
				endQuestionTwoPageSix = 5;
			
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
				introQuestionThree = 5;

			if(Page == 2)
				cdQuestionTwo = 5;
			
			if(Page == 3)
				questionThreePageOne = 1;
			
			if(Page == 4)
				questionThreePageTwo = 5;
			
			if(Page == 5)
				questionThreePageThree = 5;
			
			if(Page == 6)
				questionThreePageFour = 5;
			
			if(Page == 7)
				questionThreePageFive = 1;
			
			if(Page == 8)
				questionThreePageSix = 5;

			if(Page == 9)
				cdQuestionThree = 5;

			if(Page == 10)
				endQuestionThreePageOne = 1;
			
			if(Page == 11)
				endQuestionThreePageTwo = 5;
			
			if(Page == 12)
				endQuestionThreePageThree = 5;
			
			if(Page == 13)
				endQuestionThreePageFour = 5;
			
			if(Page == 14)
				endQuestionThreePageFive = 1;
			
			if(Page == 15)
				endQuestionThreePageSix = 5;
			
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(threeCheckTwo.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 1)
				introQuestionThree = 4;

			if(Page == 2)
				cdQuestionTwo = 4;

			if(Page == 3)
				questionThreePageOne = 2;
			
			if(Page == 4)
				questionThreePageTwo = 4;
			
			if(Page == 5)
				questionThreePageThree = 4;
			
			if(Page == 6)
				questionThreePageFour = 4;
			
			if(Page == 7)
				questionThreePageFive = 2;
			
			if(Page == 8)
				questionThreePageSix = 4;

			if(Page == 9)
				cdQuestionThree = 4;

			if(Page == 10)
				endQuestionThreePageOne = 2;
			
			if(Page == 11)
				endQuestionThreePageTwo = 4;
			
			if(Page == 12)
				endQuestionThreePageThree = 4;
			
			if(Page == 13)
				endQuestionThreePageFour = 4;
			
			if(Page == 14)
				endQuestionThreePageFive = 2;
			
			if(Page == 15)
				endQuestionThreePageSix = 4;
			
			
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(threeCheckThree.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 1)
				introQuestionThree = 3;

			if(Page == 2)
				cdQuestionTwo = 3;

			if(Page == 3)
				questionThreePageOne = 3;
			
			if(Page == 4)
				questionThreePageTwo = 3;
			
			if(Page == 5)
				questionThreePageThree = 3;
			
			if(Page == 6)
				questionThreePageFour = 3;
			
			if(Page == 7)
				questionThreePageFive = 3;
			
			if(Page == 8)
				questionThreePageSix = 3;

			if(Page == 9)
				cdQuestionThree = 3;

			if(Page == 10)
				endQuestionThreePageOne = 3;
			
			if(Page == 11)
				endQuestionThreePageTwo = 3;
			
			if(Page == 12)
				endQuestionThreePageThree = 3;
			
			if(Page == 13)
				endQuestionThreePageFour = 3;
			
			if(Page == 14)
				endQuestionThreePageFive = 3;
			
			if(Page == 15)
				endQuestionThreePageSix = 3;
			
			
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			threeCheckFour.GetComponent<Toggle>().isOn = false;
			threeCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(threeCheckFour.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 1)
				introQuestionThree = 2;

			if(Page == 2)
				cdQuestionTwo = 2;

			if(Page == 3)
				questionThreePageOne = 4;
			
			if(Page == 4)
				questionThreePageTwo = 2;
			
			if(Page == 5)
				questionThreePageThree = 2;
			
			if(Page == 6)
				questionThreePageFour = 2;
			
			if(Page == 7)
				questionThreePageFive = 4;
					
			if(Page == 8)
				questionThreePageSix = 2;

			if(Page == 9)
				cdQuestionThree = 2;

			if(Page == 10)
				endQuestionThreePageOne = 4;
			
			if(Page == 11)
				endQuestionThreePageTwo = 2;
			
			if(Page == 12)
				endQuestionThreePageThree = 2;
			
			if(Page == 13)
				endQuestionThreePageFour = 2;
			
			if(Page == 14)
				endQuestionThreePageFive = 4;
			
			if(Page == 15)
				endQuestionThreePageSix = 2;
			
			
			threeCheckTwo.GetComponent<Toggle>().isOn = false;
			threeCheckThree.GetComponent<Toggle>().isOn = false;
			threeCheckFive.GetComponent<Toggle>().isOn = false;
			threeCheckOne.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(threeCheckFive.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 1)
				introQuestionThree = 1;

			if(Page == 2)
				cdQuestionTwo = 1;

			if(Page == 3)
				questionThreePageOne = 5;
			
			if(Page == 4)
				questionThreePageTwo = 1;
			
			if(Page == 5)
				questionThreePageThree = 1;
			
			if(Page == 6)
				questionThreePageFour = 1;
			
			if(Page == 7)
				questionThreePageFive = 1;
			
			if(Page == 8)
				questionThreePageSix = 1;

			if(Page == 9)
				cdQuestionThree = 1;

			if(Page == 10)
				endQuestionThreePageOne = 5;
			
			if(Page == 11)
				endQuestionThreePageTwo = 1;
			
			if(Page == 12)
				endQuestionThreePageThree = 1;
			
			if(Page == 13)
				endQuestionThreePageFour = 1;
			
			if(Page == 14)
				endQuestionThreePageFive = 5;
			
			if(Page == 15)
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
			
			if(Page == 1)
				introQuestionFour = 5;
			
			if(Page == 3)
				questionFourPageOne = 5;
			
			if(Page == 4)
				questionFourPageTwo = 5;
			
			if(Page == 5)
				questionFourPageThree = 1;
			
			if(Page == 6)
				questionFourPageFour = 5;
			
			if(Page == 7)
				questionFourPageFive = 5;
			
			if(Page == 8)
				questionFourPageSix = 1;

			if(Page == 10)
				endQuestionFourPageOne = 5;
			
			if(Page == 11)
				endQuestionFourPageTwo = 5;
			
			if(Page == 12)
				endQuestionFourPageThree = 1;
			
			if(Page == 13)
				endQuestionFourPageFour = 5;
			
			if(Page == 14)
				endQuestionFourPageFive = 5;
			
			if(Page == 15)
				endQuestionFourPageSix = 1;
			
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(fourCheckTwo.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 1)
				introQuestionFour = 4;
			
			if(Page == 3)
				questionFourPageOne = 4;
			
			if(Page == 4)
				questionFourPageTwo = 4;
			
			if(Page == 5)
				questionFourPageThree = 2;
			
			if(Page == 6)
				questionFourPageFour = 4;
			
			if(Page == 7)
				questionFourPageFive = 4;
			
			if(Page == 8)
				questionFourPageSix = 2;

			if(Page == 10)
				endQuestionFourPageOne = 4;
			
			if(Page == 11)
				endQuestionFourPageTwo = 4;
			
			if(Page == 12)
				endQuestionFourPageThree = 2;
			
			if(Page == 13)
				endQuestionFourPageFour = 4;
			
			if(Page == 14)
				endQuestionFourPageFive = 4;
			
			if(Page == 15)
				endQuestionFourPageSix = 2;
			
			
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(fourCheckThree.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 1)
				introQuestionFour = 3;
			
			if(Page == 3)
				questionFourPageOne = 3;
			
			if(Page == 4)
				questionFourPageTwo = 3;
			
			if(Page == 5)
				questionFourPageThree = 3;
			
			if(Page == 6)
				questionFourPageFour = 3;
			
			if(Page == 7)
				questionFourPageFive = 3;
			
			if(Page == 8)
				questionFourPageSix = 3;

			if(Page == 10)
				endQuestionFourPageOne = 3;
			
			if(Page == 11)
				endQuestionFourPageTwo = 3;
			
			if(Page == 12)
				endQuestionFourPageThree = 3;
			
			if(Page == 13)
				endQuestionFourPageFour = 3;
			
			if(Page == 14)
				endQuestionFourPageFive = 3;
			
			if(Page == 15)
				endQuestionFourPageSix = 3;

			
			
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			fourCheckFour.GetComponent<Toggle>().isOn = false;
			fourCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(fourCheckFour.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 1)
				introQuestionFour = 2;
			
			if(Page == 3)
				questionFourPageOne = 2;
			
			if(Page == 4)
				questionFourPageTwo = 2;
			
			if(Page == 5)
				questionFourPageThree = 4;
			
			if(Page == 6)
				questionFourPageFour = 2;
			
			if(Page == 7)
				questionFourPageFive = 2;
					
			if(Page == 8)
				questionFourPageSix = 4;

			if(Page == 10)
				endQuestionFourPageOne = 2;
			
			if(Page == 11)
				endQuestionFourPageTwo = 2;
			
			if(Page == 12)
				endQuestionFourPageThree = 4;
			
			if(Page == 13)
				endQuestionFourPageFour = 2;
			
			if(Page == 14)
				endQuestionFourPageFive = 2;
			
			if(Page == 15)
				endQuestionFourPageSix = 4;
			
			
			fourCheckTwo.GetComponent<Toggle>().isOn = false;
			fourCheckThree.GetComponent<Toggle>().isOn = false;
			fourCheckFive.GetComponent<Toggle>().isOn = false;
			fourCheckOne.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(fourCheckFive.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 1)
				introQuestionFour = 1;
			
			if(Page == 3)
				questionFourPageOne = 1;
			
			if(Page == 4)
				questionFourPageTwo = 1;
			
			if(Page == 5)
				questionFourPageThree = 5;
			
			if(Page == 6)
				questionFourPageFour = 1;
			
			if(Page == 7)
				questionFourPageFive = 1;
			
			if(Page == 8)
				questionFourPageSix = 5;

			if(Page == 10)
				endQuestionFourPageOne = 1;
			
			if(Page == 11)
				endQuestionFourPageTwo = 1;
			
			if(Page == 12)
				endQuestionFourPageThree = 5;
			
			if(Page == 13)
				endQuestionFourPageFour = 1;
			
			if(Page == 14)
				endQuestionFourPageFive = 1;
			
			if(Page == 15)
				endQuestionFourPageSix = 5;
			
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
				introQuestionFive = 1;
			
			if(Page == 3)
				questionFivePageOne = 5;
			
			if(Page == 4)
				questionFivePageTwo = 5;
			
			if(Page == 5)
				questionFivePageThree = 1;
			
			if(Page == 6)
				questionFivePageFour = 1;
			
			if(Page == 7)
				questionFivePageFive = 1;
			
			if(Page == 8)
				questionFivePageSix = 1;

			if(Page == 10)
				endQuestionFivePageOne = 5;
			
			if(Page == 11)
				endQuestionFivePageTwo = 5;
			
			if(Page == 12)
				endQuestionFivePageThree = 1;
			
			if(Page == 13)
				endQuestionFivePageFour = 1;
			
			if(Page == 14)
				endQuestionFivePageFive = 1;
			
			if(Page == 15)
				endQuestionFivePageSix = 1;
			
			fiveCheckTwo.GetComponent<Toggle>().isOn = false;
			fiveCheckThree.GetComponent<Toggle>().isOn = false;
			fiveCheckFour.GetComponent<Toggle>().isOn = false;
			fiveCheckFive.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(fiveCheckTwo.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 1)
				introQuestionFive = 2;
			
			if(Page == 3)
				questionFivePageOne = 4;
			
			if(Page == 4)
				questionFivePageTwo = 4;
			
			if(Page == 5)
				questionFivePageThree = 2;
			
			if(Page == 6)
				questionFivePageFour = 2;
			
			if(Page == 7)
				questionFivePageFive = 2;
			
			if(Page == 8)
				questionFivePageSix = 2;

			if(Page == 10)
				endQuestionFivePageOne = 4;
			
			if(Page == 11)
				endQuestionFivePageTwo = 4;
			
			if(Page == 12)
				endQuestionFivePageThree = 2;
			
			if(Page == 13)
				endQuestionFivePageFour = 2;
			
			if(Page == 14)
				endQuestionFivePageFive = 2;
			
			if(Page == 15)
				endQuestionFivePageSix = 2;
			
			
			fiveCheckFive.GetComponent<Toggle>().isOn = false;
			fiveCheckThree.GetComponent<Toggle>().isOn = false;
			fiveCheckFour.GetComponent<Toggle>().isOn = false;
			fiveCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(fiveCheckThree.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 1)
				introQuestionFive = 3;
			
			if(Page == 3)
				questionFivePageOne = 3;
			
			if(Page == 4)
				questionFivePageTwo = 3;
			
			if(Page == 5)
				questionFivePageThree = 3;
			
			if(Page == 6)
				questionFivePageFour = 3;
			
			if(Page == 7)
				questionFivePageFive = 3;
			
			if(Page == 8)
				questionFivePageSix = 3;

			if(Page == 10)
				endQuestionFivePageOne = 3;
			
			if(Page == 11)
				endQuestionFivePageTwo = 3;
			
			if(Page == 12)
				endQuestionFivePageThree = 3;
			
			if(Page == 13)
				endQuestionFivePageFour = 3;
			
			if(Page == 14)
				endQuestionFivePageFive = 3;
			
			if(Page == 15)
				endQuestionFivePageSix = 3;
			
			
			fiveCheckTwo.GetComponent<Toggle>().isOn = false;
			fiveCheckFive.GetComponent<Toggle>().isOn = false;
			fiveCheckFour.GetComponent<Toggle>().isOn = false;
			fiveCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(fiveCheckFour.GetComponent<Toggle>().isOn == true) {
			
			if(Page == 1)
				introQuestionFive = 4;
			
			if(Page == 3)
				questionFivePageOne = 2;
			
			if(Page == 4)
				questionFivePageTwo = 2;
			
			if(Page == 5)
				questionFivePageThree = 4;
			
			if(Page == 6)
				questionFivePageFour = 4;
			
			if(Page == 7)
				questionFivePageFive = 4;
					
			if(Page == 8)
				questionFivePageSix = 4;

			if(Page == 10)
				endQuestionFivePageOne = 2;
			
			if(Page == 11)
				endQuestionFivePageTwo = 2;
			
			if(Page == 12)
				endQuestionFivePageThree = 4;
			
			if(Page == 13)
				endQuestionFivePageFour = 4;
			
			if(Page == 14)
				endQuestionFivePageFive = 4;
			
			if(Page == 15)
				endQuestionFivePageSix = 4;
			
			
			fiveCheckTwo.GetComponent<Toggle>().isOn = false;
			fiveCheckThree.GetComponent<Toggle>().isOn = false;
			fiveCheckFive.GetComponent<Toggle>().isOn = false;
			fiveCheckOne.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(fiveCheckFive.GetComponent<Toggle>().isOn == true) {
			
			
			if(Page == 1)
				introQuestionFive = 5;
			
			if(Page == 3)
				questionFivePageOne = 1;
			
			if(Page == 4)
				questionFivePageTwo = 1;
			
			if(Page == 5)
				questionFivePageThree = 5;
			
			if(Page == 6)
				questionFivePageFour = 5;
			
			if(Page == 7)
				questionFivePageFive = 5;
			
			if(Page == 8)
				questionFivePageSix = 5;

			if(Page == 10)
				endQuestionFivePageOne = 1;
			
			if(Page == 11)
				endQuestionFivePageTwo = 1;
			
			if(Page == 12)
				endQuestionFivePageThree = 5;
			
			if(Page == 13)
				endQuestionFivePageFour = 5;
			
			if(Page == 14)
				endQuestionFivePageFive = 5;
			
			if(Page == 15)
				endQuestionFivePageSix = 5;
			
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
				
			}else if(Page == 12) {
			
			Page = 13;
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
			
			}else if(Page == 13) {
				
				Page = 14;
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
				
			}else if(Page == 14) {
				
				Page = 15;
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

		

			// Part 1

			do{
			
				preNumber++;
			
			} while (System.IO.File.Exists(path + "/TestData/Pre-Test/Info" + preNumber + ".txt"));


			System.IO.File.WriteAllText( path + "/TestData/Pre-Test/Info" + preNumber + ".txt", 
			                            "Name: " + introQuestionName + "   Age: " + introQuestionAge + "   Gender: " + introQuestionGender + "   I often spend a lot of time playing games: " + introQuestionOne);

			preNumber = 0;

			do{
				
				preNumber++;
				
			} while (System.IO.File.Exists(path + "/TestData/Pre-Test/InfoQuestions" + preNumber + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Pre-Test/InfoQuestions" + preNumber + ".txt", 
			                             introQuestionThree + " " + introQuestionFour + " " + introQuestionFive);

			preNumber = 0;


			do{
				
				preNumber++;
				
			} while (System.IO.File.Exists(path + "/TestData/Pre-Test/InfoCD" + preNumber + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Pre-Test/InfoCD" + preNumber + ".txt", 
			                           cdQuestionOne + " " + cdQuestionTwo + " " + cdQuestionThree);
			



			// Part 2


			do{
				
				Number++;
				
			} while (System.IO.File.Exists(path + "/TestData/Mid-Test/MidAttFocus" + Number + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Mid-Test/MidAttFocus" + Number + ".txt", 
			                            questionOnePageOne + " " + questionTwoPageOne + " " + questionThreePageOne + " " + questionFourPageOne + " " + questionFivePageOne);

			Number = 0;

			do{
				
				Number++;
				
			} while (System.IO.File.Exists(path + "/TestData/Mid-Test/MidNarvPresence" + Number + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Mid-Test/MidNarvPresence" + Number + ".txt", 
			                            questionOnePageTwo + " " + questionTwoPageTwo + " " + questionThreePageTwo + " " + questionFourPageTwo + " " + questionFivePageTwo);
			Number = 0;
			
			do{
				
				Number++;
				
			} while (System.IO.File.Exists(path + "/TestData/Mid-Test/MidComprehensionOfNarv" + Number + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Mid-Test/MidComprehensionOfNarv" + Number + ".txt", 
			                            questionOnePageThree + " " + questionTwoPageThree + " " + questionThreePageThree + " " + questionFourPageThree + " " + questionFivePageThree);
			Number = 0;
			
			do{
				
				Number++;
				
			} while (System.IO.File.Exists(path + "/TestData/Mid-Test/MidEmotionalEngagementAndCharacterIdentification" + Number + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Mid-Test/MidEmotionalEngagementAndCharacterIdentification" + Number + ".txt", 
			                            questionOnePageFour + " " + questionTwoPageFour + " " + questionThreePageFour + " " + questionFourPageFour + " " + questionFivePageFour);
			Number = 0;
			
			do{
				
				Number++;
				
			} while (System.IO.File.Exists(path + "/TestData/Mid-Test/MidExperimentation" + Number + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Mid-Test/MidExperimentation" + Number + ".txt", 
			                            questionOnePageFive + " " + questionTwoPageFive + " " + questionThreePageFive + " " + questionFourPageFive + " " + questionFivePageFive);
			Number = 0;
			
			do{
				
				Number++;
				
			} while (System.IO.File.Exists(path + "/TestData/Mid-Test/MidDisemgagemant" + Number + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Mid-Test/MidDisemgagemant" + Number + ".txt", 
			                            questionOnePageSix + " " + questionTwoPageSix + " " + questionThreePageSix + " " + questionFourPageSix + " " + questionFivePageSix);


			




			// Part 3



			do{
				
				postNumber++;
				
			} while (System.IO.File.Exists(path + "/TestData/Post-Test/PostAttFocus" + postNumber + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Post-Test/PostAttFocus" + postNumber + ".txt", 
			                            endQuestionOnePageOne + " " + endQuestionTwoPageOne + " " + endQuestionThreePageOne + " " + endQuestionFourPageOne + " " + endQuestionFivePageOne);

			postNumber = 0;

			do{
				
				postNumber++;
				
			} while (System.IO.File.Exists(path + "/TestData/Post-Test/PostNarvPresence" + postNumber + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Post-Test/PostNarvPresence" + postNumber + ".txt", 
			                            endQuestionOnePageTwo + " " + endQuestionTwoPageTwo + " " + endQuestionThreePageTwo + " " + endQuestionFourPageTwo + " " + endQuestionFivePageTwo);

			postNumber = 0;

			do{
				
				postNumber++;
				
			} while (System.IO.File.Exists(path + "/TestData/Post-Test/PostComprehensionOfNarv" + postNumber + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Post-Test/PostComprehensionOfNarv" + postNumber + ".txt", 
			                            endQuestionOnePageThree + " " + endQuestionTwoPageThree + " " + endQuestionThreePageThree + " " + endQuestionFourPageThree + " " + endQuestionFivePageThree);
			
			postNumber = 0;

			do{
				
				postNumber++;
				
			} while (System.IO.File.Exists(path + "/TestData/Post-Test/PostEmotionalEngagementAndCharacterIdentification" + postNumber + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Post-Test/PostEmotionalEngagementAndCharacterIdentification" + postNumber + ".txt", 
			                            endQuestionOnePageFour + " " + endQuestionTwoPageFour + " " + endQuestionThreePageFour + " " + endQuestionFourPageFour + " " + endQuestionFivePageFour);
			
			postNumber = 0;

			do{
				
				postNumber++;
				
			} while (System.IO.File.Exists(path + "/TestData/Post-Test/PostExperimentation" + postNumber + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Post-Test/PostExperimentation" + postNumber + ".txt", 
			                            endQuestionOnePageFive + " " + endQuestionTwoPageFive + " " + endQuestionThreePageFive + " " + endQuestionFourPageFive + " " + endQuestionFivePageFive);
			
			postNumber = 0;

			do{
				
				postNumber++;
				
			} while (System.IO.File.Exists(path + "/TestData/Post-Test/PostDisemgagemant" + postNumber + ".txt"));
			
			
			System.IO.File.WriteAllText( path + "/TestData/Post-Test/PostDisemgagemant" + postNumber + ".txt", 
			                            endQuestionOnePageSix + " " + endQuestionTwoPageSix + " " + endQuestionThreePageSix + " " + endQuestionFourPageSix + " " + endQuestionFivePageSix);
			


			Application.Quit();

		
		}
	}




}
