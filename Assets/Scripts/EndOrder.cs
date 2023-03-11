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
    public GameObject pauseImg;
    public GameObject canvas;

    public GameManager gameManager;

    public GameObject[] strike;

    public Score score;
    public OrderManager orderManager;

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
            Order currentOrder = orderManager.GetCurrentOrder();
            Order olderOrder = orderManager.GetOlderOrder();

            if (collision.gameObject.GetComponent<HotDog>().DressingMatch(olderOrder.getMayonnaise(), olderOrder.getKetchup(), olderOrder.getMustard()))
            {
                score.PlusPoints(totalPoints);
                audioSource.PlayOneShot(rigthSound);
            }
            else
            {
                score.PlusPoints(amountPoints);
                audioSource.PlayOneShot(wrongSound);

                strike[strikeCount].SetActive(true);

                //Instantiate(strike[strikeCount], canvas.transform);
                strikeCount++;

                //-----------Lose------------
                if (strikeCount == 4)
                {
                    //for (int i = 0; i <= strikeCount; i++) 
                    //{ 
                    //    strike[i].SetActive(false);
                    //}

                    strike[1].SetActive(false);
                    strike[2].SetActive(false);
                    strike[3].SetActive(false);


                    gameManager.pauseButton();
                    resumeButton.SetActive(false);
                    pauseImg.SetActive(false);
                    audioSource.PlayOneShot(loseSound);
                }
            }
        }
        Destroy(collision.gameObject);
    }
}
