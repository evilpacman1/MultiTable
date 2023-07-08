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
            case 2:
                PlayerPrefs.SetInt(StartMenu.Save, 3);
                SceneManager.LoadScene("Level 2_1");
                break;
            case 4:
                PlayerPrefs.SetInt(StartMenu.Save, 5);
                SceneManager.LoadScene("Level 3_1");
                break; 
            case 6:
                PlayerPrefs.SetInt(StartMenu.Save, 7);
                SceneManager.LoadScene("Level 4_1");
                break; 
            case 8:
                PlayerPrefs.SetInt(StartMenu.Save, 9);
                SceneManager.LoadScene("Level 5_1");
                break;
            case 10:
                PlayerPrefs.SetInt(StartMenu.Save, 11);
                SceneManager.LoadScene("Level 6_1");
                break;
            case 12:
                PlayerPrefs.SetInt(StartMenu.Save, 13);
                SceneManager.LoadScene("Level 7_1");
                break;
            case 14:
                PlayerPrefs.SetInt(StartMenu.Save, 15);
                SceneManager.LoadScene("Level 8_1");
                break;
            case 16:
                PlayerPrefs.SetInt(StartMenu.Save, 17);
                SceneManager.LoadScene("Level 9_1");
                break;
            case 18:
                PlayerPrefs.SetInt(StartMenu.Save, 19);
                SceneManager.LoadScene("Level 10_1");
                break;
            case 20:
                PlayerPrefs.SetInt(StartMenu.Save, 1);
                SceneManager.LoadScene("Level 1_1");
                break;

        }
            

    }

    public void returnMenu() 
    {

        SceneManager.LoadScene("StartGame");

    }

}
