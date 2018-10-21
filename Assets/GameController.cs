using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public string randomOperator;
	public int answer;

	public GameObject question;
	public GameObject option1;
	public GameObject option2;
	public GameObject option3;

	// Use this for initialization
	void Start () {
		GenerateQuestion ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GenerateQuestion()
	{
		int a = Random.Range (0, 101);
		int b = Random.Range (0, 101);
		int operatorNumber = Random.Range (0, 3);

		option1.GetComponent<TextMesh> ().color = Color.white;
		option2.GetComponent<TextMesh> ().color = Color.white;
		option3.GetComponent<TextMesh> ().color = Color.white;

		if (operatorNumber == 0) {
			randomOperator = "+";
			answer = a + b;
		}
		else if (operatorNumber == 1) {
			randomOperator = "-";
			answer = a - b;
		} else {
			randomOperator = "*";
			answer = a * b;
		}
		int option = Random.Range (0, 3);
		if (option == 0) {
			option1.GetComponent<TextMesh> ().text = answer.ToString ();
			option2.GetComponent<TextMesh> ().text = (answer + (Random.Range (0, 3) * 2 - 1)).ToString ();
			option3.GetComponent<TextMesh> ().text = (answer + (Random.Range (0, 3) * 2 - 1)).ToString ();

			option1.GetComponent<Option> ().isCorrect = true;
			option2.GetComponent<Option> ().isCorrect = false;
			option3.GetComponent<Option> ().isCorrect = false;
		}
		else if (option == 1) {
			option2.GetComponent<TextMesh> ().text = answer.ToString ();
			option1.GetComponent<TextMesh> ().text = (answer + (Random.Range (0, 3) * 2 - 1)).ToString ();
			option3.GetComponent<TextMesh> ().text = (answer + (Random.Range (0, 3) * 2 - 1)).ToString ();

			option2.GetComponent<Option> ().isCorrect = true;
			option1.GetComponent<Option> ().isCorrect = false;
			option3.GetComponent<Option> ().isCorrect = false;
		} 
		else {
			option3.GetComponent<TextMesh> ().text = answer.ToString ();
			option2.GetComponent<TextMesh> ().text = (answer + (Random.Range (0, 3) * 2 - 1)).ToString ();
			option1.GetComponent<TextMesh> ().text = (answer + (Random.Range (0, 3) * 2 - 1)).ToString ();

			option3.GetComponent<Option> ().isCorrect = true;
			option2.GetComponent<Option> ().isCorrect = false;
			option1.GetComponent<Option> ().isCorrect = false;
		}
		question.GetComponent<TextMesh> ().text = a + " " + randomOperator + " " + b + " = ?";
	}
}
