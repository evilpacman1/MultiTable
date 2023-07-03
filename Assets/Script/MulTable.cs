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
                SceneManager.LoadScene("Level 1_2");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 2);
                break;
            case 3:
                SceneManager.LoadScene("Level 2_2");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 4);
                break;
            case 5:
                SceneManager.LoadScene("Level 3_2");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 6);
                break;
            case 7:
                SceneManager.LoadScene("Level 4_2");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 8);
                break;
            case 9:
                SceneManager.LoadScene("Level 5_2");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 10);
                break;
            case 11:
                SceneManager.LoadScene("Level 6_2");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 12);
                break;
            case 13:
                SceneManager.LoadScene("Level 7_2");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 14);
                break;
            case 15:
                SceneManager.LoadScene("Level 8_2");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 16);
                break;
            case 17:
                SceneManager.LoadScene("Level 9_2");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 18);
                break;
            case 19:
                SceneManager.LoadScene("Level 10_2");
                PlayerPrefs.DeleteKey(StartMenu.Save);
                PlayerPrefs.SetInt(StartMenu.Save, 20);
                break;


        }
    }
}
