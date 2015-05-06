using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture2D cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 clickSpot = Vector2.zero;

	public GameObject loadScreen;

	public GameObject vidPlayer;
	public Transform vidPos;


	void Start () {
		
		Cursor.visible = true;
		Cursor.SetCursor(cursorTexture, clickSpot, cursorMode);
		Instantiate(vidPlayer,vidPos.position,vidPos.rotation);

	}


	void Update () {

		if(Application.isLoadingLevel) {
			
			loadScreen.SetActive(true);
			
		} else {
			
			loadScreen.SetActive(false);
			
		}



	}

	public void ChangeToScene (string nameOfScene) {
		AsyncOperation load = Application.LoadLevelAsync(nameOfScene);
	}
	public void Exit () {
		Application.Quit();
	}







}