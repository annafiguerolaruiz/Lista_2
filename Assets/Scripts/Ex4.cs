using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ex4 : MonoBehaviour
{

    public int PCChose;

    //Counters
    private int Question;
    private int Attempts;
    //ResultsTexts
    public TextMeshProUGUI Correct; 
    public TextMeshProUGUI Failed;
    //TEXTS
    public GameObject RESULTS;

    void Start()
    {
        RESULTS.SetActive(false);
    }

    public void PCelection() 
    {
        //Pc chose the option 
        PCChose = Random.Range(0, 2); 
    }

    public void Chose(int election) 
    {
        if (election == PCChose) 
        {
            Attempts++;
        }

        if (Question < 10) 
        {
            Question++;
            PCelection();
        }
        //We show results
        if (Question == 10) 
        {
            RESULTS.SetActive(true);
            Correct.text = Attempts.ToString();
            Failed.text = (10 - Attempts).ToString();

        }

    }
}
