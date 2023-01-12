using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;





public class ClickControl : MonoBehaviour
{
    public RectTransform infoButton;
    public GameObject pausePanel;
    public GameObject optionPanel;
    public AudioSource clickSound;
    public GameObject[] imageStage1;
    public GameObject[] imageStage1Question;
    public GameObject[] descStage1;
    public GameObject[] descStage1Question;
    public GameObject[] imageStage2;
    public GameObject[] imageStage2Question;
    public GameObject[] descStage2;
    public GameObject[] descStage2Question;
    public GameObject[] imageStage3;
    public GameObject[] imageStage3Question;
    public GameObject[] descStage3;
    public GameObject[] descStage3Question;
    public GameObject[] imageStage4;
    public GameObject[] imageStage4Question;
    public GameObject[] descStage4;
    public GameObject[] descStage4Question;
    public GameObject[] imageStage5;
    public GameObject[] imageStage5Question;
    public GameObject[] descStage5;
    public GameObject[] descStage5Question;

    private void Start()
    {
        CheckScore();
    }
    
    public void CheckScore()
    {
        if (PlayerPrefs.GetInt("HighScore1") > 100)
        {
            foreach (GameObject go in imageStage1)
            {
                go.SetActive(true);
            }
            foreach (GameObject go in descStage1)
            {
                go.SetActive(true);
            }
            foreach (GameObject go in imageStage1Question)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in descStage1Question)
            {
                go.SetActive(false);
            }
        }

        if (PlayerPrefs.GetInt("HighScore2") > 100)
        {
            foreach (GameObject go in imageStage2)
            {
                go.SetActive(true);
            }
            foreach (GameObject go in descStage2)
            {
                go.SetActive(true);
            }
            foreach (GameObject go in imageStage2Question)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in descStage2Question)
            {
                go.SetActive(false);
            }
        }

        if (PlayerPrefs.GetInt("HighScore3") > 100)
        {
            foreach (GameObject go in imageStage3)
            {
                go.SetActive(true);
            }
            foreach (GameObject go in descStage3)
            {
                go.SetActive(true);
            }
            foreach (GameObject go in imageStage3Question)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in descStage3Question)
            {
                go.SetActive(false);
            }
        }
        if (PlayerPrefs.GetInt("HighScore4") > 150)
        {
            foreach (GameObject go in imageStage4)
            {
                go.SetActive(true);
            }
            foreach (GameObject go in descStage4)
            {
                go.SetActive(true);
            }
            foreach (GameObject go in imageStage4Question)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in descStage4Question)
            {
                go.SetActive(false);
            }
        }
        if (PlayerPrefs.GetInt("HighScore5") > 150)
        {
            foreach (GameObject go in imageStage5)
            {
                go.SetActive(true);
            }
            foreach (GameObject go in descStage5)
            {
                go.SetActive(true);
            }
            foreach (GameObject go in imageStage5Question)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in descStage5Question)
            {
                go.SetActive(false);
            }
        }

    }

    public void ButtonPause()
    {
        SoundClickPlay();
        pausePanel.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void ResumeButton()
    {
        SoundClickPlay();
        pausePanel.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void InvokePlayButton()
    {
        EventSystem.current.SetSelectedGameObject(null);
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }
    public void PlayButton()
    {
        SoundClickPlay();
        Invoke("InvokePlayButton", 0.5f);
        Time.timeScale = 1;
    }
    public void InvokePlayButton2()
    {
        EventSystem.current.SetSelectedGameObject(null);
        SceneManager.LoadScene("GameScene2");
        Time.timeScale = 1;
    }
    public void PlayButton2()
    {
        SoundClickPlay();
        EventSystem.current.SetSelectedGameObject(null);
        Invoke("InvokePlayButton2", 0.5f);
        Time.timeScale = 1;
    }
    public void InvokePlayButton3()
    {
        
        EventSystem.current.SetSelectedGameObject(null);
        SceneManager.LoadScene("GameScene3");
        Time.timeScale = 1;
    }
    public void PlayButton3()
    {
        SoundClickPlay();
        
        Invoke("InvokePlayButton3", 0.5f);
        Time.timeScale = 1;
    }
    public void InvokePlayButton4()
    {
        
        EventSystem.current.SetSelectedGameObject(null);
        SceneManager.LoadScene("GameScene4");
        Time.timeScale = 1;
    }
    public void PlayButton4()
    {
        SoundClickPlay();
        
        Invoke("InvokePlayButton4", 0.5f);
        Time.timeScale = 1;
    }
    public void InvokePlayButton5()
    {
        
        EventSystem.current.SetSelectedGameObject(null);
        SceneManager.LoadScene("GameScene5");
        Time.timeScale = 1;
    }
    public void PlayButton5()
    {
        SoundClickPlay();
        
        Invoke("InvokePlayButton5", 0.5f);
        Time.timeScale = 1;
    }
    public void InvokeStageSelection()
    {
        SceneManager.LoadScene("StageScene");
    }
    public void StageSelection()
    {
        SoundClickPlay();
        Invoke("InvokeStageSelection", 0.5f);

    }
    public void InvokeExitButton()
    {
        
        EventSystem.current.SetSelectedGameObject(null);
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1;
    }
    public void ExitButton()
    {
        SoundClickPlay();
        
        Invoke("InvokeExitButton", 0.5f);
        Time.timeScale = 1;
    }
    public void ExitGame()
    {
        SoundClickPlay();
        Application.Quit();
    }
    public void OptionButton()
    {
        SoundClickPlay();
        optionPanel.SetActive(true);
    }
    public void OptionButtonBack()
    {
        SoundClickPlay();
        optionPanel.SetActive(false);
    }
    public void SelectSelectedGameobject()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }
    public void SoundClickPlay()
    {
        clickSound.Play();
    }



}
