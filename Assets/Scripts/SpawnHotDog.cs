using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHotDog : MonoBehaviour
{
    public GameObject hotDog;
    public GameObject instanceHotDog;

    public BoxCollider2D colliderHotDog;

    public bool anotherOrder = true;

    void Update()
    {
        Spawn();
    }

    public void Spawn()
    {
        if (anotherOrder == true)
        {
            instanceHotDog = Instantiate(hotDog);
            colliderHotDog = instanceHotDog.AddComponent<BoxCollider2D>();
            colliderHotDog.size = new Vector2((float)0.4, (float)0.3);

            anotherOrder = false;
        }
    }

    public void Order(bool otherOrder)
    {
        if (otherOrder == true) 
        {
            anotherOrder = otherOrder;
        }
    }
}
