using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Materials : MonoBehaviour
{
    public static Material wood;

    public static Material stone;

    public static Material metal;

    public Material wood_;
    public Material stone_;
    public Material metal_;
    // Start is called before the first frame update
    void Start()
    {
        wood = wood_;
        stone = stone_;
        metal = metal_;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
