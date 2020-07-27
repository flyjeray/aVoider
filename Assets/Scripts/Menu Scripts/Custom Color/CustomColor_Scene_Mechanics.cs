using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomColor_Scene_Mechanics : MonoBehaviour
{
    [SerializeField] private CustomColor_Data ccData;
    [SerializeField] private PlayerPrefs_Controller prefsController;    
    
    private void Awake()
    {
        UpdateUI();

        ccData.redSlider.value = prefsController.GetSavedColorValue("Red");
        ccData.greenSlider.value = prefsController.GetSavedColorValue("Green");
        ccData.blueSlider.value = prefsController.GetSavedColorValue("Blue");
    }

    public void UpdateUI()
    {
        if (ccData.redSlider.value != prefsController.GetSavedColorValue("Red") || ccData.greenSlider.value != prefsController.GetSavedColorValue("Green") || ccData.blueSlider.value != prefsController.GetSavedColorValue("Blue"))
        {
            ccData.isColorNew = true;
        }
        else ccData.isColorNew = false;

        ccData.redSliderText.text = "RED: " + ccData.redSlider.value.ToString("0.00");
        ccData.greenSliderText.text = "GREEN: " + ccData.greenSlider.value.ToString("0.00");
        ccData.blueSliderText.text = "BLUE: " + ccData.blueSlider.value.ToString("0.00");

        Color color = new Color(ccData.redSlider.value, ccData.greenSlider.value, ccData.blueSlider.value, 255);

        ccData.previewImage.material.color = color;
        ccData.previewImage.material.SetColor("_EmissionColor", color); 
        ccData.previewImage.material.SetColor("_Color", color);
        
        ccData.updateColorPriceText.text = ccData.price.ToString();

        if (ccData.isColorNew)
        {
            ccData.updateColorButton.gameObject.SetActive(true);
            ccData.updateColorPriceText.gameObject.SetActive(true);
        }
        else
        {
            ccData.updateColorButton.gameObject.SetActive(false);
            ccData.updateColorPriceText.gameObject.SetActive(false);
        }
    }

    public void SetNewColor()
    {
        if (prefsController.GetCoins() > ccData.price)
        {
            prefsController.UpdateCoins(-ccData.price);

            prefsController.SetSavedColorValue("Red", ccData.redSlider.value);
            prefsController.SetSavedColorValue("Blue", ccData.blueSlider.value);
            prefsController.SetSavedColorValue("Green", ccData.greenSlider.value);

            UpdateUI();
        }        
    }
}
