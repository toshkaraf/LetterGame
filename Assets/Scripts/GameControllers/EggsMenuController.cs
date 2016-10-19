using UnityEngine;
using System.Collections;

public class EggsMenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public void PlayLetterGame()
    {
        //GameManager.instance.gameStartedFromMainMenu = true;
        		Application.LoadLevel ("LetterGamePlay");
        //SceneFader.instance.LoadLevel("Gameplay");
    }

}
