using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetBussinessInfo : MonoBehaviour
{
    public GameObject BussinessCardInfoPanel;
    public GameObject CardIcon;
    public Text personNameText;
    public Text emailAddressText;
    public Text addressText;

  

    public void OpenBussinessInfoPanel()
    {
       BussinessCardInfoPanel.SetActive(true);
    }

    public void ClosBussinessInfoPanel()
    {
        BussinessCardInfoPanel.SetActive(false);
    }
}
