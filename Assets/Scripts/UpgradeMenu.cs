using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeMenu : MonoBehaviour
{
    public static bool damageIsUnlocked;
    public static bool barrierHPIsUnlocked;

    
    [SerializeField]
    private Button damageButton;
    [SerializeField]
    private Button barrierHealthButton;
    
    [SerializeField]
    private GameObject upgradeCanvasObj;
    [SerializeField]
    private GameObject upgradeMenuObj;

    [SerializeField]
    private int barrierHealthCost;
    [SerializeField]
    private int damageCost;

    [SerializeField]
    private TextMeshProUGUI barrierCostText;
    [SerializeField]
    private TextMeshProUGUI damageCostText;
     

    // Update is called once per frame
    void Update()
    {
        BarrierCoinCheck();
        DamageCoinCheck();

        barrierCostText.text = "Cost: " + barrierHealthCost.ToString("F0");
        damageCostText.text = "Cost: " + damageCost.ToString("F0");

    }

    private void DamageCoinCheck()
    {
        if (Coin.coin < damageCost)
        {
            damageButton.interactable = false;
        }
        if (Coin.coin >= damageCost)
        {
            damageButton.interactable = true;
        }
        if (damageIsUnlocked == true)
        {
            damageButton.interactable = false;
        }
    }

    private void BarrierCoinCheck()
    {
        if (Coin.coin < barrierHealthCost)
        {
            barrierHealthButton.interactable = false;
        }
        if (Coin.coin >= barrierHealthCost)
        {
            barrierHealthButton.interactable = true;
        }
        if (barrierHPIsUnlocked == true)
        {
            barrierHealthButton.interactable = false;
        }
    }

    public void showMenu()
    {
        if(!upgradeCanvasObj.activeInHierarchy)
        {
            upgradeCanvasObj.SetActive(true); 

        }
    }

    public void hideMenu()
    {
        if (upgradeCanvasObj.activeInHierarchy)
        {
            upgradeCanvasObj.SetActive(false);

        }
    }

    public void addDamage()
    {
        damageIsUnlocked = true;
        damageButton.interactable = false;
        Coin.coin -= damageCost;
    }

    public void barrierHealthUpgrade()
    {

        barrierHPIsUnlocked = true;
        barrierHealthButton.interactable = false;
        Coin.coin -= barrierHealthCost; 

    }
}
