using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMustard : MonoBehaviour
{
    public GameObject mustard;
    public GameObject instanceMustard;

    public CircleCollider2D colliderMustard;

    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SpawnMust()
    {
        instanceMustard = Instantiate(mustard);
        colliderMustard = instanceMustard.AddComponent<CircleCollider2D>();

        audioSource.Play();
    }
}
