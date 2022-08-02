using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    public TMP_Text text;
    public float time;
    public bool isCounting;
    
    void Start()
    {
        StartStopwatch();
    }
    
    void Update()
    {
        if (!isCounting)
            return;
        
        time += Time.deltaTime;

        if (text == null)
            return;
        
        text.text = "Stopwatch : " + time.ToString("F2");
    }

    public void StartStopwatch()
    {
        time = 0.0f;
        isCounting = true;
    }

    public void StopWatch()
    {
        isCounting = false;
    }

}
