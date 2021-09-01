using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card",menuName ="BussinessCard",order =60)]
public class BussinessCard : ScriptableObject
{
    [SerializeField]  private string name;
    [SerializeField] private string EmailAddress;
    [SerializeField] private string address;
    [SerializeField] private Texture image;


    public string Name { get { return name;  } }
    public string Email { get { return EmailAddress; } }
    public string Address { get { return address; } }
    public Texture Image { get { return image; } }
}
