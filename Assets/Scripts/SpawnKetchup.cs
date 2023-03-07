using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKetchup : MonoBehaviour
{
    public GameObject ketchup;
    public GameObject instanceKetchup;

    public CircleCollider2D colliderKetchup;

    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SpawnKetc()
    {
        instanceKetchup = Instantiate(ketchup);
        colliderKetchup = instanceKetchup.AddComponent<CircleCollider2D>();

        audioSource.Play();
    }
}
