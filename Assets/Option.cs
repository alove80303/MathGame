using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour {

	public bool isCorrect;
	public GameObject option1;
	public GameObject option2;
	public GameObject option3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
	{
		if (isCorrect) {
			GetComponent<TextMesh> ().color = Color.green;
		} 
		else {
			if (option1.GetComponent<Option>().isCorrect == true) {
				option1.GetComponent<TextMesh> ().color = Color.yellow;
			}
			else if (option2.GetComponent<Option>().isCorrect == true)
			{
				option2.GetComponent<TextMesh> ().color = Color.yellow;
			} 
			else {
				option3.GetComponent<TextMesh> ().color = Color.yellow;
			}
			GetComponent<TextMesh> ().color = Color.red;
		}
	}
}
