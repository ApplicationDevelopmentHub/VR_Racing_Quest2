using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankCarPositions : MonoBehaviour
{
    public Transform target1, target2;
    
    Transform target; // Assign the target from the inspector
    public List<GameObject> cars; // Assign all cars from the inspector
    public GameObject car1Track1, car2Track1, car1Track2, car2Track2, playerCar;

    private void Start()
    {
        if (PlayerPrefs.GetInt("TrackIndex") == 0)
        {
            target = target1;
            //assign the cars to list
            cars.Add(car1Track1);
            cars.Add(car2Track1);
            cars.Add(playerCar);
        }
        else
        {
            target = target2;
            cars.Add(car1Track2);
            cars.Add(car2Track2);
            cars.Add(playerCar);
        }

    }

    void Update()
    {
        // Sort cars by distance to the target
        cars.Sort((car1, car2) =>
            Vector3.Distance(car1.transform.position, target.position).CompareTo(
            Vector3.Distance(car2.transform.position, target.position)));

        // Output the sorted list
        for (int i = 0; i < cars.Count; i++)
        {
            UIDisplayInGame.Instance.CarRankUI[i].text = (i+1)+"." + cars[i].name;
            //Debug.Log($"Rank {i + 1}: {cars[i].name} at distance {Vector3.Distance(cars[i].transform.position, target.position)}");
        }
    }
}
