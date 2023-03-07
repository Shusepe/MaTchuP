using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOrder : MonoBehaviour
{
    public float amountPoints;
    public float totalPoints;

    public int strikeCount = 0;

    public GameObject strike1;
    public GameObject strike2;
    public GameObject strike3;

    public GameObject[] strike;

    public Score score;

    public void Start()
    {
        strike = new GameObject[3] { strike1, strike2, strike3 };
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("HotDog"))
        {
            OrderManager orderManager = gameObject.GetComponent<OrderManager>();

            Order currentOrder = orderManager.GetCurrentOrder();

            if (collision.gameObject.GetComponent<HotDog>().DressingMatch(currentOrder.getMayonnaise(), currentOrder.getKetchup(), currentOrder.getMustard()))
            {
                score.PlusPoints(totalPoints);
            }
            else
            {
                score.PlusPoints(amountPoints);

                Instantiate(strike[strikeCount]);
                strikeCount++;
            }

            orderManager.UpdateOrders();
        }
        Destroy(collision.gameObject);
    }
}
