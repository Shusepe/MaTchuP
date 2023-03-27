using UnityEngine;
using UnityEngine.UI;

public class SpriteManager : MonoBehaviour
{
    public Sprite orderMa;
    public Sprite orderK;
    public Sprite orderMu;
    public Sprite orderKMa;
    public Sprite orderKMu;
    public Sprite orderMM;
    public Sprite orderEmpty;
    public Sprite orderFull;

    public OrderManager orderManager;

    private Image sourceImage;

    public void Start()
    {
        sourceImage = GameObject.Find("OrderOne").GetComponent<Image>();
    }
    
    public void UpdateOrderImage()
    {
        Order currentOrder = orderManager.GetCurrentOrder();

        if (currentOrder.getMayonnaise() == true)   
        {
            sourceImage.sprite = orderMa;
        };

        if (currentOrder.getKetchup() == true)
        {
            sourceImage.sprite = orderK;
        };

        if (currentOrder.getMustard() == true)
        {
            sourceImage.sprite = orderMu;
        };

        if (currentOrder.getMayonnaise() == true && currentOrder.getKetchup() == true)
        {
            sourceImage.sprite = orderKMa;
        };

        if (currentOrder.getMustard() == true && currentOrder.getKetchup() == true)
        {
            sourceImage.sprite = orderKMu;
        };

        if (currentOrder.getMayonnaise() == true && currentOrder.getMustard() == true)
        {
            sourceImage.sprite = orderMM;
        };

        if (currentOrder.getMayonnaise() == true && currentOrder.getKetchup() == true && currentOrder.getMustard() == true)
        {
            sourceImage.sprite = orderFull;
        };

        if (currentOrder.getMayonnaise() == false && currentOrder.getKetchup() == false && currentOrder.getMustard() == false)
        {
            sourceImage.sprite = orderEmpty;
        };
    }
}
