using UnityEngine;

public class NewHotDog : MonoBehaviour
{
    public bool otherOrder = true;

    public SpawnHotDog spawnOrder;
    public OrderManager orderManager;
    public SpriteManager orderSpriteManager;

    public Animator orderAnimator;
    public Animator ropeAnimator;

    private void Start()
    {
        orderManager.SetFirstOrder();
        orderSpriteManager.UpdateOrderImage();

        orderAnimator.SetTrigger("NewOrder");
        ropeAnimator.SetTrigger("MoveRope");
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("HotDog"))
        {
            spawnOrder.Order(otherOrder);
            orderManager.UpdateOrders();
            orderSpriteManager.UpdateOrderImage();

            orderAnimator.SetTrigger("NewOrder");
            ropeAnimator.SetTrigger("MoveRope");
        }
    }
}
