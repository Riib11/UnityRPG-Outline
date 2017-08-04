using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour {

	public GameObject dialogueBox;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void createDialogue(string[] texts, InteractController ic) {
		GameObject.Find ("Player").GetComponent<Player> ().canMove = false;
		GameObject go = GameObject.Instantiate (dialogueBox);
		go.transform.SetParent(GameObject.Find("Canvas").transform);
		go.GetComponent<RectTransform> ().localPosition = new Vector3 (0f, -200, 0);
		go.GetComponent<DialogueController> ().texts = texts;
		go.GetComponent<DialogueController> ().ic = ic;
	}
}
