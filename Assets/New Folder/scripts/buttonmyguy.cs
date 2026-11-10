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
        SceneManager.LoadScene("MAINGAME");
    }
    public void CHOIX1()
    {
        SceneManager.LoadScene("MAINGAME1");
    }
    public void CHOIX1_1()
    {
        SceneManager.LoadScene("MAINGAME1_1");
    }
    public void ENDING1()
    {
        SceneManager.LoadScene("MAINGAME2_1");
    }
    public void CHOIX1_2()
    {
        SceneManager.LoadScene("MAINGAME1_2");
    }
    public void ENDING2()
    {
        SceneManager.LoadScene("MAINGAME2_1");
    }
    public void CHOIX2()
    {
        SceneManager.LoadScene("MAINGAME2");
    }
    public void CHOIX2_1()
    {
        SceneManager.LoadScene("MAINGAME2_1");
    }
    public void ENDING3()
    {
        SceneManager.LoadScene("MAINGAME2_1");
    }
    public void CHOIX2_2()
    {
        SceneManager.LoadScene("MAINGAME_2_2");
    }
    public void ENDING4()
    {
        SceneManager.LoadScene("MAINGAME2_1");
    }
}
