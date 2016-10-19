using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneMenuSwitcher : MonoBehaviour {


    public void PlayLetterGame()
    {
        //GameManager.instance.gameStartedFromMainMenu = true;
        print("change scene");
        SceneManager.LoadScene("LetterGamePlay");
        //SceneFader.instance.LoadLevel("Gameplay");
    }
}
