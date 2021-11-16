using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score;

    public TextMeshProUGUI scoreText;

    
    // Start is called before the first frame update
    void Start()
    {
        scoreText = transform.Find("Canvas/Score (TMP)").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString("F0");
      
    }
    

   
}
