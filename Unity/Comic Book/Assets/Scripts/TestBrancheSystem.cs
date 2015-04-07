using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestBrancheSystem : MonoBehaviour {
	
	// Pause
	bool pause = false;
	

	//Camera
	public GameObject CamControl;
	
	
	// UI
	public GameObject UI;
	public Text ButtonOne;
	public Text ButtonTwo;
	
	//Button
	public GameObject hideButton;
	
	
	
	// Branche Choices
	
	bool Intro = true;
	bool DelTwoA = false;
	bool DelTwoAA = false;
	bool DelTwoAB = false;
	bool DelTwoAAA = false;
	bool DelTwoAAB = false;
	bool DelTwoABA = false;
	bool DelTwoABB = false;
	bool DelThree = false;
	bool DelThreeA = false;
	bool DelThreeB = false;
	
	
	
	
	
	
	// Clips Avalible
	
	MovieTexture movie;
	
	//Intro	
	public MovieTexture IntroMovie;

	
	//Choice
	public MovieTexture MovieOne;
	public MovieTexture MovieTwo;
	public MovieTexture MovieThree;
	public MovieTexture MovieFour;
	public MovieTexture MovieFive;
	public MovieTexture MovieSix;
	public MovieTexture MovieSeven;
	public MovieTexture MovieEight;
	public MovieTexture MovieNine;
	public MovieTexture MovieTen;
	
	
	
	
	
	
	// Use this for initialization
	void Start ()
	{
		movie = IntroMovie;
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
			CamSwitch.GameSwitch();
		}
		
		if(movie.isPlaying && !pause) {
			CamSwitch.MovieSwitch();
		}







		hideButton.SetActive(false);

		
		if(!movie.isPlaying && !pause) {
			

			if(!IntroMovie.isPlaying && Intro) {

				Text textOne = ButtonOne.GetComponent<Text>();
				textOne.text = "Køkken";
				
				Text textTwo = ButtonTwo.GetComponent<Text>();
				textTwo.text = "Stue";

				UI.SetActive(true);

			}

			if(!MovieOne.isPlaying && DelTwoA) {
				
				Text textOne = ButtonOne.GetComponent<Text>();
				textOne.text = "Brød";
				
				Text textTwo = ButtonTwo.GetComponent<Text>();
				textTwo.text = "Kiks";
				
				UI.SetActive(true);
				Intro = false;
			}

			if(!MovieTwo.isPlaying && DelThree) {
				
				Text textOne = ButtonOne.GetComponent<Text>();
				textOne.text = "Kig Ud";
				
				Text textTwo = ButtonTwo.GetComponent<Text>();
				textTwo.text = "Tag En Lur";
				
				UI.SetActive(true);
				Intro =false;
			}

			if(!MovieThree.isPlaying && DelTwoAA) {
				
				Text textOne = ButtonOne.GetComponent<Text>();
				textOne.text = "Stue";
				
				Text textTwo = ButtonTwo.GetComponent<Text>();
				textTwo.text = "Soveværelse";
				
				UI.SetActive(true);
				DelTwoA = false;
			}

			if(!MovieFour.isPlaying && DelTwoAB) {
				
				Text textOne = ButtonOne.GetComponent<Text>();
				textOne.text = "Stue";
				
				Text textTwo = ButtonTwo.GetComponent<Text>();
				textTwo.text = "Soveværelse";
				
				UI.SetActive(true);
				DelTwoA = false;
			}

			if(!MovieFive.isPlaying && DelTwoAAA) {
				
				Text textOne = ButtonOne.GetComponent<Text>();
				textOne.text = "Retry";
				
				Text textTwo = ButtonTwo.GetComponent<Text>();
				textTwo.text = "Quit";
				
				UI.SetActive(true);
				DelTwoAA = false;
			}

			if(!MovieSix.isPlaying && DelTwoAAB) {
				
				Text textOne = ButtonOne.GetComponent<Text>();
				textOne.text = "Retry";
				
				Text textTwo = ButtonTwo.GetComponent<Text>();
				textTwo.text = "Quit";
				
				UI.SetActive(true);
				DelTwoAA = false;
			}

			if(!MovieSeven.isPlaying && DelTwoABA) {
				
				Text textOne = ButtonOne.GetComponent<Text>();
				textOne.text = "Retry";
				
				Text textTwo = ButtonTwo.GetComponent<Text>();
				textTwo.text = "Quit";
				
				UI.SetActive(true);
				DelTwoAB = false;
			}

			if(!MovieEight.isPlaying && DelTwoABB) {
				
				Text textOne = ButtonOne.GetComponent<Text>();
				textOne.text = "Retry";
				
				Text textTwo = ButtonTwo.GetComponent<Text>();
				textTwo.text = "Quit";
				
				UI.SetActive(true);
				DelTwoAB = false;
			}

			if(!MovieNine.isPlaying && DelThreeA) {
				
				Text textOne = ButtonOne.GetComponent<Text>();
				textOne.text = "Retry";
				
				Text textTwo = ButtonTwo.GetComponent<Text>();
				textTwo.text = "Quit";
				
				UI.SetActive(true);
				DelThree = false;
			}

			if(!MovieTen.isPlaying && DelThreeB) {
				
				Text textOne = ButtonOne.GetComponent<Text>();
				textOne.text = "Retry";
				
				Text textTwo = ButtonTwo.GetComponent<Text>();
				textTwo.text = "Quit";
				
				UI.SetActive(true);
				DelThree = false;
			}


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
		
		if(Intro) {
			
			movie = MovieOne;
			
			DelTwoA = true;
			pause = false;
		}
		
		if(DelTwoA && !Intro) {
			
			movie = MovieThree;
			
			DelTwoAA = true;
			pause = false;

		}
		
		if(DelThree && !Intro) {
			
			movie = MovieNine;

			DelThreeA = true;
			pause = false;

		}
		
		if(DelTwoAA && !DelTwoA) {
			
			movie = MovieFive;

			DelTwoAAA = true;
			pause = false;

		}
		
		if(DelTwoAB && !DelTwoA) {
			
			movie = MovieSeven;

			DelTwoABA = true;
			pause = false;

		}
		
		if(DelTwoAAA && !DelTwoAA) {
			
			Application.LoadLevel("Main Menu");
			

		}
		
		if(DelTwoAAB  && !DelTwoAA) {
			
			Application.LoadLevel("Main Menu");
			

		}
		
		if(DelTwoABA && !DelTwoAB) {
			
			Application.LoadLevel("Main Menu");
			
		
		}
		
		if(DelTwoABB && !DelTwoAB) {
			
			Application.LoadLevel("Main Menu");
			

		}
		
		if(DelThreeA && !DelThree) {
			
			Application.LoadLevel("Main Menu");
			

		}
		
		if(DelThreeB && !DelThree) {
			
			Application.LoadLevel("Main Menu");
			

		}
		
		
		
		
		UI.SetActive(false);
		
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		GetComponent<AudioSource>().clip = movie.audioClip;
		movie.Play();
		GetComponent<AudioSource>().Play();
	}
	
	
	public void ClipTwo() {
		
		if(Intro) {
			
			movie = MovieTwo;
			
			DelThree = true;
			pause = false;
		}
		
		if(DelTwoA && !Intro) {
			
			movie = MovieFour;
			
			DelTwoAB = true;
			pause = false;
			
		}
		
		if(DelThree  && !Intro) {
			
			movie = MovieTen;
			
			DelThreeB = true;
			pause = false;
			
		}
		
		if(DelTwoAA  && !DelTwoA) {
			
			movie = MovieSix;
			
			DelTwoAAB = true;
			pause = false;
			
		}
		
		if(DelTwoAB && !DelTwoA) {
			
			movie = MovieEight;
			
			DelTwoABB = true;
			pause = false;
			
		}
		
		if(DelTwoAAA && !DelTwoAA) {
			
			Application.Quit();
			
			
		}
		
		if(DelTwoAAB && !DelTwoAA) {
			
			Application.Quit();
			
			
		}
		
		if(DelTwoABA && !DelTwoAB) {
			
			Application.Quit();
			
			
		}
		
		if(DelTwoABB && !DelTwoAB) {
			
			Application.Quit();
			
			
		}
		
		if(DelThreeA && !DelThree) {
			
			Application.Quit();
			
			
		}
		
		if(DelThreeB && !DelThree) {
			
			Application.Quit();
			
			
		}
		
		
		UI.SetActive(false);
		
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		GetComponent<AudioSource>().clip = movie.audioClip;
		movie.Play();
		GetComponent<AudioSource>().Play();
	}

	public void Speak() {


	}
	
	
	
	
}