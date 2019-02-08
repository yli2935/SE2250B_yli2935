using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float forceScal=5;
    private Rigidbody rb;
    private int count;
    private int number;
    public Text countText;
    public int point
    {
        get { return number; }
        set { number = value; }
    }
    
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
   
    private void OnTriggerEnter(Collider other)  
    {
        if (other.gameObject.tag == "pickUp"&&other.GetComponent<MeshRenderer>().material.GetColor("_Color")==Color.green) { point=1; }
        else if(other.gameObject.tag == "pickUp" && other.GetComponent<MeshRenderer>().material.GetColor("_Color") == Color.red) { point=4; } 
        else { point=2; }
        Destroy(other.gameObject);
        SetCountText();
    }
    void SetCountText()
    {
        count += point;
        countText.text = "Count: " + count.ToString();
    }

    
    
}
