using UnityEngine;
using System.Collections;
using System;

public class Basket : MonoBehaviour
{

    public float speed = 0.1f;
    private BoxCollider2D boxCollider;

    void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void FixedUpdate()
    {
        HandleKeyboard();
    }

    void HandleKeyboard()
    {

        float h = Input.GetAxisRaw("Horizontal");

        if (h > 0) transform.position = new Vector2(Mathf.Clamp(transform.position.x + speed * Time.deltaTime,-GameInfo.screenBounds.x + boxCollider.size.x/2, GameInfo.screenBounds.x - boxCollider.size.x / 2), transform.position.y);
        else if (h < 0) transform.position = new Vector2(Mathf.Clamp(transform.position.x - speed * Time.deltaTime, -GameInfo.screenBounds.x + boxCollider.size.x / 2, GameInfo.screenBounds.x - boxCollider.size.x / 2), transform.position.y);

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
