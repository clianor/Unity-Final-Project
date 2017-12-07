using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoundManager : MonoBehaviour
{
    public AudioSource musicSource;
    public static SoundManager instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}