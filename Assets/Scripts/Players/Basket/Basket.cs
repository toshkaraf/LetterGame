using UnityEngine;
using System.Collections;

public class Basket : MonoBehaviour
{

    public float speed = 100f;
    private Rigidbody2D myBody;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        HandleKeyboard();
    }

    void HandleKeyboard()
    {
        float forceX = 0f;

        float h = Input.GetAxisRaw("Horizontal");

        if (h > 0) forceX = speed;
        else if (h < 0) forceX = -speed;

        myBody.AddForce(new Vector2(forceX, 0));
        //     transform.position.x = ;

    }


    void OnTriggerEnter2D(Collider2D target)
    {
        print("YAY! basket");
        if (target.tag == "Egg")
        {
            target.gameObject.SetActive(false);
        }
    }

}
