using UnityEngine;
using System.Collections;

public class TestBrancheSystem : MonoBehaviour {

	// Pause
	bool pause = false;
	
	//Camera
	public GameObject CamControl;
	bool GameMode = false;

	// UI
	public GameObject UI;

	

	// Branche Choices
	
	//Act 1
		
		//Intro
	bool actOneChoiceOne = false;
	bool actOneChoiceTwo = false;

		//Choice from
	bool actOneChoiceThree = false;
	bool actOneChoiceFour = false;

		//Choice from
	bool actOneChoiceFive = false;
	bool actOneChoiceSix = false;





	
	
	//Act 2 Scenario 1

		//Intro
	bool actTwosOneChoiceOne = false;
	bool actTwosOneChoiceTwo = false;
	bool actTwosOneChoiceThree = false;

		//Choice from
	bool actTwosOneChoiceFour = false;
	bool actTwosOneChoiceFive = false;
	bool actTwosOneChoiceSix = false;
		
		//Choice from
	bool actTwosOneChoiceSeven = false;
	bool actTwosOneChoiceEight = false;
	bool actTwosOneChoiceNine = false;

		//Choice from
	bool actTwosOneChoiceTen = false;
	bool actTwosOneChoiceEleven = false;
	bool actTwosOneChoiceTwelve = false;





	
	//Act 2 Scenario 2
	
	//Intro
	bool actTwosTwoChoiceOne = false;
	bool actTwosTwoChoiceTwo = false;
	bool actTwosTwoChoiceThree = false;
	
	//Choice from
	bool actTwosTwoChoiceFour = false;
	bool actTwosTwoChoiceFive = false;
	bool actTwosTwoChoiceSix = false;
	
	//Choice from
	bool actTwosTwoChoiceSeven = false;
	bool actTwosTwoChoiceEight = false;
	bool actTwosTwoChoiceNine = false;
	
	//Choice from
	bool actTwosTwoChoiceTen = false;
	bool actTwosTwoChoiceEleven = false;
	bool actTwosTwoChoiceTwelve = false;
	




	//Act 2 Scenario 3

	//Intro
	bool actTwosThreeChoiceOne = false;
	bool actTwosThreeChoiceTwo = false;
	bool actTwosThreeChoiceThree = false;
	
	//Choice from
	bool actTwosThreeChoiceFour = false;
	bool actTwosThreeChoiceFive = false;
	bool actTwosThreeChoiceSix = false;
	
	//Choice from
	bool actTwosThreeChoiceSeven = false;
	bool actTwosThreeChoiceEight = false;
	bool actTwosThreeChoiceNine = false;
	
	//Choice from
	bool actTwosThreeChoiceTen = false;
	bool actTwosThreeChoiceEleven = false;
	bool actTwosThreeChoiceTwelve = false;





	//Act 3 Scenario 1

	//Intro
	bool actThreesOneChoiceOne = false;
	bool actThreesOneChoiceTwo = false;
	bool actThreesOneChoiceThree = false;
	
	//Choice from
	bool actThreesOneChoiceFour = false;
	bool actThreesOneChoiceFive = false;
	bool actThreesOneChoiceSix = false;
	
	//Choice from
	bool actThreesOneChoiceSeven = false;
	bool actThreesOneChoiceEight = false;
	bool actThreesOneChoiceNine = false;
	
	//Choice from
	bool actThreesOneChoiceTen = false;
	bool actThreesOneChoiceEleven = false;
	bool actThreesOneChoiceTwelve = false;




	//Act 3 Scenario 2

	//Intro
	bool actThreesTwoChoiceOne = false;
	bool actThreesTwoChoiceTwo = false;
	bool actThreesTwoChoiceThree = false;
	
	//Choice from
	bool actThreesTwoChoiceFour = false;
	bool actThreesTwoChoiceFive = false;
	bool actThreesTwoChoiceSix = false;
	
	//Choice from
	bool actThreesTwoChoiceSeven = false;
	bool actThreesTwoChoiceEight = false;
	bool actThreesTwoChoiceNine = false;
	
