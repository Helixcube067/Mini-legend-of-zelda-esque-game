using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotDectection : MonoBehaviour {

    public GameObject replacementLocation;
    public GameObject replacement;
    public GameObject replaKey;

    
    //public GameObject ugh;

    /* this code checks to see if it hits the pot
     * if it hits a pot then it makes a random int from 0 to 100 '
     * checks if the random int is above 50 or not and then makes an object at the destroyed objects location
     */ 
    //this script is the one acting up lol
    public void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Pot") {
            Vector3 positional = replacementLocation.transform.position;
            int decider = Random.Range(0, 100);
             //can just collisionInfo.gameObject.SetActive(false)
            Debug.Log(decider);
            if (decider > 1)
            {
                Instantiate(replacement, positional, Quaternion.identity);
                Debug.Log("Attempted to create object");
            }
            else{
                Instantiate(replaKey, positional, Quaternion.identity);
            }
            Destroy(collisionInfo.gameObject);
        }
    }
}