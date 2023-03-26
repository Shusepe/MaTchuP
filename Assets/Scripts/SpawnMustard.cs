using UnityEngine;

public class SpawnMustard : MonoBehaviour
{
    public GameObject mustard;

    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SpawnMust()
    {
        Instantiate(mustard);

        audioSource.Play();
    }
}
