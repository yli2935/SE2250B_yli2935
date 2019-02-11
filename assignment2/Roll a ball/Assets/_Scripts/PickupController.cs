using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    public GameObject prefab;
    private GameObject pre;
    // Start is called before the first frame update
    void Start()
    {
        for(float i = 0; i < 10; i++)
        {
            float pi = 3.14f;
            Vector3 position = new Vector3(6f*Mathf.Sin(i*pi/5.0f), 1, 6f * Mathf.Cos(i * pi / 5.0f));
            pre = Instantiate(prefab);
            pre.transform.position = position;
            if (i <= 3) { pre.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green); }
            else if (i >= 8) { pre.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red); }
            else { pre.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.blue); }

        }
    }
}
