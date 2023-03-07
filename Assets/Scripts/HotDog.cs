using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotDog : MonoBehaviour
{
    private int hotDogID;

    public float speed;
    //public float plus;

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

    void Update()
    {
        //plus += 1;

        transform.Translate(speed * Time.deltaTime /* x plus*/, 0, 0);

        if (mayonnaise == true) 
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hotDogMa;
            hotDogID = 1;
        };
        
        if (ketchup == true) 
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hotDogK;
            hotDogID = 2;
        };

        if (mustard == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hotDogMu;
            hotDogID = 3;
        };

        if (ketchup == true && mayonnaise == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hotDogKMa;
            hotDogID = 4;
        };

        if (ketchup == true && mustard == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hotDogKMu;
            hotDogID = 5;
        };

        if (mayonnaise == true && mustard == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hotDogMM;
            hotDogID = 6;
        };

        if (ketchup == true && mayonnaise == true && mustard == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = full;
            hotDogID = 7;
        };

        //Destroy(gameObject, 8f);
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
