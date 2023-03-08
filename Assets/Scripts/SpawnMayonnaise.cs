using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMayonnaise : MonoBehaviour
{
    public bool isPressing;

    public GameObject mayonnaise;
    public GameObject instanceMayonnaise;

    public CircleCollider2D colliderMayonnaise;

    public AudioSource audioSource;

    private Animator anim;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    public void SpawnMayo() 
    {
        isPressing = true;

        instanceMayonnaise = Instantiate(mayonnaise);
        colliderMayonnaise = instanceMayonnaise.AddComponent<CircleCollider2D>();

        anim.SetBool("IsPressing", isPressing);

        audioSource.Play();

    }
}
