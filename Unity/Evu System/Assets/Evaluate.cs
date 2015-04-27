using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Reflection;
public class Evaluate : MonoBehaviour {

	public GameObject midTest;
	public GameObject postTest;
	public GameObject preTest;





	string[] midMatrix;
	string[] postMatrix;
	string[] infoMatrix;

	string copyValue;

	string path;
	int preNumber = 0;
	int Number = 0;
	int postNumber = 0;

	int pre = 0;
	int mid = 0;
	int post = 0;


	// Use this for initialization
	void Start () {



		path = Application.dataPath;


		midMatrix = new string[100];
		postMatrix = new string[100];
		infoMatrix = new string[100];

		infoMatrix[0] = "No Data";
		infoMatrix[1] = "No Data";
		infoMatrix[2] = "No Data";
		infoMatrix[3] = "No Data";
		infoMatrix[4] = "No Data";
		infoMatrix[5] = "No Data";
		infoMatrix[6] = "No Data";
		infoMatrix[7] = "No Data";
		infoMatrix[8] = "No Data";
		infoMatrix[9] = "No Data";


		midMatrix[0] = "No Data";
		midMatrix[1] = "No Data";
		midMatrix[2] = "No Data";
		midMatrix[3] = "No Data";
		midMatrix[4] = "No Data";
		midMatrix[5] = "No Data";
		midMatrix[6] = "No Data";
		midMatrix[7] = "No Data";
		midMatrix[8] = "No Data";
		midMatrix[9] = "No Data";


		postMatrix[0] = "No Data";
		postMatrix[1] = "No Data";
		postMatrix[2] = "No Data";
		postMatrix[3] = "No Data";
		postMatrix[4] = "No Data";
		postMatrix[5] = "No Data";
		postMatrix[6] = "No Data";
		postMatrix[7] = "No Data";
		postMatrix[8] = "No Data";
		postMatrix[9] = "No Data";
	

	

	}
	
	// Update is called once per frame
	void Update () {
	

		


		preTest.GetComponent<Text>().text = infoMatrix[0].ToString() + "\n" + infoMatrix[1].ToString() + "\n" + infoMatrix[2].ToString() + "\n" + infoMatrix[3].ToString() + "\n" + infoMatrix[4].ToString() + "\n" + infoMatrix[5].ToString() + "\n" + infoMatrix[6].ToString() + "\n" + infoMatrix[7].ToString() + "\n" + infoMatrix[8].ToString() + "\n" + infoMatrix[9].ToString();
		
		midTest.GetComponent<Text>().text = midMatrix[0].ToString() + "\n" + midMatrix[1].ToString() + "\n" + midMatrix[2].ToString() + "\n" + midMatrix[3].ToString() + "\n" + midMatrix[4].ToString() + "\n" + midMatrix[5].ToString() + "\n" + midMatrix[6].ToString() + "\n" + midMatrix[7].ToString() + "\n" + midMatrix[8].ToString() + "\n" + midMatrix[9].ToString();
		
		postTest.GetComponent<Text>().text = postMatrix[0].ToString() + "\n" + postMatrix[1].ToString() + "\n" + postMatrix[2].ToString() + "\n" + postMatrix[3].ToString() + "\n" + postMatrix[4].ToString() + "\n" + postMatrix[5].ToString() + "\n" + postMatrix[6].ToString() + "\n" + postMatrix[7].ToString() + "\n" + postMatrix[8].ToString() + "\n" + postMatrix[9].ToString();
	
	}


