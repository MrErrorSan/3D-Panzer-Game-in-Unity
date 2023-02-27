using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public GameObject obj;
    public float afterTime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(obj, afterTime);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
