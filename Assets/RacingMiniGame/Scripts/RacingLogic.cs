using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingLogic : MonoBehaviour
{

    public GameObject SplinesTrack1;
    public GameObject SplinesTrack2;
    public GameObject AICarsTrack1;
    public GameObject AICarsTrack2;

    public GameObject[] Track1CarsArray;
    public GameObject[] Track2CarsArray;

    //defualt value-0: which checkpt passed
    //public static int Car1CP=0, Car2CP=0, PlayerCarCP=0;

    public GameObject PlayerCar;
    // Start is called before the first frame update
    void Start()
    {
        //if (PlayerPrefs.GetInt("TrackIndex") == 0)
        //{
        //    SplinesTrack1.SetActive(true);
        //    AICarsTrack1.SetActive(true);
        //}
        //else if(PlayerPrefs.GetInt("TrackIndex") == 1)
        //{
        //    SplinesTrack2.SetActive(true);
        //    AICarsTrack2.SetActive(true);
        //}
        //else
        //{
        //    Debug.Log("Track not mentioned");
        //}
        //CheckPointFeedback.Car1CP = 0;
        //CheckPointFeedback.Car2CP = 0;
        //CheckPointFeedback.PlayerCarCP = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
