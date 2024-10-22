using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    float elapsedTime;

    
    void Update()
    {
        elapsedTime += Time.deltaTime;
        TimerText.text = elapsedTime.ToString();
    }
}
