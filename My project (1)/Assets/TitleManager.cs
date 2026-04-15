using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GameStart()
    {
        SceneManager.LoadScene("PlayScene_door2");
    }
    public void GameOff()
    {
        SceneManager.LoadScene("TItleScene");
    }
    public void GameOut()
    {
        Application.Quit();
    }

}
