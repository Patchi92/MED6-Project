using UnityEngine;
using System.Collections;


public class EndBranch : MonoBehaviour {

	// Pause
	bool pause = false;
	
	//Camera
	public GameObject CamControl;

	
	
	// UI
	public GameObject UI;
	
	
	
	
	// Branche Choices
	
	bool ChoiceOne = false;
	bool ChoiceTwo = false;
	bool ChoiceThree = false;
	
	
	
	
	
	
	// Clips Avalible
	
	MovieTexture movie;
	
	//Intro	
	public MovieTexture IntroMovie;

	
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
