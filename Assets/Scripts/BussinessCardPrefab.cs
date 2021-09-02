using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BussinessCardPrefab : MonoBehaviour
{
  [SerializeField] private BussinessCard bussinessCard;
    private SetBussinessInfo setBussinessInfo;
   

    public void Start()
    {
        setBussinessInfo = GameObject.FindGameObjectWithTag("BussinessCard").GetComponent<SetBussinessInfo>();
    }
   
    
    private void OnMouseDown()
      {
        setBussinessInfo.OpenBussinessInfoPanel();
        setBussinessInfo.personNameText.text = bussinessCard.Name;
        setBussinessInfo.emailAddressText.text = bussinessCard.Email;
        setBussinessInfo.addressText.text = bussinessCard.Address;
        //    setBussinessInfo.CardIcon.GetComponent<RawImage>().texture= bussinessCard.Image;
        setBussinessInfo.CardIcon.GetComponent<RawImage>().texture = bussinessCard.Image;
    }
}
