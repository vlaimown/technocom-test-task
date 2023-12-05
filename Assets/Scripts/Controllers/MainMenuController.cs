using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private string gameSceneName;
    [SerializeField] private string shopSceneName;

    public void ClickPlayBtn()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void ClickShopBtn()
    {
        SceneManager.LoadScene(shopSceneName);
    }
}
