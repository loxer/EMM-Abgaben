using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    /*
     * Tutorial used: https://youtu.be/JivuXdrIHK0
     */
    public static bool GameIsCurrentlyPaused = false;
    // public Button pauseButton;
    [SerializeField] GameObject pauseMenuUI;

    void Start () {
        // Button btn = pauseButton.GetComponent<Button>();
        // btn.onClick.AddListener(Pause);
    }
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsCurrentlyPaused)
            {
                Return();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Return() //public to be able to call it from the button
    {
        pauseMenuUI.SetActive(false); //disable Pause Menu (Child of the Canvas this script is linked to 
        Time.timeScale = 1f; // normal time
        GameIsCurrentlyPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true); //enable Pause Menu (Child of the Canvas this script is linked to 
        Time.timeScale = 0f; // Stop time
        GameIsCurrentlyPaused = true;
    }

    public void Restart()
    {
        Time.timeScale = 1f; // normal time
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //load any scene (in this case menu scene)
    }
}
