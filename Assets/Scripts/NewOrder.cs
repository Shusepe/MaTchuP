using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewOrder : MonoBehaviour
{
    public bool otherOrder = true;

    public SpawnHotDog spawnOrder;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("HotDog"))
        {
            spawnOrder.Order(otherOrder);
        }
    }
}
