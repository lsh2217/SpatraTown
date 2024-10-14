using System;
using UnityEngine;
using UnityEngine.UI;

public class NameSet : MonoBehaviour
{
    [SerializeField] Text PlayerName;
    [SerializeField] InputField SetName;
    public void Namechange()
    {
        PlayerName.text = SetName.text;
    }
}