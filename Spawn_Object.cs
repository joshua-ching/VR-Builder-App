using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Object : MonoBehaviour
{


    public GameObject spawnObject;


    public Vector3 spawnLocation = new Vector3(1, 4, -2);

    //time before another object can be spawned
    float spawnSpeed = 0.4f;

    bool canSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button_Behavior>().ButtonPressed += Spawn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        if (!canSpawn)
        {
            return;
        }
        StartCoroutine(SpawnLag());
       print("spawn");
       GameObject block = Instantiate(spawnObject, transform.position + spawnLocation, Quaternion.identity) as GameObject;
    }

    IEnumerator SpawnLag()
    {
        canSpawn = false;
        yield return new WaitForSeconds(spawnSpeed);
        canSpawn = true;
    }
}
