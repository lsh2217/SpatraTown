using System;
using UnityEngine;
using UnityEngine.UI;

public class CurrentTime : MonoBehaviour
{
    public Text TimeString;
    public string GetCurrentDate()
    {
        return DateTime.Now.ToString("HH:mm:ss");
    }
    public void Update()
    {
        TimeString.text = GetCurrentDate();
    }
}