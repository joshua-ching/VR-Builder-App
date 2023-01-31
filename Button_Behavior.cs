using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Button_Behavior : MonoBehaviour
{

    public event Action ButtonPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        print(collision.transform.gameObject.name);

        if (ButtonPressed != null)
        {
            ButtonPressed();
        }
    }



}
