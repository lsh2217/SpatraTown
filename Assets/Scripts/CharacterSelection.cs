using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : PlayerSaveData
{
    [SerializeField] private Sprite characterSprite;
    [SerializeField] public RuntimeAnimatorController characterAnimator;
    [SerializeField] public Button characterButton;
    public void OnCharacterSelect()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.selectedAnimatorController = characterAnimator;
            characterButton.image.sprite = characterSprite;
        }
        transform.parent.gameObject.SetActive(false);
    }
}
