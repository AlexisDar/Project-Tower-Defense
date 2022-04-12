using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad1;

    public string levelToLoad2;

    public string levelToLoad3;

    public GameObject settingsWindow;

    public GameObject LevelMenu;

    public void StartLevel1()
    {
        SceneManager.LoadScene(levelToLoad1);

    }

    public void StartLevel2()
    {
        SceneManager.LoadScene(levelToLoad2);
    }

    public void StartLevel3()
    {
        SceneManager.LoadScene(levelToLoad3);
    }

    public void Settings()
    {
        settingsWindow.SetActive(true);
        LevelMenu.SetActive(false);
    }


    public void CloseSettingsWindow()
    {
        settingsWindow.SetActive(false);
    }

    public void Level()
    {
        LevelMenu.SetActive(true);
        settingsWindow.SetActive(false);
    }

    public void CloseLevel()
    {
        LevelMenu.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
