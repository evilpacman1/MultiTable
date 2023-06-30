using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject startGame;
    public GameObject endGame;
    public GameObject _continue;
    public GameObject restart;
    public static string Save = "Save";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.HasKey(Save) == false) 
        { 
            startGame.SetActive(true);
            endGame.SetActive(true);
            _continue.SetActive(false);
            restart.SetActive(false);
        }
        else 
        {
            startGame.SetActive(false);
            endGame.SetActive(true);
            _continue.SetActive(true);
            restart.SetActive(true);
        }
      
    }
    public void StartGameNow() 
    {
      
        PlayerPrefs.SetInt(Save, 1);
        SceneManager.LoadScene("Level 1");
        

    }
    public void ContinueLevelLond() 
    {
        switch (PlayerPrefs.GetInt(StartMenu.Save))
        {
            case 1:
                SceneManager.LoadScene("Level 2");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 2);
                break;
            case 2:
                SceneManager.LoadScene("Level 3");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 3);
                break;
            case 3:
                SceneManager.LoadScene("Level 4");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 4);
                break;
            case 4:
                SceneManager.LoadScene("Level 5");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 5);
                break;
            case 5:
                SceneManager.LoadScene("Level 6");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 6);
                break;
            case 6:
                SceneManager.LoadScene("Level 7");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 7);
                break;
            case 7:
                SceneManager.LoadScene("Level 8");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 8);
                break;
            case 8:
                SceneManager.LoadScene("Level 9");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 9);
                break;
            case 9:
                SceneManager.LoadScene("Level 10");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 10);
                break;
            case 10:
                SceneManager.LoadScene("Level 11");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 11);
                break;
           

        }
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Restart()
    {
        PlayerPrefs.DeleteKey(Save);
        startGame.SetActive(true);
        endGame.SetActive(true);
        _continue.SetActive(false);
        restart.SetActive(false);
    }
}