	public void Evu () {

		/*
		do{
			
			preNumber++;
			infoMatrix[pre] = System.IO.File.ReadAllText(path + "/TestData/Pre-Test/PersonalQuestionnaire" + preNumber + ".txt");
			pre++;
			
		} while (System.IO.File.Exists(path + "/TestData/Pre-Test/PersonalQuestionnaire" + preNumber + ".txt"));
		
		
		
		
		
		do{
			
			Number++;
			midMatrix[mid] = System.IO.File.ReadAllText(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying" + Number + ".txt");
			mid++;
			
		} while (System.IO.File.Exists(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying" + Number + ".txt"));
		
		
		
		
		
		do{
			
			postNumber++;
			postMatrix[post] = System.IO.File.ReadAllText(path + "/TestData/Post-Test/QuestionnaireAfterPlaying" + postNumber + ".txt");
			post++;
			
		} while (System.IO.File.Exists(path + "/TestData/Post-Test/QuestionnaireAfterPlaying" + postNumber + ".txt"));
		
		*/
		
		if(System.IO.File.Exists(path + "/TestData/Pre-Test/PersonalQuestionnaire1.txt"))
			infoMatrix[0] = System.IO.File.ReadAllText(path + "/TestData/Pre-Test/PersonalQuestionnaire1.txt");
	
		if(System.IO.File.Exists(path + "/TestData/Pre-Test/PersonalQuestionnaire2.txt"))
			infoMatrix[1] = System.IO.File.ReadAllText(path + "/TestData/Pre-Test/PersonalQuestionnaire2.txt");

		if(System.IO.File.Exists(path + "/TestData/Pre-Test/PersonalQuestionnaire3.txt"))
			infoMatrix[2] = System.IO.File.ReadAllText(path + "/TestData/Pre-Test/PersonalQuestionnaire3.txt");

		if(System.IO.File.Exists(path + "/TestData/Pre-Test/PersonalQuestionnaire4.txt"))
			infoMatrix[3] = System.IO.File.ReadAllText(path + "/TestData/Pre-Test/PersonalQuestionnaire4.txt");

		if(System.IO.File.Exists(path + "/TestData/Pre-Test/PersonalQuestionnaire5.txt"))
			infoMatrix[4] = System.IO.File.ReadAllText(path + "/TestData/Pre-Test/PersonalQuestionnaire5.txt");

		if(System.IO.File.Exists(path + "/TestData/Pre-Test/PersonalQuestionnaire6.txt"))
			infoMatrix[5] = System.IO.File.ReadAllText(path + "/TestData/Pre-Test/PersonalQuestionnaire6.txt");

		if(System.IO.File.Exists(path + "/TestData/Pre-Test/PersonalQuestionnaire7.txt"))
			infoMatrix[6] = System.IO.File.ReadAllText(path + "/TestData/Pre-Test/PersonalQuestionnaire7.txt");

		if(System.IO.File.Exists(path + "/TestData/Pre-Test/PersonalQuestionnaire8.txt"))
			infoMatrix[7] = System.IO.File.ReadAllText(path + "/TestData/Pre-Test/PersonalQuestionnaire8.txt");

		if(System.IO.File.Exists(path + "/TestData/Pre-Test/PersonalQuestionnaire9.txt"))
			infoMatrix[8] = System.IO.File.ReadAllText(path + "/TestData/Pre-Test/PersonalQuestionnaire9.txt");

		if(System.IO.File.Exists(path + "/TestData/Pre-Test/PersonalQuestionnaire10.txt"))
			infoMatrix[9] = System.IO.File.ReadAllText(path + "/TestData/Pre-Test/PersonalQuestionnaire10.txt");
		
		

		if(System.IO.File.Exists(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying1.txt"))
			midMatrix[0] = System.IO.File.ReadAllText(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying1.txt");

		if(System.IO.File.Exists(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying2.txt"))
			midMatrix[1] = System.IO.File.ReadAllText(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying2.txt");

		if(System.IO.File.Exists(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying3.txt"))
			midMatrix[2] = System.IO.File.ReadAllText(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying3.txt");

		if(System.IO.File.Exists(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying4.txt"))
			midMatrix[3] = System.IO.File.ReadAllText(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying4.txt");

		if(System.IO.File.Exists(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying5.txt"))
			midMatrix[4] = System.IO.File.ReadAllText(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying5.txt");

		if(System.IO.File.Exists(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying6.txt"))
			midMatrix[5] = System.IO.File.ReadAllText(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying6.txt");

		if(System.IO.File.Exists(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying7.txt"))
			midMatrix[6] = System.IO.File.ReadAllText(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying7.txt");

		if(System.IO.File.Exists(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying8.txt"))
			midMatrix[7] = System.IO.File.ReadAllText(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying8.txt");

		if(System.IO.File.Exists(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying9.txt"))
			midMatrix[8] = System.IO.File.ReadAllText(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying9.txt");

		if(System.IO.File.Exists(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying10.txt"))
			midMatrix[9] = System.IO.File.ReadAllText(path + "/TestData/Mid-Test/QuestionnaireWhilePlaying10.txt");



		if(System.IO.File.Exists(path + "/TestData/Post-Test/QuestionnaireAfterPlaying1.txt"))
			postMatrix[0] = System.IO.File.ReadAllText(path + "/TestData/Post-Test/QuestionnaireAfterPlaying1.txt");

		if(System.IO.File.Exists(path + "/TestData/Post-Test/QuestionnaireAfterPlaying2.txt"))
			postMatrix[1] = System.IO.File.ReadAllText(path + "/TestData/Post-Test/QuestionnaireAfterPlaying2.txt");

		if(System.IO.File.Exists(path + "/TestData/Post-Test/QuestionnaireAfterPlaying3.txt"))
			postMatrix[2] = System.IO.File.ReadAllText(path + "/TestData/Post-Test/QuestionnaireAfterPlaying3.txt");

		if(System.IO.File.Exists(path + "/TestData/Post-Test/QuestionnaireAfterPlaying4.txt"))
			postMatrix[3] = System.IO.File.ReadAllText(path + "/TestData/Post-Test/QuestionnaireAfterPlaying4.txt");

		if(System.IO.File.Exists(path + "/TestData/Post-Test/QuestionnaireAfterPlaying5.txt"))
			postMatrix[4] = System.IO.File.ReadAllText(path + "/TestData/Post-Test/QuestionnaireAfterPlaying5.txt");

		if(System.IO.File.Exists(path + "/TestData/Post-Test/QuestionnaireAfterPlaying6.txt"))
			postMatrix[5] = System.IO.File.ReadAllText(path + "/TestData/Post-Test/QuestionnaireAfterPlaying6.txt");

		if(System.IO.File.Exists(path + "/TestData/Post-Test/QuestionnaireAfterPlaying7.txt"))
			postMatrix[6] = System.IO.File.ReadAllText(path + "/TestData/Post-Test/QuestionnaireAfterPlaying7.txt");

		if(System.IO.File.Exists(path + "/TestData/Post-Test/QuestionnaireAfterPlaying8.txt"))
			postMatrix[7] = System.IO.File.ReadAllText(path + "/TestData/Post-Test/QuestionnaireAfterPlaying8.txt");

		if(System.IO.File.Exists(path + "/TestData/Post-Test/QuestionnaireAfterPlaying9.txt"))
			postMatrix[8] = System.IO.File.ReadAllText(path + "/TestData/Post-Test/QuestionnaireAfterPlaying9.txt");

		if(System.IO.File.Exists(path + "/TestData/Post-Test/QuestionnaireAfterPlaying10.txt"))
			postMatrix[9] = System.IO.File.ReadAllText(path + "/TestData/Post-Test/QuestionnaireAfterPlaying10.txt");



		System.IO.File.WriteAllText( path + "/TestData/EvuInfo.txt",
									"Pre-Questionnaire:\n" + infoMatrix[0].ToString() +  "\n" + infoMatrix[1].ToString() + "\n" + infoMatrix[2].ToString() + "\n" + infoMatrix[3].ToString() + "\n" + infoMatrix[4].ToString() + "\n" + infoMatrix[5].ToString() + "\n" + infoMatrix[6].ToString() + "\n" + infoMatrix[7].ToString() + "\n" + infoMatrix[8].ToString() + "\n" + infoMatrix[9].ToString()
		                            + "\n \n \n" + "Mid-Questionnaire:\n" + midMatrix[0].ToString() + "\n" + midMatrix[1].ToString() + "\n" + midMatrix[2].ToString() + "\n" + midMatrix[3].ToString() + "\n" + midMatrix[4].ToString() + "\n" + midMatrix[5].ToString() + "\n" + midMatrix[6].ToString() + "\n" + midMatrix[7].ToString() + "\n" + midMatrix[8].ToString() + "\n" + midMatrix[9].ToString()
		                            + "\n \n \n" + "Post-Questionnaire:\n" + postMatrix[0].ToString() + "\n" + postMatrix[1].ToString() + "\n" + postMatrix[2].ToString() + "\n" + postMatrix[3].ToString() + "\n" + postMatrix[4].ToString() + "\n" + postMatrix[5].ToString() + "\n" + postMatrix[6].ToString() + "\n" + postMatrix[7].ToString() + "\n" + postMatrix[8].ToString() + "\n" + postMatrix[9].ToString());

	}





}
