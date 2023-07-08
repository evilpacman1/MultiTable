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
        SceneManager.LoadScene("Level 1_1");
        

    }
    public void ContinueLevelLond() 
    {
        switch (PlayerPrefs.GetInt(StartMenu.Save))
        {
            case 1:
                
                
                SceneManager.LoadScene("Level 1_1");
                break;
            case 2:
               
                SceneManager.LoadScene("Level 1_2");
                break;
            case 3:
                
                SceneManager.LoadScene("Level 2_1");
                break;
            case 4:
              
                SceneManager.LoadScene("Level 2_2");
                break;
            case 5:
               
                SceneManager.LoadScene("Level 3_1");
                break;
            case 6:
               
                SceneManager.LoadScene("Level 3_2");
                break;
            case 7:
               
                SceneManager.LoadScene("Level 4_1");
                break;
            case 8:
                
                SceneManager.LoadScene("Level 4_2");
                break;
            case 9:
             
                SceneManager.LoadScene("Level 5_1");
                break;
            case 10:
               
                SceneManager.LoadScene("Level 5_2");
                break;
            case 11:
                
                SceneManager.LoadScene("Level 6_1");
                break;
            case 12:
              
                SceneManager.LoadScene("Level 6_2");
                break;
            case 13:
               
                SceneManager.LoadScene("Level 7_1");
                break;
            case 14:
              
                SceneManager.LoadScene("Level 7_2");
                break;
            case 15:
                
                SceneManager.LoadScene("Level 8_1");
                break;
            case 16:
               
                SceneManager.LoadScene("Level 8_2");
                break;
            case 17:
              
                SceneManager.LoadScene("Level 9_1");
                break;
            case 18:
                
                SceneManager.LoadScene("Level 9_2");
                break;
            case 19:
              
                SceneManager.LoadScene("Level 10_1");
                break;
            case 20:
               
                SceneManager.LoadScene("Level 10_2");
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
