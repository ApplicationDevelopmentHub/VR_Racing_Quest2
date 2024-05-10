using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointFeedback : MonoBehaviour
{
    public static int Car1CP = 0, Car2CP = 0, PlayerCarCP = 0;
    public static List<int> CarCheckPoints=new List<int>();
    //public static int rankPlayer = 0, rank1 = 0, rank2 = 0;
    public static int[] rankCars;
    //public static string[] CarNames = { "AI1", "AI2", "Player" };
   
    // Start is called before the first frame update
    void Start()
    {
        rankCars= new int[] {0,0,0};
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("A car entered:" + other.gameObject.name);
        switch (other.gameObject.name)
        {
            case "CarBlueTrack1":
                Car1CP++;
                break;
            case "CarGrayTrack1":
                Car2CP++;
                break;
            case "CarParent":
                PlayerCarCP++;
                break;
        }
        Debug.Log("First car Cp: " + Car1CP + ",car 2 cp:" + Car2CP);

    }

}
