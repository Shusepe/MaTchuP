using UnityEngine;

public class SpawnHotDog : MonoBehaviour
{
    public GameObject hotDog;
    public Animator escalatorAnimator;

    void Start()
    {
        hotDog.GetComponent<HotDog>().speed = 2.0f;
		escalatorAnimator.speed = 0.1f;
    }

    public void Spawn()
    {
        Instantiate(hotDog);

        if (hotDog.GetComponent<HotDog>().speed < 7)
        {
            hotDog.GetComponent<HotDog>().speed += 0.5f;
            escalatorAnimator.speed += 0.35f;
        }
    }
}
