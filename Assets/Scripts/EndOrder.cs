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
    public GameObject strikeOut;
    public GameObject resumeButton;
    public GameObject resumeImg;
    public GameObject canvas;

    public GameManager gameManager;

    public GameObject[] strike;

    public Score score;

    private AudioSource audioSource;
    [SerializeField] private AudioClip wrongSound;
    [SerializeField] private AudioClip rigthSound;
    [SerializeField] private AudioClip loseSound;

    public void Start()
    {
        strike = new GameObject[4] { strike1, strike2, strike3, strikeOut };
        audioSource = GetComponent<AudioSource>();
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("HotDog"))
        {
            //OrderManager orderManager = gameObject.GetComponent<OrderManager>();

            //Order currentOrder = orderManager.GetCurrentOrder();

            if (collision.gameObject.GetComponent<HotDog>().DressingMatch(true, true, true/*currentOrder.getMayonnaise(), currentOrder.getKetchup(), currentOrder.getMustard()*/))
            {
                score.PlusPoints(totalPoints);
                audioSource.PlayOneShot(rigthSound);
            }
            else
            {
                score.PlusPoints(amountPoints);
                audioSource.PlayOneShot(wrongSound);

                Instantiate(strike[strikeCount], canvas.transform);
                strikeCount++;

                //-----------Lose------------
                if (strikeCount == 4)
                {
                    //for (int i = 0; i <= strikeCount; i++) 
                    //{
                    //    Destroy(strike[i]);
                    //}

                    gameManager.pauseButton();
                    resumeButton.SetActive(false);
                    resumeImg.SetActive(false);
                    audioSource.PlayOneShot(loseSound);
                }
            }

            //orderManager.UpdateOrders();
        }
        Destroy(collision.gameObject);
    }
}
