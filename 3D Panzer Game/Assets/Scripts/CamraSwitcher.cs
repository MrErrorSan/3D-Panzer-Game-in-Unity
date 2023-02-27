using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraSwitcher : MonoBehaviour
{
    public GameObject tps;
    public GameObject fps;
    // Start is called before the first frame update
    void Start()
    {
        tps.SetActive(true);
        fps.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            if(tps.activeSelf)
            {
                tps.SetActive(false);
                fps.SetActive(true);
            }
            else
            {
                tps.SetActive(true);
                fps.SetActive(false);
            }
        }
    }
}
