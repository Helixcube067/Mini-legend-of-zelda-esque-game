using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorBehaviour : MonoBehaviour
{
    public Inventory items;
    public Rigidbody wall;

    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            if(items.GetKeys() > 0)
            {
                items.TakeKey();
                Destroy(wall);
            }
            else
            {
                Debug.Log("You have no keys");
            }
        }
    }
}
