using UnityEngine;
using System.Collections;

public class TestObject : MonoBehaviour {

	//Camera
	public GameObject CamControl;

	public GameObject Branch;


	// Player

	GameObject Player;
	Transform PlayerPos;

	// Use this for initialization
	void Start () {
	
		Player = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {
	


		/*
		Control CamSwitch =  CamControl.GetComponent<Control>();
		CamSwitch.MovieSwitch();

		TestBrancheSystem movieTime = Branch.GetComponent<TestBrancheSystem>();
		movieTime.Speak();
		*/

	}

	void OnMouseDown()
	{

		Player.GetComponent<Player>().target = transform;
		
		
	}
}
