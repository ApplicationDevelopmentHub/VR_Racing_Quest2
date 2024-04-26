using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUIHandler : MonoBehaviour
{
    public Dropdown CarDropdown;
    public Dropdown TrackDropdown;
    public void GoToGameScene()
    {
        PlayerPrefs.SetInt("CarIndex",CarDropdown.value);
        PlayerPrefs.SetInt("TrackIndex", TrackDropdown.value);
        SceneManager.LoadScene(1);
    }
}
