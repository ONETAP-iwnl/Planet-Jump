using UnityEngine.UI;
using UnityEngine;
using JetBrains.Annotations;

public class ScoreManager : MonoBehaviour
{
    [Header("����")]
    public float baseScorePerSecond = 0.000000000000000000001f; // ������� ���������� ����� � �������
    [Header("����� UI")]
    public Text scoreText; // ������ �� ��������� ���� ��� ����������� �����
    public Text diedScoreText;
    public GameObject diedCanvas;
    private float currentScore = 0.0f;
    private bool isScoring = false;
    private float bonusScoreMultiplier = 6.0f; // ��������� ��� �������� �����
    private float bonusScoreDuration = 10.0f; // ������������ �������� �����
    private float bonusScoreTimer = 0.0f;

    private void OnEnable() 
    {
        TakeSpeedBonus.OnSpeedBonus += IncreaseScoreWithBonus;
    }


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

        GameObject bonusObject = GameObject.FindWithTag("SpeedBonus");
        if (bonusObject != null) 
        {
            Destroy(bonusObject);
        }
    }
    private void OnDisable()
    {
        TakeSpeedBonus.OnSpeedBonus -= IncreaseScoreWithBonus;
    }
}