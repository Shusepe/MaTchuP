using UnityEngine;

public class NewHotDog : MonoBehaviour
{
    public SpawnHotDog spawnOrder;
    public OrderManager orderManager;
    public SpriteManager orderSpriteManager;

    public Animator orderAnimator;
    public Animator ropeAnimator;

    private void Start()
    {
        spawnOrder.Spawn();
        orderManager.SetFirstOrder();
        orderSpriteManager.UpdateOrderImage();

        orderAnimator.SetTrigger("NewOrder");
        ropeAnimator.SetTrigger("MoveRope");
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("HotDog"))
        {
            spawnOrder.Spawn();
            orderManager.UpdateOrders();
            orderSpriteManager.UpdateOrderImage();

            orderAnimator.SetTrigger("NewOrder");
            ropeAnimator.SetTrigger("MoveRope");
        }
    }
}
