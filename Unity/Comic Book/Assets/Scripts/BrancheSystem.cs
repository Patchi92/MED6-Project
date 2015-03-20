using UnityEngine;
using System.Collections;

public class BrancheSystem : MonoBehaviour {

	// Pause
	bool pause = false;

	//Camera
	public GameObject CamControl;

	// Branche Choices
		
		//Scenario 1
			
		bool sOneChoiceOne = true;
		bool sOneChoiceTwo = false;
		bool sOneChoiceThree = false;
		bool sOneChoiceFour = false;
		bool sOneChoiceFive = false;
		bool sOneChoiceSix = false;
		bool sOneChoiceSeven = false;




		//Scenario 2

		bool sTwoChoiceOne = false;
		bool sTwoChoiceTwo = false;
		bool sTwoChoiceThree = false;
		bool sTwoChoiceFour = false;
		bool sTwoChoiceFive = false;
		bool sTwoChoiceSix = false;
		bool sTwoChoiceSeven = false;


		//Scenario 3

		bool sThreeChoiceOne = false;
		bool sThreeChoiceTwo = false;
		bool sThreeChoiceThree = false;
		bool sThreeChoiceFour = false;
		bool sThreeChoiceFive = false;
		bool sThreeChoiceSix = false;
		bool sThreeChoiceSeven = false;



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
		public MovieTexture sOneMovieSeven;
		
		
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
	}
	
	// Update is called once per frame
	void Update () {

		Control CamSwitch =  CamControl.GetComponent<Control>();

		if(!movie.isPlaying && !pause) {
			CamSwitch.GameSwitch();
		}

		if(movie.isPlaying && !pause) {
			CamSwitch.MovieSwitch();
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

}
