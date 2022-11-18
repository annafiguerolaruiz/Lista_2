using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ex5 : MonoBehaviour
{
    private int YourYeear;
    private int ANIMAL;
    public Image ANIMALphoto;
    public Sprite[] IMAGE;
    public TMP_InputField TEXT;

    void Update()
    {
        //If we put a number, the image of the corresponding horoscope will appear
        YourYeear = int.Parse(TEXT.text); 
        ANIMAL = YourYeear % 12; 
        ANIMALphoto.sprite = IMAGE[ANIMAL];

    }
}
