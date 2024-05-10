using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;
public class EnableAICars : MonoBehaviour
{
    public static EnableAICars Instance;
    public SplineAnimate Car1Track1;
    public SplineAnimate Car1Track2;
    public SplineAnimate Car2Track1;
    public SplineAnimate Car2Track2;

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
            Car1Track1.enabled = true;
            Car2Track1.enabled = true;
        }

        if (PlayerPrefs.GetInt("TrackIndex") == 1)
        {
            Car1Track2.enabled = true;
            Car2Track2.enabled = true;
        }
    }

    public void DisableAICars()
    {
        Car1Track1.enabled = false;
        Car2Track1.enabled = false;
        Car1Track2.enabled = false;
        Car2Track2.enabled = false;
    }
}
