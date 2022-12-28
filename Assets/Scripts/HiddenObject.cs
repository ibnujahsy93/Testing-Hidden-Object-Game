using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class HiddenObject : MonoBehaviour
{

    public GameObject itemParent;
    public GameObject parentObjekFinal;
    public GameObject parentTextFinal;

    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI scoreFinalTxt;
    public TextMeshProUGUI timerTxt;
    public RectTransform layerGameover;

    public bool timerOn = true;
    public float waktu = 120;
    public float timeRemaining;
    public int scoreNumber;
    public Button nextButton;
    private int ite;
    [SerializeField] private AudioSource correctAudio;
    [SerializeField] private AudioSource incorrectAudio;
    [SerializeField] private AudioSource finishGameAudio;
    [SerializeField] private AudioSource failAudio;
    [SerializeField] GameObject wrongAnswerNumPrefab;

    public ControlPos controlPos;

    [Space]
    [Header("Text Clue")]
    public Text textClue;
    public TextClue scriptTextClue;


    public int[] indexNumberClue;
    public int indexUrutanClue;

    [Space]
    [Header("round game")]
    public int currentRound;
    public int totalRound;
    public TextMeshProUGUI textRound;
    public GameObject panelGameover;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        TextItemFound();
        RandomObjectPos();
        RandomIndexNumberClue();
        RandomObjectClue();
        scoreNumber = 0;
        

        
        
    }

    // Update is called once per frame
    void Update()
    {

        scoreTxt.text = "Score:" + scoreNumber;
        SetText();
        timeRemaining += Time.deltaTime;
        if (timeRemaining >= 1)
        {
            waktu--;
            timeRemaining = 0;
        }
        if (waktu <= 0 && timerOn == true && currentRound >= 1)
        {
            failAudio.Play();
        }
        else if (waktu <= 0 && timerOn == true && currentRound == 0)
        {
            failAudio.Play();
        }
        if (waktu <= 0)
        {
            waktu = 0;
            scoreFinalTxt.text = "Final Score:" + scoreNumber;
            
            panelGameover.SetActive(true);
            
            timerOn = false;
            
            ScoringPoint();
            layerGameover.DOMove(new Vector3(960, 500, 0), 1.5f);
        }
    }


    void TextItemFound()
    {
        textRound.text = currentRound.ToString() + "/" + totalRound.ToString();
    }

    void RandomIndexNumberClue()
    {
        for (int i = 0; i < indexNumberClue.Length; i++)
        {
            int a = indexNumberClue[i];
            int b = Random.Range(0, indexNumberClue.Length);
            indexNumberClue[i] = indexNumberClue[b];    
            indexNumberClue[b] = a;
        }
    }
    
    public void ButtonObject(int numberItem)
    {
        if (numberItem == scriptTextClue.numberClue) //Pengecekan untuk jawaban benar
        {
            
            correctAudio.Play(); //Memainkan Audio untuk jawaban benar
            parentObjekFinal.transform.GetChild(ite).GetComponent<Image>().sprite = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite; //Copy sprite dari game objek yang dipilih ke panel gameover
            parentTextFinal.transform.GetChild(ite).name = EventSystem.current.currentSelectedGameObject.name; //Copy nama game objek yang dipilih ke text objek di panel gameover
            parentTextFinal.transform.GetChild(ite).GetComponent<TextMeshProUGUI>().text = parentTextFinal.transform.GetChild(ite).name; // copy nama dari text objek ke dalam textmeshpro
            ite += 1;

            if (waktu >= 110)
            {
                scoreNumber += 50;
                Debug.Log("Benar, dpt skor 50");
            }
            else if (waktu >= 80)
            {
                scoreNumber += 40;
                Debug.Log("Benar, dpt skor 40");
            }
            else if (waktu >= 60)
            {
                scoreNumber += 30;
                Debug.Log("Benar, dpt skor 30");
            }
            else if (waktu >= 20)
            {
                scoreNumber += 20;
                Debug.Log("Benar, dpt skor 20");
            }
            else if (waktu >= 1)
            {
                scoreNumber += 5;
                Debug.Log("Benar, dpt skor 5");
            }
            
            itemParent.transform.GetChild(numberItem).gameObject.SetActive(false);
            indexUrutanClue += 1;
            
            if (currentRound < totalRound - 1)
            {
                currentRound += 1;

                textRound.text = currentRound.ToString() + "/" + totalRound.ToString();
                RandomObjectClue();
            }
            else
            {
                Debug.Log("full");
                currentRound += 1;
                textRound.text = currentRound.ToString() + "/" + totalRound.ToString();
                scoreFinalTxt.text = "Final Score:" + scoreNumber;
                finishGameAudio.Play();
                panelGameover.SetActive(true);
                layerGameover.DOMove(new Vector3(960, 500, 0), 1.5f);
                
                ScoringPoint();
                
                

            }
            

            
        }
        else //Jawaban Salah!!
        {
            Destroy(Instantiate(wrongAnswerNumPrefab, timerTxt.transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform), 1f);
            waktu -= 10;
            Debug.Log("Salah");
            incorrectAudio.Play();
            
        }
    }

    public void ScoringPoint()
    {
        if (SceneManager.GetActiveScene().name == "GameScene")
        {
            if (scoreNumber > PlayerPrefs.GetInt("HighScore1"))
            {
                PlayerPrefs.SetInt("HighScore1", scoreNumber);
            }
            else if (scoreNumber < PlayerPrefs.GetInt("HighScore1"))
            {
                Debug.Log("Score kurang dari highscore");
                return;
            }
            if (PlayerPrefs.GetInt("HighScore1") < 100)
            {
                nextButton.interactable = false;
            }
        }
        else if (SceneManager.GetActiveScene().name == "GameScene2")
        {
            if (scoreNumber > PlayerPrefs.GetInt("HighScore2"))
            {
                PlayerPrefs.SetInt("HighScore2", scoreNumber);
            }
            else if (scoreNumber < PlayerPrefs.GetInt("HighScore2"))
            {
                Debug.Log("Score kurang dari highscore");
            }
            if (PlayerPrefs.GetInt("HighScore2") < 100)
            {
                nextButton.interactable = false;
            }
        }
        else if (SceneManager.GetActiveScene().name == "GameScene3")
        {
            if (scoreNumber > PlayerPrefs.GetInt("HighScore3"))
            {
                PlayerPrefs.SetInt("HighScore3", scoreNumber);
            }
            else if (scoreNumber < PlayerPrefs.GetInt("HighScore3"))
            {
                Debug.Log("Score kurang dari highscore");
            }
            if (PlayerPrefs.GetInt("HighScore3") < 100)
            {
                nextButton.interactable = false;
            }
        }
        else if (SceneManager.GetActiveScene().name == "GameScene4")
        {
            if (scoreNumber > PlayerPrefs.GetInt("HighScore4"))
            {
                PlayerPrefs.SetInt("HighScore4", scoreNumber);
            }
            else if (scoreNumber < PlayerPrefs.GetInt("HighScore4"))
            {
                Debug.Log("Score kurang dari highscore");
            }
            if (PlayerPrefs.GetInt("HighScore4") < 100)
            {
                nextButton.interactable = false;
            }
        }
        else if (SceneManager.GetActiveScene().name == "GameScene5")
        {
            if (scoreNumber > PlayerPrefs.GetInt("HighScore5"))
            {
                PlayerPrefs.SetInt("HighScore5", scoreNumber);
            }
            else if (scoreNumber < PlayerPrefs.GetInt("HighScore5"))
            {
                Debug.Log("Score kurang dari highscore");
            }
        }
    }
    void RandomObjectClue()
    {
        int randomClue = indexNumberClue[indexUrutanClue]; 
        scriptTextClue.numberClue = randomClue;

        textClue.text = scriptTextClue.clue[randomClue].stringObjectItem[Random.Range(0, scriptTextClue.clue[randomClue].stringObjectItem.Length)];
    }

    

    public void RandomObjectPos()
    {
        int randomSave = Random.Range(0, controlPos.savedPosition.Count);
        for (int i = 0; i < itemParent.transform.childCount; i++)
        {
            itemParent.transform.GetChild(i).transform.localPosition = controlPos.savedPosition[randomSave].objectPos[i];

            itemParent.transform.GetChild(i).gameObject.SetActive(true);
        }
    }


    void SetText()
    {
        int Menit = Mathf.FloorToInt(waktu / 60);
        int Detik = Mathf.FloorToInt(waktu % 60);
        timerTxt.text = Menit.ToString("00") +":"+ Detik.ToString("00");
    }






}
