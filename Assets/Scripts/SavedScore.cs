using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SavedScore : MonoBehaviour
{
    public TextMeshProUGUI highScore1;
    public TextMeshProUGUI highScore2;
    public TextMeshProUGUI highScore3;
    public TextMeshProUGUI highScore4;
    public TextMeshProUGUI highScore5;
    // Start is called before the first frame update
    void Start()
    {
        highScore1.text = PlayerPrefs.GetInt("HighScore1").ToString();
        highScore2.text = PlayerPrefs.GetInt("HighScore2").ToString();
        highScore3.text = PlayerPrefs.GetInt("HighScore3").ToString();
        highScore4.text = PlayerPrefs.GetInt("HighScore4").ToString();
        highScore5.text = PlayerPrefs.GetInt("HighScore5").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
