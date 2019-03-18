using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_4 : Enemy
{
    private float random;
    public override void Move()
    {
        Vector3 tempPos = pos;
        if (random < 5)
        {
            tempPos.x -= speed * Time.deltaTime;
            tempPos.y -= speed * Time.deltaTime;
        }
        else
        {
            tempPos.x += speed * Time.deltaTime;
            tempPos.y -= speed * Time.deltaTime;
        }


        pos = tempPos;
        if (bndCheck != null && (bndCheck.offDown||bndCheck.offLeft||bndCheck.offRight))
        {

            Destroy(gameObject);

        }
    }




    void Start()
    {
        random = Random.Range(0, 10);
        

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
