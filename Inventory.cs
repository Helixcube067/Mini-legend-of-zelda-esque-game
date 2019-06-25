using UnityEngine;

public class Inventory : MonoBehaviour {

    private int keyCollection;
    private int bombCollection;

    //This script is 100% fine and works so you don't have to mess with it
    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Key")
        {
            collisionInfo.gameObject.SetActive(false);
            keyCollection++;
            Debug.Log(keyCollection);
        }

        else if(collisionInfo.collider.tag == "Bomb")
        {
            collisionInfo.gameObject.SetActive(false);
            bombCollection++;
            Debug.Log(bombCollection);
        }
    }

    public int GetBombs()
    {
        return bombCollection;
    }

    public int AddBombs()
    {
        bombCollection++;
        return bombCollection;
    }

    public int TakeBomb()
    {
        bombCollection--;
        return bombCollection;
    }

    public int GetKeys()
    {
        return keyCollection;
    }

    public int TakeKey()
    {
        keyCollection--;
        return keyCollection;
    }

    public int AddKeys()
    {
        keyCollection++;
        return keyCollection;
    }
}
