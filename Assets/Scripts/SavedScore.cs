using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SavedScore : MonoBehaviour
{
    public TextMeshProUGUI highScore1;
    public TextMeshProUGUI highScore2;
    public TextMeshProUGUI highScore3;
    public TextMeshProUGUI highScore4;
    public TextMeshProUGUI highScore5;
    public Button stageSelect1;
    public Button stageSelect2;
    public Button stageSelect3;
    public Button stageSelect4;
    public Button stageSelect5;
    public GameObject background1;
    public GameObject background2;
    public GameObject background3;
    public GameObject background4;

    // Start is called before the first frame update
    void Start()
    {
        highScore1.text = PlayerPrefs.GetInt("HighScore1").ToString();
        highScore2.text = PlayerPrefs.GetInt("HighScore2").ToString();
        highScore3.text = PlayerPrefs.GetInt("HighScore3").ToString();
        highScore4.text = PlayerPrefs.GetInt("HighScore4").ToString();
        highScore5.text = PlayerPrefs.GetInt("HighScore5").ToString();
        
        

        if (PlayerPrefs.GetInt("HighScore1") < 100)
        {
            highScore1.color = Color.white;
            stageSelect2.interactable = false;
            background1.SetActive(true);

            highScore2.enabled = false;

            

        }
        if (PlayerPrefs.GetInt("HighScore2") < 100)
        {
            highScore2.color = Color.white;
            stageSelect3.interactable = false;
            background2.SetActive(true);

            highScore3.enabled = false;


        }
        if (PlayerPrefs.GetInt("HighScore3") < 100)
        {
            highScore3.color = Color.white;
            stageSelect4.interactable = false;
            background3.SetActive(true);

            highScore4.enabled = false;

            

        }
        if (PlayerPrefs.GetInt("HighScore4") < 150)
        {
            highScore4.color = Color.white;
            stageSelect5.interactable = false;
            background4.SetActive(true);

            highScore5.enabled = false;
  

        }
        if (PlayerPrefs.GetInt("HighScore5") < 150)
        {
            highScore5.color = Color.white;

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
