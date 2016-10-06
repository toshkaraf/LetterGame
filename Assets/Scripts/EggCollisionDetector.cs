using UnityEngine;
using System.Collections;

public class EggCollisionDetector : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D target)
    {
        print("YAY!");
        if (target.tag == "Egg")
        {
            target.gameObject.SetActive(false);
        }
    }

}
