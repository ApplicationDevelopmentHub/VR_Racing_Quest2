using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CustomInput : MonoBehaviour
{
    public InputActionReference LeftX_Steer = null;
    public InputActionReference RightA_Steer = null;
    public InputActionReference RightTrigger_Acc = null;
    public InputActionReference LeftTrigger_Brake = null;

    public Rigidbody CarParent;

    //public GameObject VRController;
    public float AccForce = 5.0f;
    public float BrakeForce = 0.0f;
    // Start is called before the first frame update
    private void Update()
    {
        if (LeftX_Steer.action.IsPressed())
        {      
            CarParent.gameObject.transform.Rotate(0.0f, -3.0f, 0.0f);
        }
        if (RightA_Steer.action.IsPressed())
        {
            CarParent.gameObject.transform.Rotate(0.0f, 3.0f, 0.0f);
        }
        if (RightTrigger_Acc.action.IsPressed())
        {
            Debug.Log("acc");
            CarParent.velocity = CarParent.transform.forward * 30.0f;
        }
        if (LeftTrigger_Brake.action.IsPressed())
        {
            Debug.Log("brake");
            CarParent.velocity = CarParent.transform.forward * (-30.0f);
        }


        //keyboard controls
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("left steer");
            CarParent.gameObject.transform.Rotate(0.0f, 1.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Right steer");
            CarParent.gameObject.transform.Rotate(0.0f, -1.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("acc");
            CarParent.velocity = CarParent.transform.forward* 10.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("brake");
            CarParent.velocity = CarParent.transform.position * -10.0f;
        }
    }   
}
