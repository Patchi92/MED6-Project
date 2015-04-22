using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.iOS;

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

	int One;

	public GameObject oneCheckOne;
	public GameObject oneCheckTwo;
	public GameObject oneCheckThree;
	public GameObject oneCheckFour;
	public GameObject oneCheckFive;

	int Two;

	public GameObject twoCheckOne;
	public GameObject twoCheckTwo;
	public GameObject twoCheckThree;
	public GameObject twoCheckFour;
	public GameObject twoCheckFive;

	int Three;
	
	public GameObject threeCheckOne;
	public GameObject threeCheckTwo;
	public GameObject threeCheckThree;
	public GameObject threeCheckFour;
	public GameObject threeCheckFive;


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

		#endregion Questions


	// Question 1

		#region Question1

		if(oneCheckOne.GetComponent<Toggle>().isOn == true) {



			One = 1;

			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;

		}

		if(oneCheckTwo.GetComponent<Toggle>().isOn == true) {



			One = 2;

			
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckOne.GetComponent<Toggle>().isOn = false;

			
		}

		if(oneCheckThree.GetComponent<Toggle>().isOn == true) {




			One = 3;

			
			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckOne.GetComponent<Toggle>().isOn = false;

			
		}

		if(oneCheckFour.GetComponent<Toggle>().isOn == true) {



			One = 4;

			
			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFive.GetComponent<Toggle>().isOn = false;
			oneCheckOne.GetComponent<Toggle>().isOn = false;

		}

		if(oneCheckFive.GetComponent<Toggle>().isOn == true) {




			One = 5;

			oneCheckTwo.GetComponent<Toggle>().isOn = false;
			oneCheckThree.GetComponent<Toggle>().isOn = false;
			oneCheckFour.GetComponent<Toggle>().isOn = false;
			oneCheckOne.GetComponent<Toggle>().isOn = false;

			
		}

		#endregion Question1
	




		// Question 2

		#region Question2
		
		if(twoCheckOne.GetComponent<Toggle>().isOn == true) {
			
			
			
			Two = 1;
			
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(twoCheckTwo.GetComponent<Toggle>().isOn == true) {
			
			
			
			Two = 2;
			
			
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(twoCheckThree.GetComponent<Toggle>().isOn == true) {
			
			
			
			
			Two = 3;
			
			
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		if(oneCheckFour.GetComponent<Toggle>().isOn == true) {
			
			
			
			Two = 4;
			
			
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFive.GetComponent<Toggle>().isOn = false;
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			
		}
		
		if(twoCheckFive.GetComponent<Toggle>().isOn == true) {
			
			
			
			
			Two = 5;
			
			twoCheckTwo.GetComponent<Toggle>().isOn = false;
			twoCheckThree.GetComponent<Toggle>().isOn = false;
			twoCheckFour.GetComponent<Toggle>().isOn = false;
			twoCheckOne.GetComponent<Toggle>().isOn = false;
			
			
		}
		
		
	

	#endregion Question2


}

	public void NextPage () {

		if(Page == 1)
			Page = 2;
		else if(Page == 2)
			Page = 3;
		else if(Page == 3)
			Page = 4;
		else if(Page == 4)
			Page = 5;
		else if(Page == 5)
			Page = 6;

	}


	public void QuestionsDone () {


		do{
				
			Number++;

		} while (System.IO.File.Exists(path + "/Questionnaire" + Number + ".txt"));


		System.IO.File.WriteAllText( path + "/Questionnaire" + Number + ".txt", One + " " + Two + " " + Three);


		
		Application.Quit();

	
		}




}
