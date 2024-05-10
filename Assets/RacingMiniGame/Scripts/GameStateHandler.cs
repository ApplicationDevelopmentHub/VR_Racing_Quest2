using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Splines;

public class GameStateHandler : MonoBehaviour
{
    public static GameStateHandler Instance;
    public Text timerValue;

    public GameObject StartUI; //enabled by default, rest disabled
    public GameObject GameUI;

    //Game state: change UI, enable controls, enable splines
    private int _timer=5;
    public enum GameState
    {
        Start,
        Game,
        End
    }
    public static GameState gameState;
    void Start()
    {
        gameState = GameState.Start;
        StartCoroutine(DecreaseTimerValue());
        timerValue.text =""+_timer;

    }

    // Update is called once per frame
    void Update()
    {
        Instance=this;
        timerValue.text = "" + _timer;
    }

    IEnumerator DecreaseTimerValue()
    {
        yield return new WaitForSeconds(1.0f);
        while (_timer > 0)
        {
            yield return new WaitForSeconds(1.0f);
            _timer--;
            Debug.Log("Time value=" + _timer);
           
        }
        gameState = GameState.Game;
        StartUI.SetActive(false);
        GameUI.SetActive(true);
        EnableAICars.Instance.EnableSplines();
        //we have to enable controls
    }

    public void GameEnded()
    {
        EnableAICars.Instance.DisableAICars();
        GameUI.SetActive(false);
        EndStateHandlerCar.Instance.EnableEndUI();
    }

}
