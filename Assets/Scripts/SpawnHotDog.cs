using UnityEngine;

public class SpawnHotDog : MonoBehaviour
{
    public GameObject hotDog;
    public Animator escalatorAnimator;

    public void Spawn()
    {
        Instantiate(hotDog);

        if (hotDog.GetComponent<HotDog>().speed < 7)
        {
            hotDog.GetComponent<HotDog>().speed += (float)0.5;
            escalatorAnimator.speed += 0.15f;
        }
    }
}
