using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class IndexInput : MonoBehaviour
{

    public SteamVR_Action_Vector2 ThumbstickAction = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (ThumbstickAction.axis == Vector2.zero)
        //    return;
        //print("Thumbstick: " + ThumbstickAction.axis);
        //Debug.Log(_inputData._rightController.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 stick));
    }
}
