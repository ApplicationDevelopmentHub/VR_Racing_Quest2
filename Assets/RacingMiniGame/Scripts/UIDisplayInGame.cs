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
        //CarParentRigidbody = GameObject.Find("CarControlParent");
        StartCoroutine(ProgressTimer());
        Debug.Log("Name:"+gameObject.name);
    }
    private void Update()
    {
        TimeLeft.text = "Time left: " + _timeLeft;
        Speed.text = "Speed: " + Convert.ToInt32(CarParentRigidbody.GetComponent<Rigidbody>().linearVelocity.magnitude);
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
