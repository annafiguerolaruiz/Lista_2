using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ex2 : MonoBehaviour
{   
    public float Counter; 
    public TextMeshProUGUI TEXTtime;
    public Image IMAGEtime;

    private float FirstTime;
    private bool press = true;

    
    public void StartButton()
    {
        //Can't pause
        if (press == true) 
        {
            FirstTime = Counter;
            TEXTtime.text = Counter.ToString();
            press = false;
        }
    }
    void Update()
    {
        //Time runs after pressing
        if (Counter > 0 && press == false)
        {
            UpdateTime();
        }
    }

    public void UpdateTime()
    {
        Counter -= Time.deltaTime;
        //No milliseconds
        TEXTtime.text = Mathf.Round(Counter).ToString();     
        IMAGEtime.fillAmount = Counter / FirstTime;
    }

}