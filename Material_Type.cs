using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material_Type : MonoBehaviour
{

    public string type;

    MeshRenderer meshRenderer;
    Rigidbody rigidBody;


    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponentInChildren<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        switch (type)
        {
            case "wood":
                meshRenderer.material = Materials.wood;
                rigidBody.mass = 1;
                break;
            case "stone":
                meshRenderer.material = Materials.stone;
                rigidBody.mass = 20;
                break;
            case "metal":
                meshRenderer.material = Materials.metal;
                rigidBody.mass = 100;
                break;
            default:
                break;

        }
    }


}
