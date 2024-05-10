using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIDisplayInGame : MonoBehaviour
{
    public static UIDisplayInGame Instance;
    public Text TimeLeft;
    public Text Speed;

    public Text[] CarRankUI;
    //public Text Rank1Player;
    //public Text Rank2Player;
    //public Text Rank3Player;

    public static int _timeLeft=30;

    public GameObject CarParentRigidbody;
    private void Start()
    {
        Instance = this;
        CarParentRigidbody = GameObject.Find("CarParent");
        StartCoroutine(ProgressTimer());
        Debug.Log("Name:"+gameObject.name);
    }
    private void Update()
    {
        TimeLeft.text = "Time left: " + _timeLeft;
        Speed.text = "Speed: " + Convert.ToInt32(CarParentRigidbody.GetComponent<Rigidbody>().velocity.magnitude);

        //CheckPointFeedback.CarCheckPoints.Clear();
        //CheckPointFeedback.CarCheckPoints.Add(CheckPointFeedback.PlayerCarCP);
        //CheckPointFeedback.CarCheckPoints.Add(CheckPointFeedback.Car1CP);
        //CheckPointFeedback.CarCheckPoints.Add(CheckPointFeedback.Car2CP);



        //for (int i = 0; i < CheckPointFeedback.CarCheckPoints.Count; i++)
        //{
        //    int tempCounter = 0;
        //    for(int j = 0; j < CheckPointFeedback.CarCheckPoints.Count; j++)
        //    {
        //        if (CheckPointFeedback.CarCheckPoints[j] > CheckPointFeedback.CarCheckPoints[i])
        //        {
        //            tempCounter++;
        //        }
        //    }
        //    CheckPointFeedback.rankCars[i] = tempCounter + 1;
        //}
        //Rank1Player.text = "Player rank: " + CheckPointFeedback.rankCars[0];
        //Rank2Player.text = "Car1 rank: " + CheckPointFeedback.rankCars[1];
        //Rank3Player.text = "Car2 rank: " + CheckPointFeedback.rankCars[2];
    }

    IEnumerator ProgressTimer()
    {
        while (_timeLeft > 0)
        {
            yield return new WaitForSeconds(1.0f);
            _timeLeft--;
        }
    }
}
