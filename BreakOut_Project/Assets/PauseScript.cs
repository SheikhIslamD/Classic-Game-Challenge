using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{

    public GameObject pauseMenu;
    public static bool isPaused;
    public TextMeshProUGUI pauseText;
    public GameObject resumeButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) || Input.GetKeyDown(KeyCode.P))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void PauseGame()
    {
        resumeButton.SetActive(true);
        pauseMenu.SetActive(true);
        isPaused = true;
        string text = "Paused";
        pauseText.text = text.ToString();
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        resumeButton.SetActive(false);
        pauseMenu.SetActive(false);
        isPaused = false;
        string text = " ";
        pauseText.text = text.ToString();
        Time.timeScale = 1;
    }
}
