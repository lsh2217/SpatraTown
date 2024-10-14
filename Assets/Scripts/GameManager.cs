using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance;

    public Sprite selectedCharacterSprite;  
    public RuntimeAnimatorController selectedAnimatorController;

    public string playerName;

    private void Awake()
	{
		if (Instance == null)
		{
            Instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else if (Instance != this)
		{
			Destroy(gameObject);
		}
	}

}
