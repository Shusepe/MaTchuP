using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMayonnaise : MonoBehaviour
{
    public GameObject mayonnaise;
    public GameObject instanceMayonnaise;

    public CircleCollider2D colliderMayonnaise;

    public void SpawnMayo() 
    {
        instanceMayonnaise = Instantiate(mayonnaise);
        colliderMayonnaise = instanceMayonnaise.AddComponent<CircleCollider2D>();
    }
}
