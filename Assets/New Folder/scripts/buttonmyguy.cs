using UnityEngine;
using UnityEngine.SceneManagement;
public class buttonmyguy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnClicknew_game()
    {
        SceneManager.LoadScene("MAINGAME");
    }
    void QuitGame() {
        Application.Quit();
        Debug.Log("Game is exiting");
//Just to make sure its working
    }
    public void OnClick_quit()
    {
        QuitGame();
    }

    // Update is called once per frame
    void start()
    {
        OnClicknew_game();
        OnClick_quit();
    }
}
