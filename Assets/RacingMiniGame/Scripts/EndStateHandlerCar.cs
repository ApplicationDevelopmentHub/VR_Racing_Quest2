using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndStateHandlerCar : MonoBehaviour
{
    public static EndStateHandlerCar Instance;
    public GameObject EndGameUITrack1, EndgameUITrack2;
    public Text playerPosition;
    public Button restartButton;
    public Button mainMenuButton;
    public Button quitGameButton;
    // Start is called before the first frame update
    private void Start()
    {
        Instance = this;
    }
    public void RestartRace()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void EnableEndUI()
    {
        if (PlayerPrefs.GetInt("TrackIndex") == 0)
        {
            EndGameUITrack1.SetActive(true);
        }
        else
        {
            EndgameUITrack2.SetActive(true);
        }
    }
}
