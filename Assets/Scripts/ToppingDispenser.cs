using UnityEngine;

public class ToppingDispenser : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Transform spawnPosition;

    private Animator animator;
    private AudioSource audioSource;

    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        Instantiate(prefabToSpawn, spawnPosition.position, Quaternion.identity);
        animator.SetTrigger("Press");
        audioSource.Play();
    }
}
