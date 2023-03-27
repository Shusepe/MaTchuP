using UnityEngine;

public class Order
{
    private bool mayonnaise;
    private bool ketchup;
    private bool mustard;

    private Sprite orderSprite;

    public Order(bool mayonnaise, bool ketchup, bool mustard) 
    {
        this.mayonnaise = mayonnaise;
        this.ketchup = ketchup;
        this.mustard = mustard;
    }

    public bool getMayonnaise() 
    {
        return mayonnaise;
    }
    
    public bool getKetchup() 
    {
        return ketchup;
    }
    
    public bool getMustard() 
    {
        return mustard;
    }
    
    public Sprite getSprite() 
    {
        return orderSprite;
    }

    //public Order(bool mayonnaise, bool ketchup, bool mustard)
    //{
    //    this.mayonnaise = mayonnaise;
    //    this.ketchup = ketchup;
    //    this.mustard = mustard;
    //    this.orderSprite = getOrderSprite(mayonnaise, ketchup, mustard);
    //}


    //private Sprite getOrderSprite(bool mayonnaise, bool ketchup, bool mustard)
    //{
    //    if (mayonnaise && ketchup && mustard)
    //    {
    //        return getSpriteByID(n);
    //    }

    //    if (mayonnaise && !ketchup && mustard)
    //    {
    //        return getSpriteByID(n + 1);
    //    }
    //}

}
