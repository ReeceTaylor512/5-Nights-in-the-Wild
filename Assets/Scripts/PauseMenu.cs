using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool paused; 

    [SerializeField]
    private GameObject PauseObj;
    [SerializeField]
    private GameObject MenuObj;
    [SerializeField]
    private GameObject MainMenuObj;
    [SerializeField]
    private GameObject OptionsObj;


    // Start is called before the first frame update
    void Start()
    {
        if(MenuObj.activeInHierarchy)
        {
            paused = true;
            Time.timeScale = 0; 
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pauseButton() //Pauses the game
    {
        if(!MenuObj.activeInHierarchy)
        {
            MenuObj.SetActive(true);
            PauseObj.SetActive(false);

            Time.timeScale = 0;
            paused = true; 
        }


    }
    public void resumeButton() //Resumes the game 
    { 
        if(MenuObj.activeInHierarchy)
        {
            MenuObj.SetActive(false);
            PauseObj.SetActive(true); 

            Time.timeScale = 1;
            paused = false; 
        }
    }

    public void optionsButton()
    {
        if(MainMenuObj.activeInHierarchy)
        {
            MainMenuObj.SetActive(false);
            OptionsObj.SetActive(true);
        }
    }

    public void backButton()
    {
        if (MainMenuObj.activeInHierarchy)
        {
            MenuObj.SetActive(false);
            PauseObj.SetActive(true);

            Time.timeScale = 1;
            paused = false;
        }
        if (OptionsObj.activeInHierarchy)
        {
            MainMenuObj.SetActive(true);
            OptionsObj.SetActive(false);
        }
    }

    public void menuButton()
    {
        SceneManager.LoadScene(0);
    }
    
}
