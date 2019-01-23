using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour
{
    public GameObject cube;
    public GameObject capsule;
    public GameObject sphere;
  
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {    

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);   
            RaycastHit hit;    
            if (Physics.Raycast(ray, out hit))    
            {
                if (hit.collider.gameObject.name == "Sphere")   
                {
                    sphere.gameObject.transform.position = new Vector3(0.65f,1.84f,-0.33f);
                }
                else if(hit.collider.gameObject.name == "Capsule")
                {
                    capsule.gameObject.transform.position = new Vector3(-1.09f, 2f, 0.46f);
                }
                else if(hit.collider.gameObject.name == "cube")
                {
                    cube.gameObject.transform.position = new Vector3(-0.3f, 2.29f, 0.7275705f);
                }
            }
        }
        
        
    }
}
