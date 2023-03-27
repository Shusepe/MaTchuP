public class Order
{
    private bool mayonnaise;
    private bool ketchup;
    private bool mustard;

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
}
