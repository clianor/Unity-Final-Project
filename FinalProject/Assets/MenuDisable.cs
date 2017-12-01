using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDisable : MonoBehaviour {
    public void onClick()
    {
        GameObject.Find("VolumeImage").SetActive(false);
    }
}
