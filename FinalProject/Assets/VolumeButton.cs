using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeButton : MonoBehaviour {
	void Start () {
        GameObject.Find("VolumeImage").SetActive(false);
	}
	
	public void onClick()
    {
        GameObject.Find("Canvas").transform.Find("VolumeImage").gameObject.SetActive(true);
        GameObject.Find("MenuBar").SetActive(false);
    }
}
