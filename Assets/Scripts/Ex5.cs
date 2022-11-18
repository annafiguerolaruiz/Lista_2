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

        YourYeear = int.Parse(TEXT.text); //This transfers the text received by the input field to an int
        ANIMAL = YourYeear % 12; //We show our animal year substracting to the year we were born (every 12 years is x animal)
        ANIMALphoto.sprite = IMAGE[ANIMAL];

    }
}
