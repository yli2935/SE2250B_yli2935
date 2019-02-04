using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float forceScal=5;
    private Rigidbody rb;
    private int count;
    public Text countText;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        
    }
    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        rb.AddForce(movement* forceScal);
        
    }
    private Color red = new Color(255, 0, 0);
    private void OnTriggerEnter(Collider other)  
    {
        if (other.gameObject.tag == "pickUp"&&other.GetComponent<MeshRenderer>().material.GetColor("_Color")==Color.green) { count = count + 1; }
        else if(other.gameObject.tag == "pickUp" && other.GetComponent<MeshRenderer>().material.GetColor("_Color") == Color.red) { count = count + 4; } 
        else { count += 2; }
        Destroy(other.gameObject);
        SetCountText();
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
}
