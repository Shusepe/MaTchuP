using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float points;
    public TextMeshProUGUI textMeshPoints;

    public void Start()
    {
        textMeshPoints = GetComponent<TextMeshProUGUI>();
    }

    public void Update()
    {
        textMeshPoints.text = points.ToString("0");
    }

    public void PlusPoints(float entryPoints) 
    {
        points += entryPoints;
    }

    public void equalPoints(float highScore) 
    {
        highScore = points;
    }
}
