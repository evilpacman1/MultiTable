using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MulTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ContinueLevelLond()
    {
        switch (PlayerPrefs.GetInt(StartMenu.Save))
        {
            case 1:
                PlayerPrefs.SetInt(StartMenu.Save, 2);
                SceneManager.LoadScene("Level 1_2");
                break;
            case 3:  
                PlayerPrefs.SetInt(StartMenu.Save, 4);
                SceneManager.LoadScene("Level 2_2");
                break;
            case 5:
                PlayerPrefs.SetInt(StartMenu.Save, 6);
                SceneManager.LoadScene("Level 3_2");
                break;
            case 7:
                PlayerPrefs.SetInt(StartMenu.Save, 8);
                SceneManager.LoadScene("Level 4_2");
                break;
            case 9:
                PlayerPrefs.SetInt(StartMenu.Save, 10);
                SceneManager.LoadScene("Level 5_2");
                break;
            case 11:
                PlayerPrefs.SetInt(StartMenu.Save, 12);
                SceneManager.LoadScene("Level 6_2");
                break;
            case 13:
                PlayerPrefs.SetInt(StartMenu.Save, 14);
                SceneManager.LoadScene("Level 7_2");
                break;
            case 15:
                PlayerPrefs.SetInt(StartMenu.Save, 16);
                SceneManager.LoadScene("Level 8_2");
                break;
            case 17:
                PlayerPrefs.SetInt(StartMenu.Save, 18);
                SceneManager.LoadScene("Level 9_2");
                break;
            case 19:
                PlayerPrefs.SetInt(StartMenu.Save, 20);
                SceneManager.LoadScene("Level 10_2");
                break;


        }
    }
}
