using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float points;
    private TextMeshProUGUI textMeshPoints;

    void Awake()
    {
        textMeshPoints = GetComponent<TextMeshProUGUI>();
        textMeshPoints.text = points.ToString("0");
    }

    public void PlusPoints(float entryPoints) 
    {
        points += entryPoints;
        textMeshPoints.text = points.ToString("0");
    }
}
