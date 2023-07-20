using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Circle _circle;
    [SerializeField] private TMP_Text _score;

    private void OnEnable()
    {
        _circle.ScoreChanged += OnScoreChanged;
    }

    private void OnDisable()
    {
        _circle.ScoreChanged -= OnScoreChanged;
    }

    private void OnScoreChanged(int score)
    {
        _score.text = score.ToString();

    }


}
