using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.iOS;

using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class EvuControl : MonoBehaviour {

	string path;

	int timer = 0;
	int check = 10;
	bool done = false;


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

		path = Application.dataPath;


		/*
		//create Folder
		if (!System.IO.Directory.Exists ("C:/DataComicMed6/")) {
			
			System.IO.Directory.CreateDirectory ("C:/DataComicMed6/");
		
		}
		*/








	
	}
	
	// Update is called once per frame
	void Update () {

		timer++;

		if((timer == check) && done == true) {
			mailDone();
		}



		if(oneOne == true) {

			One = "Du har valgt bla";

		}

	
	}

	public void test () {
		oneOne = true;
		oneTwo = false;
		oneThree = false;
	}



	public void sendMail () {

		System.IO.File.WriteAllText( path + "/TestToUs.txt", One + "    " + One );



	


		MailMessage mail = new MailMessage();



		mail.From = new MailAddress("comicmed6@hotmail.com");
		mail.To.Add("comicmed6@hotmail.com");
		mail.Subject = "Test Mail";
		mail.Body = "Test test test";



		System.Net.Mail.Attachment attachment;
		attachment = new System.Net.Mail.Attachment(path + "/TestToUs.txt");
		mail.Attachments.Add(attachment);


		
		SmtpClient smtpServer = new SmtpClient("smtp.live.com");
		smtpServer.Port = 587;
		smtpServer.Credentials = new System.Net.NetworkCredential("comicmed6@hotmail.com", "TestForUs!") as ICredentialsByHost;
		smtpServer.EnableSsl = true;
		ServicePointManager.ServerCertificateValidationCallback = 
			delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) 
		{ return true; };
		smtpServer.Send(mail);
		Debug.Log("success");



			timer = 0;
			done = true;



	}

	void mailDone () {

		GetComponent<AudioSource>().Play();
		Application.Quit();

	
	}


	public void OnApplicationQuit() {

	}
}
