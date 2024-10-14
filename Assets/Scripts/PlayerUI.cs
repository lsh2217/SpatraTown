using UnityEngine;
using UnityEngine.UI;
public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Text playerNameText;
    [SerializeField] private Animator playerAnimater;
    private void Start()
    {
        playerAnimater = transform.Find("MainSprite").GetComponent<Animator>();
        if (GameManager.Instance != null)
        {
            playerNameText.text = GameManager.Instance.playerName;
            playerAnimater.runtimeAnimatorController = GameManager.Instance.selectedAnimatorController;
        }
    }
    
    private void FixedUpdate()
    {
        GameObject.Find("Canvas").transform.Find("NameUI").transform.position = Camera.main.WorldToScreenPoint(new Vector3(this.transform.position.x, this.transform.position.y + 0.6f, 0));
    }
}
