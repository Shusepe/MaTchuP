using UnityEngine;

public class SpawnMayonnaise : MonoBehaviour
{
    public bool isPressing;

    public GameObject mayonnaise;

    public AudioSource audioSource;

    private Animator anim;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    public void SpawnMayo() 
    {
        //Instanciar por posicion de el boton

        isPressing = true;

        Instantiate(mayonnaise);

        //anim.SetBool("IsPressing", isPressing);

        audioSource.Play();

    }
}
