using UnityEngine;
using System.Collections;

public class GameInfo : MonoBehaviour {

    public static Vector3 screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    public static Vector3 backgroundSize;

    // Use this for initialization
    void Start () {    
    backgroundSize = GameObject.FindGameObjectWithTag("EggBG").transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
