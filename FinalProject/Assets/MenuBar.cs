using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBar : MonoBehaviour {
    private GameObject image;

    void Start() {
        image = GameObject.Find("MenuBar");
        image.SetActive(false);
	}

    public void onClick()
    {
        GameObject.Find("Canvas").transform.Find("MenuBar").gameObject.SetActive(true);
    }
}
