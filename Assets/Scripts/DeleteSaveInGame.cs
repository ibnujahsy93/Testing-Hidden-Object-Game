using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSaveInGame : MonoBehaviour
{
    [SerializeField] GameObject notifResetHighScore;
    public GameObject notifLoc;
    // Start is called before the first frame update
    public void DeleteAllSavedPrefsGame()
    {
        PlayerPrefs.DeleteAll();
        Destroy(Instantiate(notifResetHighScore, notifLoc.transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform), 2f);
    }
}
