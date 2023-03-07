using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotDog : MonoBehaviour
{

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
        };
        
        if (ketchup == true) 
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hotDogK;
        };

        if (mustard == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hotDogMu;
        };

        if (ketchup == true && mayonnaise == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hotDogKMa;
        };

        if (ketchup == true && mustard == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hotDogKMu;
        };

        if (mayonnaise == true && mustard == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hotDogMM;
        };

        if (ketchup == true && mayonnaise == true && mustard == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = full;
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

    //SpriteRender = getSpriteByID(1);

    public bool DressingMatch(bool orderMayonnaise, bool orderKetchup, bool orderMustard) 
    {
        return orderMayonnaise == mayonnaise && orderKetchup == ketchup && orderMustard == mustard;
    }
}
