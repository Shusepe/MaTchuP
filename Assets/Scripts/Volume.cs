using UnityEngine;

public class Volume : MonoBehaviour
{
    public GameObject minVolume;
    public GameObject medVolume;
    public GameObject higVolume;

    private sbyte volumeLevel = 3;

    public void decreaseVolume() 
    {
        volumeLevel--;
        UpdateVolume();
    }
    
    public void increaseVolume()
    {
        volumeLevel++;
        UpdateVolume();
    }

    private void UpdateVolume()
    {
        if (volumeLevel < 0)
            volumeLevel = 0;

        if (volumeLevel > 3)
            volumeLevel = 3;

        switch (volumeLevel)
        {
            case 0:
                AudioListener.volume = 0.0f;

                minVolume.SetActive(false);
                medVolume.SetActive(false);
                higVolume.SetActive(false);
                break;
            case 1:
                AudioListener.volume = 0.3f;

                minVolume.SetActive(true);
                medVolume.SetActive(false);
                higVolume.SetActive(false);
                break;
            case 2:
                AudioListener.volume = 0.6f;

                minVolume.SetActive(true);
                medVolume.SetActive(true);
                higVolume.SetActive(false);
                break;
            case 3:
                AudioListener.volume = 1.0f;

                minVolume.SetActive(true);
                medVolume.SetActive(true);
                higVolume.SetActive(true);
                break;
        }
    }
}
