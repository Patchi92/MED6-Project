using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.iOS;

public class EvuControl : MonoBehaviour {

	bool oneOne;
	bool oneTwo;
	bool oneThree;
	string One;

	bool twoOne;
	bool twoTwo;
	bool twoThree;

	bool threeOne;
	bool threeTwo;
	bool threeThree;

	// Use this for initialization
	void Start () {


		//create Folder
		if (!System.IO.Directory.Exists ("C:/Data/")) {
			
			System.IO.Directory.CreateDirectory ("C:/Data/");
		}






	
	}
	
	// Update is called once per frame
	void Update () {


		if(oneOne == true) {

			One = "Du har valgt bla";

		}

	
	}

	public void test () {
		oneOne = true;
		oneTwo = false;
		oneThree = false;
	}


	void OnApplicationQuit() {
		System.IO.File.WriteAllText("C:/Data/TestToUs.txt", One + "    " + One );
	}
}
