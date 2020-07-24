using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop_Data : MonoBehaviour
{
    [SerializeField] private List<Button> allShopButtons;

    public void UpdateAnotherButtons(Button mainButton)
    {
        foreach(Button button in allShopButtons)
        {
            if (button != mainButton) button.GetComponent<Shop_Item_Script>().UpdateText();
        }
    }
}
