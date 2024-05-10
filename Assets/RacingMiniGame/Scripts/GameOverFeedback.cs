using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverFeedback : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name== "CarParent")
        {
            Debug.Log("GAME OVER -----------------------");
            GameStateHandler.gameState = GameStateHandler.GameState.End;
            GameStateHandler.Instance.GameEnded();
        }
    }
}
