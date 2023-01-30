using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using Valve.VR;
public class MyActionScript : MonoBehaviour
{
    // a reference to the action
    public SteamVR_Action_Boolean SphereOnOff;
    public SteamVR_Action_Boolean FlyUp;
    public SteamVR_Action_Boolean FlyDown;

    public SteamVR_Action_Vector2 ThumbStick;
    // a reference to the hand
    public SteamVR_Input_Sources handType;
    //reference to the sphere
    public GameObject Sphere;

    public Camera headset;

    public bool isFlyingUp;

    public bool isFlyingDown;

    public Vector3 Joystick;

    void Start()
    {

        
        //SphereOnOff.AddOnStateDownListener(TriggerDown, handType);
        //SphereOnOff.AddOnStateUpListener(TriggerUp, handType);

        //FlyUp.AddOnStateDownListener(TriggerDown, handType);


        //ThumbStick.AddOnActiveChangeListener(StickMove, handType);
        //ThumbStick.AddOnChangeListener(StickMove, handType);
        //ThumbStick.AddOnUpdateListener(StickMove, handType);
        //ThumbStick.AddOnStateChangeListener(StickMove, handType);

        //ThumbStick.AddOnAxisListener(StickHandler, handType);


    }



    private void Update()
    {
        //print("hello" + ThumbStick.axis);
        Joystick = new Vector3(ThumbStick.axis.x, 0, ThumbStick.axis.y);

        isFlyingUp = FlyUp.state;
        isFlyingDown = FlyDown.state;
        //print(FlyUp.state);
    }


    //public void FlyUp_(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    //{
    //    Debug.Log("Flying Up");
    //    isFlyingUp = true;
    //}
    //public void StickHandler(SteamVR_Action_Vector2 fromAction, SteamVR_Input_Sources fromSource, Vector2 axis, Vector2 delta)
    //{
    //    //Debug.Log(axis);
    //    Joystick = new Vector3 (axis.x, 0, axis.y);
    //}

    //public void StickMove(SteamVR_Action_Vector2 fromAction, SteamVR_Input_Sources fromSource)
    //{
    //    Debug.Log("Trigger is up");
    //    Sphere.GetComponent<MeshRenderer>().enabled = false;
    //}

    //public void TriggerUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    //{
    //    Debug.Log("Trigger is up");
    //    Sphere.GetComponent<MeshRenderer>().enabled = false;
    //}
    //public void TriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    //{
    //    Debug.Log("Trigger is down");
    //    Sphere.GetComponent<MeshRenderer>().enabled = true;
    //}




}