using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;
public class EnableAICars : MonoBehaviour
{
    public static EnableAICars Instance;
    public SplineAnimate Track1_1;
    public SplineAnimate Track1_2;
    public SplineAnimate Track2_1;
    public SplineAnimate Track2_2;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableSplines()
    {
        if (PlayerPrefs.GetInt("TrackIndex") == 0)
        {
            Track1_1.enabled = true;
            Track1_2.enabled = true;
        }

        if (PlayerPrefs.GetInt("TrackIndex") == 1)
        {
            Track2_1.enabled = true;
            Track2_2.enabled = true;
        }
    }

    public void DisableAICars()
    {
        Track1_1.enabled = false;
        Track1_2.enabled = false;
        Track2_1.enabled = false;
        Track2_2.enabled = false;

        Track1_1.gameObject.SetActive(false);
        Track1_2.gameObject.SetActive(false);
        Track2_1.gameObject.SetActive(false);
        Track2_2.gameObject.SetActive(false);
    }
}
