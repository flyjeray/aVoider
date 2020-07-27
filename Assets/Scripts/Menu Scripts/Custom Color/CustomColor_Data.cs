using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CustomColor_Data : MonoBehaviour
{
    public int savedRedValue;
    public int savedBlueValue;
    public int savedGreenValue;

    public int price;

    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;

    public TextMeshProUGUI redSliderText;
    public TextMeshProUGUI greenSliderText;
    public TextMeshProUGUI blueSliderText;

    public bool isColorNew;

    public Button updateColorButton;
    public TextMeshProUGUI updateColorPriceText;
    public Image previewImage;
}
