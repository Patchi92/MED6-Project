using UnityEngine;
using System.Collections;

public class TestObject : MonoBehaviour {

	//Camera
	public GameObject CamControl;

	public GameObject Branch;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		
		Control CamSwitch =  CamControl.GetComponent<Control>();
		CamSwitch.MovieSwitch();

		IntroBranch movieTime = Branch.GetComponent<IntroBranch>();
		movieTime.Speak();

		
		
	}
}
