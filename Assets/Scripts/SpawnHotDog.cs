using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHotDog : MonoBehaviour
{
    public GameObject hotDog;
    public GameObject instanceHotDog;

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

            if (hotDog.GetComponent<HotDog>().speed < 7)
            {
                hotDog.GetComponent<HotDog>().speed += (float)0.5;
            }

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
