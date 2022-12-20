using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacksoundMusic : MonoBehaviour
{
    public static BacksoundMusic instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
