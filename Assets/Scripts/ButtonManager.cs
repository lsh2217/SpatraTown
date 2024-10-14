using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    public void OpenSelevtionUI()
    {
        canvas.transform.Find("CharacterChoice").gameObject.SetActive(true);
    }

    public void OpenNameChangeUI()
    {
        canvas.transform.Find("NameChangeUI").gameObject.SetActive(true);
    }

    public void CloseNameChangeUI()
    {
        canvas.transform.Find("NameChangeUI").gameObject.SetActive(false);
    }
}