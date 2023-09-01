using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    GameObject Pause;
    [SerializeField]
    GameObject GameCanvas;

    public void OpenMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void Start()
    {
        Pause.SetActive(false);
    }
    
    public void PauseOn()
    {
        GameCanvas.SetActive(false);
        Pause.SetActive(true);
        Time.timeScale = 0;
    }

    public void PauseOff()
    {
        Pause.SetActive(false);
        GameCanvas.SetActive(true);
        Time.timeScale = 1;
    }
}
