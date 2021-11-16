using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyType2 : MonoBehaviour
{
    public int health;

    public TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {
        healthText = transform.Find("Canvas/Health (TMP)").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString("F0");
        death();
    }
  
    void death()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            Score.score = Score.score + 200;
            Coin.coin = Coin.coin + Random.Range(750, 1250);
            SceneTransition.enemyCount -= 1;
        }
    }
}
