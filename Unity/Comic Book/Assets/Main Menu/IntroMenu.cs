using UnityEngine;
using System.Collections;

public class IntroMenu : MonoBehaviour {


	MovieTexture movie;
	public MovieTexture IntroMovie;

	public GameObject UI;
	public GameObject VidPlay;

	// Use this for initialization
	void Start () {
	
	
		movie = IntroMovie;
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		GetComponent<AudioSource>().clip = movie.audioClip;
		movie.Play();
		GetComponent<AudioSource>().Play();

		UI.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
	
		if(!movie.isPlaying) {
			
			UI.SetActive(true);
			VidPlay.SetActive(false);
		}

	}
}
