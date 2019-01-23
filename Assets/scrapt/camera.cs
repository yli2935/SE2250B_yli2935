using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private GameObject camera_0;
    private GameObject camera_1;
    void Start()
    {
        camera_0 = GameObject.Find("Main Camera");
        camera_1 = GameObject.Find("Camera");
        camera_1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (camera_0.active == true) {
                camera_0.SetActive(false);
                camera_1.SetActive(true);
            }
            else
            {
                camera_0.SetActive(true);
                camera_1.SetActive(false);
            }
            
        }
        

    }


}
