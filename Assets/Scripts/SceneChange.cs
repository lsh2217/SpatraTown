using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void MainScenChanger()
    {
        SceneManager.LoadScene("MainScene");
    }
}