using UnityEngine;
using TMPro;

public class PauseScore : MonoBehaviour
{
    public Score highScore;
    private TextMeshProUGUI textMeshPointsH;

    public void Awake()
    {
        textMeshPointsH = GetComponent<TextMeshProUGUI>();
    }

    public void OnEnable()
    {
        float points = highScore.points;
        textMeshPointsH.text = points.ToString("0");
    }

}
