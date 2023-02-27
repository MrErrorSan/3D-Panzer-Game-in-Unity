using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectToSpawn1;
    public GameObject ObjectToSpawn2;
    public Vector3 offSet1 = new(0, 0, 0);
    public Vector3 offSet2 = new(0, 0, 0);
    public float timeToSpawn1;
    public float timeToSpawn2;
    private float currentTimeToSpawn1;
    private float currentTimeToSpawn2;
    // Start is called before the first frame update 
    void Start()
    {
        currentTimeToSpawn1 = timeToSpawn1-2;
        currentTimeToSpawn2 = timeToSpawn2;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTimeToSpawn1>0)
        {
            currentTimeToSpawn1 -= Time.deltaTime;

        }
        else
        {
            Instantiate(ObjectToSpawn1, offSet1, transform.rotation);
            currentTimeToSpawn1 = timeToSpawn1;
        }
        if(currentTimeToSpawn2 > 0)
        {
            currentTimeToSpawn2 -= Time.deltaTime;

        }
        else
        {
            Instantiate(ObjectToSpawn2, offSet2, transform.rotation);
            currentTimeToSpawn2 = timeToSpawn2;
        }

    }
    private void LateUpdate()
    {

    }
    private void spawnObject()
    {
        Instantiate(ObjectToSpawn1, offSet1, transform.rotation);
        Instantiate(ObjectToSpawn2, offSet2, transform.rotation);
    }
}
