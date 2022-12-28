using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIAnimation : MonoBehaviour
{
    public RectTransform titleName;
    
    // Start is called before the first frame update
    void Start()
    {
        titleName.DOScale(new Vector3(1.1f, 1.1f, 1.1f), 2).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
