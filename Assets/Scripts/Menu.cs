using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour {
    public GameObject GO_Controls;
    public GameObject GO_Credits;
    public Text TX_Highscore;
	
	void Start () {
        //highscore check:
        if(!PlayerPrefs.HasKey("HighScore"))
        {
            TX_Highscore.text = "No highscore set yet!";
        }
        else
        {
            TX_Highscore.text = "Current high score: " + PlayerPrefs.GetInt("HighScore");
        }
        GO_Controls.SetActive(false);
        GO_Credits.SetActive(false);
	}
    public void Credits()
    {
        GO_Credits.SetActive(true);
        GO_Controls.SetActive(false);
    }
    public void Controls()
    {
        GO_Credits.SetActive(false);
        GO_Controls.SetActive(true);
    }
    public void Back()
    {
        GO_Controls.SetActive(false);
        GO_Credits.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Game Started!");
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("I QUIT!");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
}
