using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yakuza : MonoBehaviour
{

    //problem with code: a LOT of swords that will eat up resources
    public int offseter;
    public GameObject player;
    public GameObject weapon;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown("up"))
        {
            if (weapon.activeInHierarchy == false)
            {
                Vector3 playerOffset = player.transform.position;
                weapon.transform.position = new Vector3((playerOffset.x + offseter), playerOffset.y, playerOffset.z);
                weapon.transform.rotation = Quaternion.Euler(180, 180, 180);
                weapon.SetActive(true);
            }
            else
            {
                Vector3 playerOffset = player.transform.position;
                float xCoord = playerOffset.x;
                Instantiate(weapon, new Vector3((xCoord + offseter), playerOffset.y, playerOffset.z), Quaternion.identity);
                weapon.transform.rotation = Quaternion.Euler(180, 180, 180);
            }
        }

        if (Input.GetKeyUp("up")){
            if (weapon.activeInHierarchy)
            {
                weapon.SetActive(false);
            }
        }

        if (Input.GetKey("down"))
        {
            Vector3 playerOffset = player.transform.position;
            float coords = playerOffset.x;
            Instantiate(weapon, new Vector3((coords - offseter), 0, 0), Quaternion.identity);
        }

        if (Input.GetKeyUp("down"))
        {
            if (weapon.activeInHierarchy)
            {
                weapon.SetActive(false);
            }
        }

        if (Input.GetKey("left"))
        {
            Vector3 playerOffset = player.transform.position;
            float coords = playerOffset.z;
            Instantiate(weapon, new Vector3(0, 0, (coords + offseter)), Quaternion.identity);
        }

        if (Input.GetKeyUp("left"))
        {
            if (weapon.activeInHierarchy)
            {
                weapon.SetActive(false);
            }
        }

        if (Input.GetKey("right"))
        {
            Vector3 playerOffset = player.transform.position;
            float coords = playerOffset.z;
            Instantiate(weapon, new Vector3(0, 0, (coords - offseter)), Quaternion.identity);
        }

        if (Input.GetKeyUp("right"))
        {
            if (weapon.activeInHierarchy)
            {
                weapon.SetActive(false);
            }
        }
    }
}