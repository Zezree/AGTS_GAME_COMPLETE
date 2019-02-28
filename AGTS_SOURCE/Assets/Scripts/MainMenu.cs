using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;


    }
    //Ovládání Main menu
    public void PlayGame() //Nahární do scény kde je Hra
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;

    }

    public void QuitGame () //Vypnutí applikace
    {
        Debug.Log("Quit"); //Applikace se nevypne uvnitř unity takže pro zjištění zda QuitGame voláme se píše Debug.Log
        Application.Quit(); 
    }
}
