using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ClickControl : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject optionPanel;
    public AudioSource clickSound;
    

    // Start is called before the first frame update
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
