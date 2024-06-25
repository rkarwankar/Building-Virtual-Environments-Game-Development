using UnityEngine.SceneManagement;
using UnityEngine;
public class Events : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("MiniGame");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}

