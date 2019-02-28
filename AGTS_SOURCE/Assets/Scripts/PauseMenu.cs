using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //Pokud se zmáčkne Escape tak se hra pauzne pokud je už pauznutá tak se pustí (resume)
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
                Cursor.visible = true;
            }
        }
    }
    public void Resume() //Obnovení scény (resume)
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    void Pause() // Zastavení scény
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = false;
    }

    public void LoadMenu() //Nahrání do Main menu
    {
        PauseMenu.GameIsPaused = false;
        Debug.Log("Loading Menu");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Cursor.visible = true;

    }

    public void QuitGame() //Vypnutí hry
    {
        Debug.Log("Quiting"); //Applikace se nevypne uvnitř unity takže pro zjištění zda QuitGame voláme se píše Debug.Log
        Application.Quit();
    }
    
}
