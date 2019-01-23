using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
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
                if (hit.collider.gameObject.name == "Box"|| hit.collider.gameObject.name == "1"|| hit.collider.gameObject.name == "2"|| hit.collider.gameObject.name == "3"|| hit.collider.gameObject.name == "4")    //如果碰撞的点所在的物体的名字是“StartButton”(collider就是检测碰撞所需的碰撞器)
                {
                    this.gameObject.transform.Rotate(0, 5, 0);
             
                }
            }
        } 
    }
}
