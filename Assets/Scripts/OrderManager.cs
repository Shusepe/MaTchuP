using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
    private Order currentOrder;
    private Order nextOrder;

    void Start()
    {
        //Darles valores iniciales a las variables

        currentOrder = CreateRandomOrder();
        nextOrder = CreateRandomOrder();
    }

    public Order GetCurrentOrder() 
    {
        return currentOrder;
    }

    public void UpdateOrders()
    {
        currentOrder = nextOrder;
        nextOrder = CreateRandomOrder();
    }

    Order CreateRandomOrder() 
    {
        //Crear HotDog de manera Random
        Order newOrder = new Order(true, false, true);

        return newOrder;
    }
}
