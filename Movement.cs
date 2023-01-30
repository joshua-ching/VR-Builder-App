using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    MyActionScript myActionScript;
    Rigidbody rigidBody;

    Vector3 moveDirection;

    public float speed = 5;

    public float flySpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        myActionScript = GetComponent<MyActionScript>();
        rigidBody = GetComponent<Rigidbody>();
        //StartCoroutine(MoveCheck());
    }



    // Update is called once per frame
    void Update()
    {
        moveDirection = UnityEngine.Quaternion.AngleAxis(myActionScript.headset.transform.rotation.eulerAngles.y, UnityEngine.Vector3.up) * myActionScript.Joystick;
        
        if(myActionScript.isFlyingUp && !myActionScript.isFlyingDown)
        {
            moveDirection.y = flySpeed;
        }else if(!myActionScript.isFlyingUp && myActionScript.isFlyingDown)
        {
            moveDirection.y = -flySpeed;
        }
        else
        {
            moveDirection.y = 0;
        }

        rigidBody.AddForce(moveDirection.normalized * speed * 10f, ForceMode.Force);
    }


    void Move()
    {
        print(myActionScript.headset.transform.rotation.eulerAngles.y + "head rotation");
        rigidBody.AddForce(moveDirection, ForceMode.Impulse);
    }

    float updateTime = 0.2f;
    IEnumerator MoveCheck()
    {
        yield return new WaitForSeconds(updateTime);
        Move();
        StartCoroutine(MoveCheck());
    }


}
