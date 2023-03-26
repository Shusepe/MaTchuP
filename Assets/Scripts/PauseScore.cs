using UnityEngine;
using TMPro;

public class PauseScore : MonoBehaviour
{
    public float points;

    public Score highScore;
    public TextMeshProUGUI textMeshPointsH;

    public void Start()
    {
        textMeshPointsH = GetComponent<TextMeshProUGUI>();
    }

    public void Update()
    {
        points = highScore.points;
        textMeshPointsH.text = points.ToString("0");
    }

}
