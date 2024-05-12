
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad;

    public GameObject settingsWindow;
    public void StartGame()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void ParametreButton()
    {
        settingsWindow.SetActive(true);
    }
    public void CloseSettingsWindow()
    {
        settingsWindow.SetActive(false);
    }
    public void QuitterButton()
    {
        Application.Quit();
    }


}
