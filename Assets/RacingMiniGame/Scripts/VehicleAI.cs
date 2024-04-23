using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleAI : MonoBehaviour
{
    public Vector3[] carCheckPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3.MoveTowards(transform.position,carCheckPoints[0], Time.deltaTime*3.0f);
    }
}
