using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour
{
    public AudioSource music;

    public GameObject minVolume;
    public GameObject medVolume;
    public GameObject higVolume;

    public void decreaseVolume() 
    {
        music.GetComponent<AudioSource>().volume -= 0.25f;
    }
    
    public void increaseVolume() 
    {
        music.GetComponent<AudioSource>().volume += 0.25f;
    }

    public void Update()
    {
        if (music.GetComponent<AudioSource>().volume == 0)
        {
            minVolume.SetActive(false);
            medVolume.SetActive(false);
            higVolume.SetActive(false);
        }
        
        if (music.GetComponent<AudioSource>().volume < 0.5f && music.GetComponent<AudioSource>().volume > 0)
        {
            minVolume.SetActive(true);
            medVolume.SetActive(false);
            higVolume.SetActive(false);
        }

        if (music.GetComponent<AudioSource>().volume == 0.5f)
        {
            minVolume.SetActive(true);
            medVolume.SetActive(true);
            higVolume.SetActive(false);
        }

        if (music.GetComponent<AudioSource>().volume > 0.5f)
        {
            minVolume.SetActive(true);
            medVolume.SetActive(true);
            higVolume.SetActive(true);
        }

        Debug.Log(music.GetComponent<AudioSource>().volume);
    }
}
