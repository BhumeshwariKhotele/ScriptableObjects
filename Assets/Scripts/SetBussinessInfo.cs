using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetBussinessInfo : MonoBehaviour
{
    public GameObject BussinessCardInfoPanel,BGpanel;
    public GameObject CardIcon;
    public Text personNameText;
    public Text emailAddressText;
    public Text addressText;

  

    public void OpenBussinessInfoPanel()
    {
        BGpanel.SetActive(true);
       BussinessCardInfoPanel.SetActive(true);
    }

    public void ClosBussinessInfoPanel()
    {
        BGpanel.SetActive(false);
        BussinessCardInfoPanel.SetActive(false);
    }
}
