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
    //max value= 90
    public float VelocityValue = 20.0f;
    //public float BrakeForce = 0.0f;
    // Start is called before the first frame update
    private void Update()
    {
        if (GameStateHandler.gameState == GameStateHandler.GameState.Game)
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
                CarParent.velocity = CarParent.transform.forward * VelocityValue;
                if (VelocityValue <= 89.9)
                {
                    VelocityValue = VelocityValue + 0.5f;
                }
            }
            if (LeftTrigger_Brake.action.IsPressed())
            {
                Debug.Log("brake");
                CarParent.velocity = CarParent.transform.forward * VelocityValue;
                if (VelocityValue >= -30.0f)
                {
                    VelocityValue = VelocityValue - 0.5f;
                }
            }
            if (!RightTrigger_Acc.action.IsPressed() && !LeftTrigger_Brake.action.IsPressed())
            {
                if (VelocityValue > 20.0f)
                {
                    VelocityValue = VelocityValue - 0.1f;
                }
                if (VelocityValue < 20.0f)
                {
                    VelocityValue = VelocityValue + 0.1f;
                }
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
                CarParent.velocity = CarParent.transform.forward * VelocityValue;
                if (VelocityValue <= 89.9)
                {
                    VelocityValue = VelocityValue + 0.1f;
                }
            }
            if (Input.GetKey(KeyCode.S))
            {
                Debug.Log("brake");
                CarParent.velocity = CarParent.transform.forward * VelocityValue * -1.0f;
                if (VelocityValue >= -30.0f)
                {
                    VelocityValue = VelocityValue - 0.1f;
                }
            }
        }
        //if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        //{
        //    if (VelocityValue > 10.0f) { 
        //        VelocityValue = VelocityValue - 0.1f;
        //    }
        //    if (VelocityValue < 10.0f)
        //    {
        //        VelocityValue = VelocityValue + 0.1f;
        //    }
        //}
    }   
}
