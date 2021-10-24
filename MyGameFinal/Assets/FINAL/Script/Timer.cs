using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    int counterDownStartValue = 5;
    public Text TextTime;
    // Start is called before the first frame update
    void Start()
    {

    }
    void counterDownTimer() 
    {
        if (counterDownStartValue > 0)
        {
            TextTime.text = "Timer : "+counterDownStartValue;
            counterDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            TextTime.text = "GAMEOVER!!!";
           // Debug.Log("GAMEOVER!!!");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
