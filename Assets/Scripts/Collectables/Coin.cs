using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public static int coin;

    public TextMeshProUGUI coinText;


    // Start is called before the first frame update
    void Start()
    {
        coinText = transform.Find("Canvas/Coin (TMP)").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + coin.ToString("F0");
    }



}
