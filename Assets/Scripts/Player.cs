using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float c_thrust;
    public float c_maxSpeedY_Up;
    public float c_maxSpeedY_Down;

    void Start()
    {
        
    }

    void Update()
    {   
        Rigidbody2D f_rigid = GetComponent<Rigidbody2D>();

        if(Input.GetKeyDown(KeyCode.Space))
        {
           f_rigid.AddForce(Vector2.up * c_thrust, ForceMode2D.Force); 
        }

        if (f_rigid.velocity.y > c_maxSpeedY_Up)
        {
            f_rigid.velocity = new Vector2(0f, c_maxSpeedY_Up);
        }
        if (f_rigid.velocity.y < c_maxSpeedY_Down)
        {
            f_rigid.velocity = new Vector2(0f, c_maxSpeedY_Down);
        }
    }
}
