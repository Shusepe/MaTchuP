using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float points;
    public TextMeshProUGUI textMesh;

    public void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>(); 
    }

    public void Update()
    {
        textMesh.text = points.ToString("0");
    }

    public void PlusPoints(float entryPoints) 
    {
        points += entryPoints;
    }
}
