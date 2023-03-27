using UnityEngine;

public class BreadEscalatorAnim : MonoBehaviour
{
    public float speed;
    private Renderer rend;

    void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float offset = Time.time * speed;
        rend.material.mainTextureOffset = new Vector2(0, offset);
    }
}
