using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    //Score
    public int in_Score;
    public int in_currentHighScore;

    //coin score bonus
    public int in_coinScore;

    //time bonus
    public int in_timeBonusTimer;
    public int in_timeBonusTime;
    public int in_timeBonusScore;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("HighScore"))
        {
            in_currentHighScore = PlayerPrefs.GetInt("highScore");
        }
	}
	
	// Update is called once per frame
	void Update () {
        in_timeBonusTimer += Mathf.RoundToInt(Time.deltaTime);
	}
    //winning the game
    public void GameWin()
    {
        //if the player completes the game within 3 minutes, add a bonus
        if(in_timeBonusTimer <= in_timeBonusTime)
        {
            in_Score += in_timeBonusScore;
        }



        //updates the highscore, so other scenes can show it.
        if(in_Score > PlayerPrefs.GetInt("HighScore")|| !PlayerPrefs.HasKey("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", in_Score);
        }
        //change Scene
        SceneManager.LoadScene(2);
    }
    //losing the game
    public void GameLose()
    {
        SceneManager.LoadScene(3);
    }
    public void CoinGet()
    {
        in_Score += in_coinScore;
    }
}
