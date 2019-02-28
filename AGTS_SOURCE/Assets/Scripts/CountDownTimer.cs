using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour {
    
    //Zde je Counter za jak dlouho se hra vypne a započítá se skore - zatím se pouze resetne skore a celá scena
    public float Timer_text = 10f;
    private Text timerSeconds;


	// Use this for initialization
	void Start () {
        timerSeconds = GetComponent<Text>();

		
	}
	
	// Update is called once per frame
	void Update () {
        Timer_text -= Time.deltaTime;
        timerSeconds.text = "Time: " + Timer_text.ToString("f2");
        if (Timer_text <= 0)
        {
            enemyAi.score = 0;
            
            SceneManager.LoadScene("scéna");
            Timer_text = Timer_text;
            
        }
	}
}
