using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActThreeBranch : MonoBehaviour {

	// Pause
	bool pause = false;
	
	//Camera
	public GameObject CamControl;
	bool MovieMode = false;
	
	
	// UI
	public GameObject UI;
	public Text ButtonOne;
	public Text ButtonTwo;
	public Text ButtonThree;
	
	
	
	
	// Branche Choices
	
	bool ChoiceOne = false;
	bool ChoiceTwo = false;
	bool ChoiceThree = false;
	
	
	
	
	
	
	// Clips Avalible
	
	MovieTexture movie;
	
	//Intro	
	public MovieTexture IntroMovie;
	
	//Speak
	public MovieTexture SpeakMovie;
	
	//Choice
	public MovieTexture MovieOne;
	public MovieTexture MovieTwo;
	public MovieTexture MovieThree;
	
	
	
	
	
	// Use this for initialization
	void Start ()
	{
		movie = IntroMovie;
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		GetComponent<AudioSource>().clip = movie.audioClip;
		movie.Play();
		GetComponent<AudioSource>().Play();

		Text textOne = ButtonOne.GetComponent<Text>();
		textOne.text = "Hello";
		
		Text textTwo = ButtonTwo.GetComponent<Text>();
		textTwo.text = "Bye";
		
		Text textThree = ButtonThree.GetComponent<Text>();
		textThree.text = "Well";

		UI.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
		Control CamSwitch =  CamControl.GetComponent<Control>();
		
		if(!movie.isPlaying && !pause && !MovieMode) {
			
			CamSwitch.GameSwitch();
		}
		
		if(!movie.isPlaying && !pause && MovieMode) {
			
			UI.SetActive(true);
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
	
	
	public void Speak () {
		
		movie = SpeakMovie;
		MovieMode = true;
		pause = false;
		
		
		
		
		UI.SetActive(false);
		
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		GetComponent<AudioSource>().clip = movie.audioClip;
		movie.Play();
		GetComponent<AudioSource>().Play();
	}
	
	
	
	
	public void ClipOne() {
		
		movie = MovieOne;
		
		
		
		
		UI.SetActive(false);
		
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		GetComponent<AudioSource>().clip = movie.audioClip;
		movie.Play();
		GetComponent<AudioSource>().Play();
	}
	
	
	public void ClipTwo() {
		
		movie = MovieTwo;
		
		
		
		UI.SetActive(false);
		
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		GetComponent<AudioSource>().clip = movie.audioClip;
		movie.Play();
		GetComponent<AudioSource>().Play();
	}
	
	
	public void ClipThree() {
		
		movie = MovieThree;
		
		
		
		UI.SetActive(false);
		
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		GetComponent<AudioSource>().clip = movie.audioClip;
		movie.Play();
		GetComponent<AudioSource>().Play();
	}
	
}