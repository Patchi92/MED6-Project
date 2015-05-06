using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IntroMenu : MonoBehaviour {


	MovieTexture movie;
	public MovieTexture IntroMovie;

	public GameObject UI;
	public GameObject VidPlay;

	bool donePlaying;

	// Use this for initialization
	void Start () {
	
		Cursor.visible = false;
		donePlaying = false;

		UI = GameObject.FindWithTag("UI");
		UI.SetActive(false);


		movie = IntroMovie;
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		GetComponent<AudioSource>().clip = movie.audioClip;






	}
	
	// Update is called once per frame
	void Update () {



	


	
		if(movie.isReadyToPlay && donePlaying == false) {
			movie.Stop();
			movie.Play();
			GetComponent<AudioSource>().Play();
			donePlaying = true;

		}




		if(!movie.isPlaying && donePlaying == true) {

			Cursor.visible = true;
			UI.SetActive(true);
			VidPlay.SetActive(false);
		}

	

	}

	

}
