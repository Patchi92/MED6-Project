using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {



	void Start () {
		

		Cursor.visible = true;
	
	}


	void Update () {



	}

	public void ChangeToScene (string nameOfScene) {
		Application.LoadLevel(nameOfScene);
	}
	public void Exit () {
		Application.Quit();
	}







}