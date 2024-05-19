using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class CustomInput : MonoBehaviour
{
    public InputActionReference LeftX_Steer = null;
    public InputActionReference RightA_Steer = null;
    public InputActionReference RightTrigger_Acc = null;
    public InputActionReference LeftTrigger_Brake = null;
    public InputActionReference Resetgame=null;

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
            if (Resetgame.action.IsPressed())
            {
                SceneManager.LoadScene(0);
            }
            if (LeftX_Steer.action.IsPressed())
            {
                //CarParent.gameObject.transform.Rotate(0.0f, -3.0f, 0.0f);
                CarParent.gameObject.transform.Rotate(0.0f, 1.0f, 0.0f);
            }
            if (RightA_Steer.action.IsPressed())
            {
                //CarParent.gameObject.transform.Rotate(0.0f, 3.0f, 0.0f);
                CarParent.gameObject.transform.Rotate(0.0f, -1.0f, 0.0f);

            }
            if (RightTrigger_Acc.action.IsPressed())
            {
                //CarParent.velocity = CarParent.transform.forward * VelocityValue;
                //if (VelocityValue <= 89.9)
                //{
                //    VelocityValue = VelocityValue + 0.5f;
                //}
                CarParent.linearVelocity = CarParent.transform.forward * VelocityValue;
                if (VelocityValue <= 89.9)
                {
                    VelocityValue = VelocityValue + 0.1f;
                }
            }
            if (LeftTrigger_Brake.action.IsPressed())
            {
                //Debug.Log("brake");
                //CarParent.velocity = CarParent.transform.forward * VelocityValue;
                //if (VelocityValue >= -30.0f)
                //{
                //    VelocityValue = VelocityValue - 0.5f;
                //}
                CarParent.linearVelocity = CarParent.transform.forward * VelocityValue * -1.0f;
                if (VelocityValue >= -30.0f)
                {
                    VelocityValue = VelocityValue - 0.1f;
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
                CarParent.linearVelocity = CarParent.transform.forward * VelocityValue;
                if (VelocityValue <= 89.9)
                {
                    VelocityValue = VelocityValue + 0.1f;
                }
            }
            if (Input.GetKey(KeyCode.S))
            {
                CarParent.linearVelocity = CarParent.transform.forward * VelocityValue * -1.0f;
                if (VelocityValue >= -30.0f)
                {
                    VelocityValue = VelocityValue - 0.1f;
                }
            }
        }
    }   
}
