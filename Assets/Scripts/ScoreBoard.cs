using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {
    public Text TX_CurrentScore;
    public Text TX_HighScore;
	// Use this for initialization
	void Start () {
        TX_CurrentScore.text = "Current Score: 0"; 
        TX_HighScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
	}
	
	// Update is called once per frame
	void Update () {
        GameManager GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (GM.in_Score > PlayerPrefs.GetInt("HighScore"))
        {
            TX_HighScore.text = "New High Score!";
        }
        TX_CurrentScore.text = "Current Score: " + GM.in_Score;
    }
}
