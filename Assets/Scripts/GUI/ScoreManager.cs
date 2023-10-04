using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // ������ �� ��������� ���� ��� ����������� �����
    public float scorePerSecond = 1000.0f; // ���������� �����, ����������� � �������
    public Text diedScoreText;
    public GameObject diedCanvas;
    public float baseScorePerSecond = 1000.0f; // ������� ���������� ����� � �������
    private float currentScore = 0.0f;
    private bool isScoring = false;
    private float bonusScoreMultiplier = 2.0f; // ��������� ��� �������� �����
    private float bonusScoreDuration = 10.0f; // ������������ �������� �����
    private float bonusScoreTimer = 0.0f;

    private void Start()
    {
        StartScoring();
    }

    private void Update()
    {
        if (isScoring)
        {
            // ���������, ���� �� �������� ����
            if (bonusScoreTimer > 0)
            {
                currentScore += (baseScorePerSecond * bonusScoreMultiplier) * Time.deltaTime;
                bonusScoreTimer -= Time.deltaTime;
            }
            else
            {
                currentScore += baseScorePerSecond * Time.deltaTime;
            }

            int roundedScore = Mathf.RoundToInt(currentScore);
            scoreText.text = roundedScore.ToString("N0");
            diedScoreText.text = roundedScore.ToString("N0");
        }
    }

    public void StartScoring()
    {
        isScoring = true;
    }

    public void StopScoring()
    {
        isScoring = false;
        diedCanvas.SetActive(true);
    }

    // ���������� ��� ������������ � ��������
    public void IncreaseScoreWithBonus()
    {
        // ������������� ������ �������� ����� �� 10 ������
        bonusScoreTimer = bonusScoreDuration;
    }
}
