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
            //colliderHotDog = instanceHotDog.AddComponent<BoxCollider2D>();
            //colliderHotDog.size = new Vector2((float)8, (float)4);
            //colliderHotDog.offset = new Vector2((float)-0.1, (float)-0.6);

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
