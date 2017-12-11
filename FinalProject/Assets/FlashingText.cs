using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FlashingText : MonoBehaviour {

	Text flashingText;
	public float delayTime = 0f; 

	// Use this for initialization
	void Start () {
		flashingText = GetComponent<Text> ();
		StartCoroutine (BlinkText());
	}
	IEnumerator BlinkText(){
		while (true) {
			flashingText.text = "";
			yield return new WaitForSeconds (0.5f);
			flashingText.text = "Thank You";
			yield return new WaitForSeconds (0.5f);
			delayTime += 1f;
			if (delayTime == 3f)
				Application.Quit ();
		}
	}
}
