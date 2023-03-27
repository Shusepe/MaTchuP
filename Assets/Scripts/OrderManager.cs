using UnityEngine;

public class OrderManager : MonoBehaviour
{
    private Order currentOrder;
    private Order olderOrder;
    bool randomMayo;
    bool randomKet;
    bool randomMus;

    public void SetFirstOrder()
    {
        currentOrder = CreateRandomOrder();
        olderOrder = currentOrder;
    }

    public Order GetCurrentOrder() 
    {
        return currentOrder;
    } 
    
    public Order GetOlderOrder() 
    {
        return olderOrder;
    }

    public void UpdateOrders()
    {
        olderOrder = currentOrder;
        currentOrder = CreateRandomOrder();
    }

    Order CreateRandomOrder()
    {
        randomMayo = Random.value < 0.5f;
        randomKet = Random.value < 0.5f;
        randomMus = Random.value < 0.5f;

        Order newOrder = new Order(randomMayo, randomKet, randomMus);

        return newOrder;
    }
}