	//Choice from
	bool actThreesTwoChoiceTen = false;
	bool actThreesTwoChoiceEleven = false;
	bool actThreesTwoChoiceTwelve = false;




	//Act 3 Scenario 3

	//Intro
	bool actThreesThreeChoiceOne = false;
	bool actThreesThreeChoiceTwo = false;
	bool actThreesThreeChoiceThree = false;
	
	//Choice from
	bool actThreesThreeChoiceFour = false;
	bool actThreesThreeChoiceFive = false;
	bool actThreesThreeChoiceSix = false;
	
	//Choice from
	bool actThreesThreeChoiceSeven = false;
	bool actThreesThreeChoiceEight = false;
	bool actThreesThreeChoiceNine = false;
	
	//Choice from
	bool actThreesThreeChoiceTen = false;
	bool actThreesThreeChoiceEleven = false;
	bool actThreesThreeChoiceTwelve = false;



	//The End
	bool endChoiceOne = false;
	bool endChoiceTwo = false;
	bool endChoiceThree = false;

	
	// Clips Avalible
	
	MovieTexture movie;
	
	//Intro	
	public MovieTexture sIntroMovieOne;
	
	//Scenario 1
	public MovieTexture sOneMovieOne;
	public MovieTexture sOneMovieTwo;
	public MovieTexture sOneMovieThree;
	public MovieTexture sOneMovieFour;
	public MovieTexture sOneMovieFive;
	public MovieTexture sOneMovieSix;

	
	
	//Scenario 2
	public MovieTexture sTwoMovieOne;
	public MovieTexture sTwoMovieTwo;
	public MovieTexture sTwoMovieThree;
	public MovieTexture sTwoMovieFour;
	public MovieTexture sTwoMovieFive;
	public MovieTexture sTwoMovieSix;
	public MovieTexture sTwoMovieSeven;
	
	
	
	//Scenario 3
	public MovieTexture sThreeMovieOne;
	public MovieTexture sThreeMovieTwo;
	public MovieTexture sThreeMovieThree;
	public MovieTexture sThreeMovieFour;
	public MovieTexture sThreeMovieFive;
	public MovieTexture sThreeMovieSix;
	public MovieTexture sThreeMovieSeven;
	
	
	//End
	public MovieTexture sEndMovieOne;
	public MovieTexture sEndMovieTwo;
	public MovieTexture sEndMovieThree;
	
	
	
	
	
	
	// Use this for initialization
	void Start ()
	{
		movie = sIntroMovieOne;
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		GetComponent<AudioSource>().clip = movie.audioClip;
		movie.Play();
		GetComponent<AudioSource>().Play();

		UI.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
		Control CamSwitch =  CamControl.GetComponent<Control>();
		
		if(!movie.isPlaying && !pause) {

			UI.SetActive(true);
		}
		
		if(movie.isPlaying && !pause) {
			CamSwitch.MovieSwitch();
		}

		if(GameMode == true) {
			UI.SetActive(false);
			CamSwitch.GameSwitch();
		}




	}



	void OnMouseDown()
	{
		
		
		if(!pause)
		{
			Debug.Log("Pause");
			movie.Pause();
			GetComponent<AudioSource>().Pause();
			pause = true;
		} else {
			Debug.Log("Unpause");
			movie.Play();
			GetComponent<AudioSource>().Play();
			pause = false;
		}

		
	}


	public void ClipOne() {
		movie = sOneMovieOne;



		UI.SetActive(false);

		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		GetComponent<AudioSource>().clip = movie.audioClip;
		movie.Play();
		GetComponent<AudioSource>().Play();
	}


	public void ClipTwo() {
		movie = sOneMovieOne;
		
		
		
		UI.SetActive(false);
		
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		GetComponent<AudioSource>().clip = movie.audioClip;
		movie.Play();
		GetComponent<AudioSource>().Play();
	}


	public void ClipThree() {
		movie = sOneMovieOne;
		
		
		
		UI.SetActive(false);
		
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		GetComponent<AudioSource>().clip = movie.audioClip;
		movie.Play();
		GetComponent<AudioSource>().Play();
	}
	
}