using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransition : MonoBehaviour
{
    public static float time;
    public static List<GameObject> enemies = new List<GameObject>();
    public static int enemyCount;
    [SerializeField]
    private int maxEnemy;

    public static bool enemiesDead; 


    // Start is called before the first frame update
    void Start()
    {
        //addEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        //removeEnemies();
        Debug.Log("Enemies: " + enemies.Count.ToString());
        allEnemiesDead();
    }

    //void addEnemies()
    //{
    //    var enemies1 = GameObject.FindGameObjectsWithTag("Enemy");

    //    for (int i = 0; i < enemies1.Length; i++)
    //    {            
    //        enemies.Add(enemies1[1]);            
    //    }       

    //}

    //void removeEnemies()
    //{
    //    var enemies1 = GameObject.FindGameObjectsWithTag("Enemy");
    //    if (enemies.Count < enemies1.Length)
    //    {
    //        enemies.RemoveAt(0);

    //    }    
    //}


    
    
    
    void allEnemiesDead()
    {
        if(enemyCount == 0)
        {
            enemiesDead = true;
            time = Time.timeScale = 0;
        }
    }    

}
