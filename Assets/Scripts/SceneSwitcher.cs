using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneSwitcher : MonoBehaviour {

    public void PlayLetterGame()
    {
        //GameManager.instance.gameStartedFromMainMenu = true;
        print("change scene");
        SceneManager.LoadScene("LetterGamePlay");
        //SceneFader.instance.LoadLevel("Gameplay");
    }

    public void PlayCatchMouseGame()
    {
        //GameManager.instance.gameStartedFromMainMenu = true;
        print("change scene");
        SceneManager.LoadScene("CatchMouseGame");
        //SceneFader.instance.LoadLevel("Gameplay");
    }
}
