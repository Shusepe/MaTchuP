using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKetchup : MonoBehaviour
{
    public GameObject ketchup;
    public GameObject instanceKetchup;

    public CircleCollider2D colliderKetchup;

    public void SpawnKetc()
    {
        instanceKetchup = Instantiate(ketchup);
        colliderKetchup = instanceKetchup.AddComponent<CircleCollider2D>();
    }
}
