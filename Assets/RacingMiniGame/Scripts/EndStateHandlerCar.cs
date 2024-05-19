using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndStateHandlerCar : MonoBehaviour
{
    public static EndStateHandlerCar Instance;
    public GameObject EndGameUITrack1, EndgameUITrack2;
    public Text[] playerPosition;

    public Vector3[] EndCarPosition;
    public Vector3[] EndCarRotation;

    public GameObject CarParent;
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
        int tempRank = 0;
       
        if (PlayerPrefs.GetInt("TrackIndex") == 0)
        {
            playerPosition[0].text = "Your position: " + tempRank; 
            EndGameUITrack1.SetActive(true);
            //setting car position
            CarParent.GetComponent<Rigidbody>().isKinematic = true;
            CarParent.transform.position = EndCarPosition[0];
            CarParent.transform.rotation = Quaternion.Euler(EndCarRotation[0]);
        }
        else
        {
            playerPosition[1].text = "Your position: " + tempRank;
            EndgameUITrack2.SetActive(true);
            //setting car position
            CarParent.GetComponent<Rigidbody>().isKinematic = true;
            CarParent.transform.position = EndCarPosition[1];
            CarParent.transform.rotation = Quaternion.Euler(EndCarRotation[1]);
        }
    }
}
