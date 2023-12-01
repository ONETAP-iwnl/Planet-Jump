using UnityEngine.UI;
using UnityEngine;
using JetBrains.Annotations;

public class ScoreManager : MonoBehaviour
{
    [Header("Счет")]
    public float baseScorePerSecond = 0.000000000000000000001f; // Базовое количество очков в секунду
    [Header("Текст UI")]
    public Text scoreText; // Ссылка на текстовое поле для отображения счета
    public Text diedScoreText;
    public GameObject diedCanvas;
    private float currentScore = 0.0f;
    private bool isScoring = false;
    private float bonusScoreMultiplier = 6.0f; // Множитель для бонусных очков
    private float bonusScoreDuration = 10.0f; // Длительность бонусных очков
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
            // Проверяем, идут ли бонусные очки
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

    // Вызывается при столкновении с префабом
    public void IncreaseScoreWithBonus()
    {
        // Устанавливаем таймер бонусных очков на 10 секунд
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