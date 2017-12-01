using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour {
    private Text volumeText;

    void Start() {
        volumeText = GameObject.Find("VolumeText").GetComponent<Text>();
    }

    public void VolumeDown()
    {
        float volume = SoundManager.instance.musicSource.volume;
        SoundManager.instance.musicSource.volume = (float)System.Math.Round((volume - 0.1f), 1);
        volumeText.text = "Volume : " + SoundManager.instance.musicSource.volume * 100;
    }

    public void VolumeUp()
    {
        float volume = SoundManager.instance.musicSource.volume;
        SoundManager.instance.musicSource.volume = (float)System.Math.Round((volume + 0.1f), 1);
        volumeText.text = "Volume : " + SoundManager.instance.musicSource.volume * 100;
    }
}
