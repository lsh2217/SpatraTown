using UnityEngine;
using UnityEngine.UI;

public class PlayerSaveData : MonoBehaviour
{
    [SerializeField] private InputField nameInputField;
    [SerializeField] public RuntimeAnimatorController playerAnimator;

    public void SavePlayerName()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.playerName = nameInputField.text;
            Debug.Log("플레이어 이름 저장됨: " + GameManager.Instance.playerName);
        }
    }
}
