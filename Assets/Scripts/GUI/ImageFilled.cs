using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFilled : MonoBehaviour
{
    public Image image;
    public float shrinkDuration = 0.1f;
    [SerializeField]
    GameObject DiedCanvas;
    [SerializeField]
    GameObject GameCanvas;

    private void Start()
    {
        StartCoroutine(ShrinkAndCallMethod());
    }

    private IEnumerator ShrinkAndCallMethod()
    {
        float currentFillAmount = image.fillAmount;
        float targetFillAmount = 0f;
        float elapsedTime = 0f;

        while (elapsedTime < shrinkDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / shrinkDuration;

            image.fillAmount = Mathf.Lerp(currentFillAmount, targetFillAmount, t);

            yield return null;
        }
        DeadScene();
        
    }

    public void DeadScene()
    {
        Time.timeScale = 0;
        GameCanvas.SetActive(false);
        DiedCanvas.SetActive(true);
    }
}
