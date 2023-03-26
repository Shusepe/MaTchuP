using UnityEngine;

public class SpawnKetchup : MonoBehaviour
{
    public GameObject ketchup;

    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SpawnKetc()
    {
        Instantiate(ketchup);

        audioSource.Play();
    }
}
