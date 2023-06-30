using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TrueOrNot : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] answerCube;
    public GameObject _false;
    public GameObject _excellent;
    public GameObject falePlant;
    public GameObject _trueImege;
    public GameObject _falseImege;
    public Transform partricalSmoke;
    public Transform particalStar;
    public AudioSource _magickSound;
    

    private void Start()
    {
        partricalSmoke.GetComponent<ParticleSystem>().enableEmission = false;
        particalStar.GetComponent<ParticleSystem>().enableEmission= false;
    }
    public void True() 
    {

        StartCoroutine(WhateWin());
    }
    public void falseAnswer()
    {
        StartCoroutine(WhateFall());
    }

  IEnumerator WhateFall() 
    {
        _magickSound.Play();
        falePlant.SetActive(true);
        _false.SetActive(true);
        _falseImege.SetActive(true);
        yield return new WaitForSeconds(2f);
        _falseImege.SetActive(false);
        falePlant.SetActive(false);
        _false.SetActive(false);

    
    }
    IEnumerator WhateWin()
    {
        _magickSound.Play();
        _trueImege.SetActive(true);
        _excellent.SetActive(true);
        falePlant.SetActive(true);
        partricalSmoke.GetComponent<ParticleSystem>().enableEmission = true;
        particalStar.GetComponent<ParticleSystem>().enableEmission = true;
        yield return new WaitForSeconds(3);
        partricalSmoke.GetComponent<ParticleSystem>().enableEmission = false;
        yield return new WaitForSeconds(2);
        particalStar.GetComponent<ParticleSystem>().enableEmission = false;
        for (int i = 0; i < answerCube.Length; i++)
        {

            answerCube[i].SetActive(true);

        }
       

        yield return new WaitForSeconds(5);
        switch (PlayerPrefs.GetInt(StartMenu.Save))
            {
            case 1:
                SceneManager.LoadScene("Level 2");
               
                PlayerPrefs.SetInt(StartMenu.Save, 2);
                break;
            case 2:
                SceneManager.LoadScene("Level 3");
               
                PlayerPrefs.SetInt(StartMenu.Save, 3);
                break; 
            case 3:
                SceneManager.LoadScene("Level 4");

                PlayerPrefs.SetInt(StartMenu.Save, 4);
                break; 
            case 4:
                SceneManager.LoadScene("Level 5");
                PlayerPrefs.SetInt(StartMenu.Save, 5);
                break;
                case 5:
                SceneManager.LoadScene("Level 6");
                PlayerPrefs.SetInt(StartMenu.Save, 6);
                break;
                case 6:
                SceneManager.LoadScene("Level 7");
                PlayerPrefs.SetInt(StartMenu.Save,7);
                break;
                case 7:
                SceneManager.LoadScene("Level 8");
                PlayerPrefs.SetInt(StartMenu.Save, 8);
                break;
                case 8:
                SceneManager.LoadScene("Level 9");
                PlayerPrefs.SetInt(StartMenu.Save, 9);
                break;
                case 9:
                SceneManager.LoadScene("Level 10");
                PlayerPrefs.SetInt(StartMenu.Save, 10);
                break;
                case 10:
                SceneManager.LoadScene("Level 1");
                PlayerPrefs.SetInt(StartMenu.Save, 1);
                break;
               

        }
            

    }

    public void returnMenu() 
    {

        SceneManager.LoadScene("StartGame");

    }

}
