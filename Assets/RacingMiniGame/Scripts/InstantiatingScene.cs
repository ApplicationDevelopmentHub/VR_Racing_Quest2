using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatingScene : MonoBehaviour
{
    int _carIndex;
    int _trackIndex;
    public GameObject[] CarPrefabList;
    public Vector3[] CarPosition;
    public Vector3[] carRotation;

    public GameObject[] TrackPrefabList;
    public Vector3[] TrackPosition;
    public Vector3[] TrackRotation;

    public GameObject VRController;
    public GameObject Environment;

    public GameObject CameraXRRig;
    public Transform[] CameraCustomPositions;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("car index: " + PlayerPrefs.GetInt("CarIndex") + ", track index: " + PlayerPrefs.GetInt("TrackIndex"));

        _carIndex = PlayerPrefs.GetInt("CarIndex");
        _trackIndex = PlayerPrefs.GetInt("TrackIndex");


        GameObject tempCar= Instantiate(CarPrefabList[_carIndex],CarPosition[_carIndex],
            Quaternion.Euler(carRotation[_carIndex].x, carRotation[_carIndex].y, carRotation[_carIndex].z));
        tempCar.transform.parent = VRController.transform;

        GameObject tempTrack = Instantiate(TrackPrefabList[_trackIndex], TrackPosition[_trackIndex],
            Quaternion.Euler(TrackRotation[_trackIndex].x, TrackRotation[_trackIndex].y, TrackRotation[_trackIndex].z));
        tempTrack.transform.parent = Environment.transform;

        //set camera position
        CameraXRRig.transform.position = CameraCustomPositions[_carIndex].position;

    }
}
