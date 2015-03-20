using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	public GameObject movieCam;
	public GameObject gameCam;



	// Use this for initialization
	void Start () {
	
		gameCam.SetActive(false);
		movieCam.SetActive(true);
		

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void GameSwitch () {
		gameCam.SetActive(true);
		movieCam.SetActive(false);
	}

	public void MovieSwitch () {
		gameCam.SetActive(false);
		movieCam.SetActive(true);
	}
}
