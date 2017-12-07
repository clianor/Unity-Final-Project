using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public InputField IDInputField;
	public InputField PWInputField;
	public InputField NewIDInputField;
	public InputField NewPWInputField;
	public GameObject CreateAccountPanel;

    public static GameManager instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (Input.GetKeyDown(KeyCode.PageDown))
        {
            float volume = SoundManager.instance.musicSource.volume;
            SoundManager.instance.musicSource.volume = (float)System.Math.Round((volume - 0.1f), 1);
        }
        else if (Input.GetKeyUp(KeyCode.PageUp))
        {
            float volume = SoundManager.instance.musicSource.volume;
            SoundManager.instance.musicSource.volume = (float)System.Math.Round((volume + 0.1f), 1);
        }
    }

    //코루틴
    public void LoginBtn(){
		StartCoroutine (LoginCo ());
	}

	IEnumerator LoginCo(){
		string conn = "URI=file:" + Application.dataPath + "/Login.db";
		IDbConnection dbconn;
		dbconn = (IDbConnection) new SqliteConnection (conn);
		dbconn.Open ();

		IDbCommand dbcmd = dbconn.CreateCommand ();
		string sqlQuery = "SELECT * FROM Login";
		dbcmd.CommandText = sqlQuery;

		IDataReader reader = dbcmd.ExecuteReader ();

		while (reader.Read ()) {
			int Number = reader.GetInt32 (0);
			string ID = reader.GetString (1);
			string Password = reader.GetString (2);

			if (IDInputField.text == reader.GetString (1)	){
				if(PWInputField.text == reader.GetString(2)) {
					SceneManager.LoadScene ("Main");
				}
			}
		}
		reader.Close ();
		reader = null;
		dbcmd.Dispose ();
		dbcmd = null;
		dbconn.Close ();
		dbconn = null;

		yield return null;
	}

	public void CreateAccountBtn(){	
		string conn = "URI=file:" + Application.dataPath + "/Login.db";
		IDbConnection dbconn;
		dbconn = (IDbConnection) new SqliteConnection (conn);
		dbconn.Open ();

		IDbCommand dbcmd = dbconn.CreateCommand ();
		string ID = NewIDInputField.text;
		string PASSWORD = NewPWInputField.text;
		string sqlQuery = String.Format("INSERT INTO Login (ID,Password) VALUES('{0}','{1}');",ID,PASSWORD);
		dbcmd.CommandText = sqlQuery;
		dbcmd.ExecuteNonQuery ();


		dbcmd.Dispose ();
		dbcmd = null;
		dbconn.Close ();
		dbconn = null;

		if (dbcmd == null && dbconn == null)
			SceneManager.LoadScene ("LoginScene");
	}

	public void OpenCreateAccountBtn(){
		CreateAccountPanel.SetActive (true);
	}
}
