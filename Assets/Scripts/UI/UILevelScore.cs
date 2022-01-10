using UnityEngine;
using TMPro;

public class UILevelScore : MonoBehaviour
{
    private const string SCORE_TEXT_TEMPLATE = "{0} pts";
    [SerializeField]
    private TextMeshProUGUI _scoreText;
    [SerializeField]
    private TextMeshProUGUI _levelText;
    
    void Start()
    {
        ArkanoidEvent.OnScoreUpdatedEvent += OnScoreUpdated;
    }
    
    private void OnDestroy()
    {
        ArkanoidEvent.OnScoreUpdatedEvent -= OnScoreUpdated;
    }
    
    private void OnScoreUpdated(int score, int totalScore)
    {
        _scoreText.text = string.Format(SCORE_TEXT_TEMPLATE, totalScore);
    }
}