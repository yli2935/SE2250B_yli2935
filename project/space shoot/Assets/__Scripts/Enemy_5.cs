using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_5 : Enemy
{
    public Vector3 linerSpeed;
    public Vector3 circleDot;

    private float radius;
    private Rigidbody body;
    private float speed;
    private float omga;
    // Start is called before the first frame update
    public override void Move()
    {
        Vector3 fp = circleDot - gameObject.transform.position;//向心力矢量，但此时向量模不正确
        fp = fp.normalized * body.mass * omga;//纠正向量的模
        body.AddForce(fp, ForceMode.Force);
        base.Move();
    }
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody>();
        body.velocity = linerSpeed;
        radius = (circleDot - gameObject.transform.position).magnitude;
        speed = linerSpeed.magnitude;
        omga = speed * speed / radius;
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }
 
}
