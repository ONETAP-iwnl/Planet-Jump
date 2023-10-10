using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [Header("����")]
    public float baseScorePerSecond = 100.0f; // ������� ���������� ����� � �������
    [Header("����� UI")]
    public Text scoreText; // ������ �� ��������� ���� ��� ����������� �����
    public Text diedScoreText;
    public GameObject diedCanvas;
    private float currentScore = 0.0f;
    private bool isScoring = false;
    private float bonusScoreMultiplier = 6.0f; // ��������� ��� �������� �����
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
                Debug.Log("���������� �� 10 ������");
            }
            else
            {
                currentScore += baseScorePerSecond * Time.deltaTime;
                Debug.Log("������� ����");
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
