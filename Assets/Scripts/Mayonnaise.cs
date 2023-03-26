using UnityEngine;

public class Mayonnaise : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);

        Destroy(gameObject, .8f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("HotDog"))
        {
            Destroy(gameObject);
        }
    }
}
