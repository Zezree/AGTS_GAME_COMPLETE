using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score_counter : MonoBehaviour
{
    //Score a jeho převedení do textu tak aby se mohlo zobrazovat
    public Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + enemyAi.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + enemyAi.score.ToString();

    }
}
