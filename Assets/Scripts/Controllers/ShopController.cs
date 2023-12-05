using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour
{
    [SerializeField] private string mainMenuSceneName;

    public void ClickMainMenuBtn()
    {
        SceneManager.LoadScene(mainMenuSceneName);
    }
}
