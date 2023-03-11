using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHotDog : MonoBehaviour
{
    public bool otherOrder = true;

    public SpawnHotDog spawnOrder;
    public OrderManager orderManager;

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("HotDog"))
        {
            spawnOrder.Order(otherOrder);
            orderManager.UpdateOrders();
        }
    }
}
