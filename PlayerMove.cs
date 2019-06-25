using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //this script is fine as well
    //Checks if WASD was pressed and moves in that direction
    public int sped;
    public Rigidbody rb;
    public float gravity;
    void FixedUpdate()
    {
        rb.AddForce(Vector3.down * gravity * rb.mass);
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(0, 0, sped);
        }

        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector3(0, 0, -(sped));
            //rb.AddForce(0, 0, -950 * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {

            rb.velocity = new Vector3(-(sped), 0, 0);
            //rb.AddForce(-950 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {

            rb.velocity = new Vector3(sped, 0, 0);
            //rb.AddForce(950 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("space"))
        {

            rb.velocity = new Vector3(0, 0, 0);
            //rb.AddForce(950 * Time.deltaTime, 0, 0);
        }
    }
}
