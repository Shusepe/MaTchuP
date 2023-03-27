using UnityEngine;

public class HotDog : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public float speed = 2;

    public bool mayonnaise = false;
    public bool ketchup = false;
    public bool mustard = false;

    public Sprite hotDogMa;
    public Sprite hotDogK;
    public Sprite hotDogMu;
    public Sprite hotDogKMa;
    public Sprite hotDogKMu;
    public Sprite hotDogMM;
    public Sprite full;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        if (mayonnaise == true) 
        {
            spriteRenderer.sprite = hotDogMa;
        };
        
        if (ketchup == true) 
        {
            spriteRenderer.sprite = hotDogK;
        };

        if (mustard == true)
        {
            spriteRenderer.sprite = hotDogMu;
        };

        if (ketchup == true && mayonnaise == true)
        {
            spriteRenderer.sprite = hotDogKMa;
        };

        if (ketchup == true && mustard == true)
        {
            spriteRenderer.sprite = hotDogKMu;
        };

        if (mayonnaise == true && mustard == true)
        {
            spriteRenderer.sprite = hotDogMM;
        };

        if (ketchup == true && mayonnaise == true && mustard == true)
        {
            spriteRenderer.sprite = full;
        };
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Mayonnaise"))
        {
            mayonnaise = true;
        }

        if (collision.collider.CompareTag("Ketchup"))
        {
            ketchup = true;
        }

        if (collision.collider.CompareTag("Mustard"))
        {
            mustard = true;
        }
    }

    public bool DressingMatch(bool orderMayonnaise, bool orderKetchup, bool orderMustard) 
    {
        return orderMayonnaise == mayonnaise && orderKetchup == ketchup && orderMustard == mustard;
    }
}
